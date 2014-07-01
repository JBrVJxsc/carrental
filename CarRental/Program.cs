using System;
using System.Drawing;
using System.Windows.Forms;
using CarRentalLibrary.Controls.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Utils;

namespace CarRental
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length != 1 || args[0] != "who")
            {
                return;
            }

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            AppearanceObject.DefaultFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
