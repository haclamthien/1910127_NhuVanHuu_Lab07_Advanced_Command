using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07_Advanced_Command
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new RoleAccountForm());
            // Application.Run(new AccountForm());
            //Application.Run(new BillForm());
            //Application.Run(new Form1());
            Application.Run(new AccountManagementForm());
        }
    }
}
