using System;
using System.Windows.Forms;
using WindowsFormsApp1.Service;
using WindowsFormsApp1.Service.ServiceImpl;
using WindowsFormsApp1.UI;

namespace WindowsFormsApp1
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

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            try
            {
                Application.Run(new LogInForm());
            }
            catch (Exception ex)
            {
                // Handle any uncaught exceptions
                MessageBox.Show($"An unhandled exception occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Run(new Main()); //Prasanje
            }
        }

        // Global exception handler
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {  
            Exception ex = e.ExceptionObject as Exception;
            MessageBox.Show($"An unhandled exception occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
