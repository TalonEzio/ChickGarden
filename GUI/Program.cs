using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmDangNhap());
            Application.Run(new frmTrangChu(new DTO.TaiKhoan() { Username = "TalonEzio", Password = "manhngu123", isAdmin = true, TaiKhoanId = 1 }));
        }
    }
}
