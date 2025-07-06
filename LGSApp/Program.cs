using System;
using System.Windows.Forms;

namespace LGSApp
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show the splash form
            using (SplashForm splash = new SplashForm())
            {
                // ShowDialog blocks until the splash form closes
                DialogResult result = splash.ShowDialog();

                // Proceed to LoginForm only if splash completed successfully
                if (result == DialogResult.OK)
                {
                    Application.Run(new LoginForm());
                }
            }
        }
    }
}