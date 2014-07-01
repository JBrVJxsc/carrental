
namespace CarRentalLoader.Class.Managers
{
    public class UserCodeManager
    {
        public static string UserCode = string.Empty;

        public static string GetUserCode()
        {
            MacLocationManager macLocationManager = new MacLocationManager();
            UserCode = macLocationManager.GetHostMacAddress();
            UserCode = EncryptionManager.Encrypt(UserCode).Replace("+", string.Empty).Replace("=", string.Empty).Replace("/", string.Empty).Replace("\\", string.Empty).ToUpper();
            UserCode = UserCode.Replace("B", string.Empty).Replace("O", string.Empty).Replace("I", string.Empty).Replace("Z", string.Empty).Replace("S", string.Empty).Replace("G", string.Empty).Replace("J", string.Empty).Replace("V", string.Empty).Replace("W", string.Empty);
            UserCode = UserCode.Replace("8",string.Empty).Replace("0", string.Empty).Replace("1", string.Empty).Replace("2", string.Empty).Replace("5", string.Empty).Replace("4",string.Empty);
            return UserCode;
        }
    }
}
