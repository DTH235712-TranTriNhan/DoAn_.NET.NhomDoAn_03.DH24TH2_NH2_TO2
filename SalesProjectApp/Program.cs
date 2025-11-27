using SalesProjectApp.Forms;
using SalesProjectApp.Forms.Admin;
using System;
using System.Windows.Forms;

namespace SalesProjectApp
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
            Application.Run(new PosForm());
        }
    }
}
