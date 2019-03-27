using System;
using System.Windows.Forms;

namespace CTDB
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

            FormLogin f = new FormLogin();
            if (f.ShowDialog() == DialogResult.OK)
            {
                CTHelper.SetConfig("userid", f.userid);
                Application.Run(new CTDBForm1());
            }

        }
    }
}
