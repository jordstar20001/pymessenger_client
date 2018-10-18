using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessengerClient
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
            Application.ApplicationExit += OnProcessExit;
            Application.ThreadException += Application_ThreadException;
                        Application.Run(new Main());

        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            // Put exception handling code here!
            throw new NotImplementedException();
        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Save();
            }
            catch
            {

                
            }
        }
    }
}
