using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asrama_Management_System
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
            //Application.Run(new Registrationcs());
            //Application.Run(new FormLogin());
            //Application.Run(new SignUp());
            //Application.Run(new DataPenghuni());
            //Application.Run(new Dashboard());

            FormLogin loginForm = new FormLogin();
            if (loginForm.ShowDialog() == DialogResult.OK) // Assuming login is successful and DialogResult is OK
            {
                string username = loginForm.Username;  // Pastikan FormLogin punya properti Username
                Application.Run(new Dashboard(username));
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
