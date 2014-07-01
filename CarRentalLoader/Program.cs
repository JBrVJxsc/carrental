using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using CarRentalLoader.Class.Managers;
using CarRentalLoader.Controls.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using Microsoft.VisualBasic.ApplicationServices;

namespace CarRentalLoader
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Caramel";
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            AppearanceObject.DefaultFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            manager = new SingleInstanceManager();
            manager.Run(new string[] { });
        }

        static SingleInstanceManager manager;

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            manager.loginSplashScreen.TopMost = false;
            LogManager.GlobalLogManager.CreateLog(e.Exception);
            XtraMessageBox.Show("程序启动出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            manager.loginSplashScreen.Close();
        }

        public class SingleInstanceManager : WindowsFormsApplicationBase
        {
            public LoginSplashScreen loginSplashScreen;

            public SingleInstanceManager()
            {
                IsSingleInstance = true;
            }

            protected override bool OnStartup(Microsoft.VisualBasic.ApplicationServices.StartupEventArgs e)
            {
                loginSplashScreen = new LoginSplashScreen();
                Application.Run(loginSplashScreen);
                return false;
            }

            protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
            {
                base.OnStartupNextInstance(eventArgs);
            }
        }
    }
}
