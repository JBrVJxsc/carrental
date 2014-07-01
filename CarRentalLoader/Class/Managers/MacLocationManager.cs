using System.Management;

namespace CarRentalLoader.Class.Managers
{
    public class MacLocationManager
    {
        public string GetHostMacAddress()
        {
            ManagementClass mc;
            string mac = string.Empty;
            mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if (mo["IPEnabled"].ToString() == "True")
                {
                    mac = mo["MacAddress"].ToString();
                }
            }
            return mac.Replace(":", string.Empty);
        }
    }
}
