using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using CarRentalLoader.Class.Objects;
using CarRentalLoader.Controls.Forms;
using DevExpress.XtraEditors;
using LumiSoft.Net;
using LumiSoft.Net.IMAP;
using LumiSoft.Net.IMAP.Client;
using LumiSoft.Net.Mail;
using LumiSoft.Net.MIME;

namespace CarRentalLoader.Class.Managers
{
    public class CommunicationManager
    {
        private string imapHost = "imap.163.com";
        private int imapPort = 993;
        private bool imapUseSSL = true;
        private bool smtpUseSSL = true;
        private string userName = "tl_carrental_c";
        private string password = "zx1987723";
        private List<long> mailMessageUIDList = new List<long>();
        private List<string> mailMessageSubjectList = new List<string>();
        private List<Mail_Message> mailMessageList = new List<Mail_Message>();
        private SmtpClient smtpClient = new SmtpClient("smtp.163.com", 25);
        private MailMessage mailMessage = new MailMessage();

        private IMAP_Client client = null;

        public bool Connect()
        {
            try
            {
                client = new IMAP_Client();
                client.Connect(imapHost, imapPort, imapUseSSL);
                return true;
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("连接服务器出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                client.Dispose();
                return false;
            }
        }

        public bool Login()
        {
            try
            {
                client.Login(userName, password);
                return true;
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("身份验证出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                client.Dispose();
                return false;
            }
        }

        public void Disconnect()
        {
            if (client != null && !client.IsDisposed)
            {
                client.Dispose();
                client = null;
            }
        }

        public ArrayList GetLoginAccounts()
        {
            LoadFolderMessages("LOGIN");
            LoadMessages(mailMessageUIDList);
            ArrayList accountList = new ArrayList();
            if (mailMessageList.Count == 1)
            {
                string[] accounts = mailMessageList[0].BodyText.Replace(" ", string.Empty).Replace("\n", string.Empty).Split(',');
                if (accounts.Length > 0)
                {
                    accountList = new ArrayList(accounts);
                }
            }
            return accountList;
        }

        public int GetUpdateVersion()
        {
            LoadFolderMessages("UPDATE");
            if (mailMessageSubjectList.Count == 1)
            {
                try
                {
                    return Convert.ToInt32(mailMessageSubjectList[0]);
                }
                catch (Exception e)
                {
                    LogManager.GlobalLogManager.CreateLog(e);
                    XtraMessageBox.Show("获取更新版本号出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            return 0;
        }

        public List<AttachmentPlus> GetUpdateFiles()
        {
            LoadFolderMessages("UPDATE");
            LoadMessages(mailMessageUIDList);
            List<AttachmentPlus> attachmentList = new List<AttachmentPlus>();
            if (mailMessageList.Count == 1)
            {
                attachmentList = GetAttachments(mailMessageList[0]);
            }
            return attachmentList;
        }

        public bool SendMessage(string subject, string content)
        {
            try
            {
                smtpClient.Credentials = new NetworkCredential(userName, password);
                smtpClient.EnableSsl = smtpUseSSL;
                mailMessage.Subject = subject;
                mailMessage.From = new MailAddress("tl_carrental_c@163.com");
                mailMessage.To.Clear();
                mailMessage.To.Add("tl_carrental@163.com");
                mailMessage.Body = content;
                smtpClient.Send(mailMessage);
                return true;
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
            }
            return false;
        }

        public bool SendLogin()
        {
            try
            {
                smtpClient.Credentials = new NetworkCredential(userName, password);
                mailMessage.Subject = "登陆";
                mailMessage.From = new MailAddress("tl_carrental_c@163.com");
                mailMessage.To.Clear();
                mailMessage.To.Add("tl_carrental@163.com");
                mailMessage.Body = LoginSplashScreen.UserCode + " " + DateTime.Now.ToString();
                smtpClient.Send(mailMessage);
                return true;
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("提交登陆信息出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void LoadFolderMessages(string folder)
        {
            mailMessageUIDList.Clear();
            mailMessageSubjectList.Clear();
            try
            {
                client.SelectFolder(folder);
                client.Fetch(
                    false,
                    IMAP_t_SeqSet.Parse("*:*"),
                    new IMAP_t_Fetch_i[]{
                        new IMAP_t_Fetch_i_Envelope(),
                        new IMAP_t_Fetch_i_Uid()
                    },
                    clientFolderFetchHandle
                );
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("从服务器获取信息出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clientFolderFetchHandle(object sender, EventArgs<IMAP_r_u> e)
        {
            try
            {
                if (e.Value is IMAP_r_u_Fetch)
                {
                    IMAP_r_u_Fetch fetchResp = (IMAP_r_u_Fetch)e.Value;
                    if (!mailMessageUIDList.Contains(fetchResp.UID.UID))
                    {
                        mailMessageUIDList.Add(fetchResp.UID.UID);
                        mailMessageSubjectList.Add(fetchResp.Envelope.Subject);
                    }
                }
            }
            catch (Exception ex)
            {
                LogManager.GlobalLogManager.CreateLog(ex);
                XtraMessageBox.Show("从服务器获取信息出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMessages(List<long> uidList)
        {
            mailMessageList.Clear();
            foreach (long uid in uidList)
            {
                LoadMessage(uid);
            }
        }

        private void LoadMessage(long uid)
        {
            try
            {
                client.Fetch(
                    true,
                    IMAP_t_SeqSet.Parse(uid.ToString()),
                    new IMAP_t_Fetch_i[]{
                        new IMAP_t_Fetch_i_Rfc822()
                    },
                    clientMessageFetchHandle
                );
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("从服务器获取信息出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clientMessageFetchHandle(object sender, EventArgs<IMAP_r_u> e)
        {
            try
            {
                if (e.Value is IMAP_r_u_Fetch)
                {
                    IMAP_r_u_Fetch fetchResp = (IMAP_r_u_Fetch)e.Value;
                    fetchResp.Rfc822.Stream.Position = 0;
                    Mail_Message mime = Mail_Message.ParseFromStream(fetchResp.Rfc822.Stream);
                    fetchResp.Rfc822.Stream.Dispose();
                    if (!mailMessageList.Contains(mime))
                    {
                        mailMessageList.Add(mime);
                    }
                }
            }
            catch (Exception ex)
            {
                LogManager.GlobalLogManager.CreateLog(ex);
                XtraMessageBox.Show("从服务器获取信息出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<AttachmentPlus> GetAttachments(Mail_Message mailMessage)
        {
            List<AttachmentPlus> attachmentList = new List<AttachmentPlus>();
            foreach (MIME_Entity entity in mailMessage.Attachments)
            {
                AttachmentPlus attachment = new AttachmentPlus();
                attachment.MimeEntity = entity;
                if (entity.ContentDisposition != null && entity.ContentDisposition.Param_FileName != null)
                {
                    attachment.Text = entity.ContentDisposition.Param_FileName;
                }
                else
                {
                    attachment.Text = "untitled";
                }
                attachmentList.Add(attachment);
            }
            return attachmentList;
        }
    }
}
