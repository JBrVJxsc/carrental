using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using DevExpress.XtraEditors;

namespace CarRentalLoader.Class.Managers
{
    public class XmlManager<T>
    {
        private XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
        private LogManager logManager = new LogManager();

        public string SerializeToString(T t)
        {
            using (StringWriter sw = new StringWriter())
            {
                xmlSerializer.Serialize(sw, t);
                return sw.ToString();
            }
        }

        public T DeserializeToObject(string tXml)
        {
            using (StringReader sr = new StringReader(tXml))
            {
                T t = ((T)xmlSerializer.Deserialize(sr));
                return t;
            }
        }

        public bool SerializeToFile(T t, string url)
        {
            StreamWriter sw = new StreamWriter(url);
            try
            {
                sw.Write(SerializeToString(t));
                return true;
            }
            catch (Exception e)
            {
                logManager.CreateLog(e);
                XtraMessageBox.Show("从实体转化至文件出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sw.Close();
                sw.Dispose();
            }
            return false;
        }

        public T DeserializeToObjectFromFile(string url)
        {
            StreamReader sr = new StreamReader(url);
            string content = string.Empty;
            try
            {
                content = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception e)
            {
                logManager.CreateLog(e);
                XtraMessageBox.Show("从文件转化至实体出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sr.Close();
                sr.Dispose();
            }
            return DeserializeToObject(content);
        }
    }
}
