using System;
using System.Windows.Forms;

namespace DoAnCK
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

        
            try
            {
                Application.Run(new Form());
            }
            catch (ObjectDisposedException)
            {
                return;
            }

        }
    }
}