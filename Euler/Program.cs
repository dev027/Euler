using System;
using System.Windows.Forms;

namespace Euler
{
    // ReSharper disable once InconsistentNaming
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <exception cref="System.IO.IOException">Ignore.</exception>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmMain());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
