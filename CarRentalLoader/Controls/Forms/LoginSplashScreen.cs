using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using CarRentalLoader.Class.Managers;
using CarRentalLoader.Class.Objects;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace CarRentalLoader.Controls.Forms
{
    public partial class LoginSplashScreen : SplashScreen
    {
        public LoginSplashScreen()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private Process process = null;
        private CommunicationManager communicationManager = null;
        private string settingFileName = "Setting.xml";
        public static string UserCode = string.Empty;

        public Process Process
        {
            get
            {
                return process;
            }
        }

        public void Login()
        {
            communicationManager = new CommunicationManager();
            MacLocationManager macLocationManager = new MacLocationManager();

            Thread.Sleep(1000);
            lbTitle.Text = "正在连接服务器...";
            Thread.Sleep(1200);
            if (!communicationManager.Connect())
            {
                Close();
                return;
            }
            lbTitle.Text = "正在进行身份验证...";
            Thread.Sleep(1200);
            if (!communicationManager.Login())
            {
                Close();
                return;
            }

            UserCode = UserCodeManager.GetUserCode();
            ArrayList accountList = communicationManager.GetLoginAccounts();
            if (!accountList.Contains(UserCode))
            {
                XtraMessageBox.Show("本机未得到授权，请记录用户号后申请授权。\n用户号：" + UserCode, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
            else
            {
                lbTitle.Text = "正在更新配置...";
                Thread.Sleep(1200);

                XmlManager<Setting> xmlManager = new XmlManager<Setting>();
                if (!File.Exists(settingFileName))
                {
                    xmlManager.SerializeToFile(new Setting(), settingFileName);
                }
                Setting setting = xmlManager.DeserializeToObjectFromFile(settingFileName);
                int currentVersion = communicationManager.GetUpdateVersion();
                if (currentVersion > setting.Version)
                {
                    List<AttachmentPlus> attachmentList = communicationManager.GetUpdateFiles();
                    foreach (AttachmentPlus attachment in attachmentList)
                    {
                        if (!attachment.SaveToFile(attachment.Text))
                        {
                            Close();
                            return;
                        }
                    }
                }
                setting.Version = currentVersion;
                if (!xmlManager.SerializeToFile(setting, settingFileName))
                {
                    Close();
                    return;
                }
                communicationManager.SendLogin();
                Hide();
                if (File.Exists("CarRental.exe"))
                {
                    process = Process.Start("CarRental.exe", "who");
                    process.EnableRaisingEvents = true;
                    process.Exited += new EventHandler(process_Exited);
                }
            }
        }

        void process_Exited(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetDataObject(UserCode);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (communicationManager != null)
            {
                communicationManager.Disconnect();
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Thread thread = new Thread(Login);
            thread.Start();
        }
    }
}
