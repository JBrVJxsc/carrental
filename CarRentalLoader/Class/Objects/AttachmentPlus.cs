using System;
using System.IO;
using System.Windows.Forms;
using CarRentalLoader.Class.Managers;
using DevExpress.XtraEditors;
using LumiSoft.Net.MIME;

namespace CarRentalLoader.Class.Objects
{
    public class AttachmentPlus
    {
        public string Text
        {
            get;
            set;
        }

        public MIME_Entity MimeEntity
        {
            get;
            set;
        }

        public bool SaveToFile(string fileFullName)
        {
            if (MimeEntity == null)
            {
                return false;
            }
            try
            {
                File.Delete(fileFullName);
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("保存更新文件出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            byte[] bytes = (MimeEntity.Body as MIME_b_SinglepartBase).Data;
            MemoryStream memoryStream = new MemoryStream(bytes);
            FileStream fileStream = new FileStream(fileFullName, FileMode.Create);
            memoryStream.WriteTo(fileStream);
            memoryStream.Close();
            fileStream.Close();
            memoryStream.Dispose();
            fileStream.Dispose();
            return true;
        }
    }
}
