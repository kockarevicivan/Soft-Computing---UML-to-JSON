using SoftComputing.UTJ.Presentation.Helpers;
using System;
using System.Windows.Forms;

namespace SoftComputing.UTJ.Presentation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FileHelper.ClearTempDirectory();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


    }
}
