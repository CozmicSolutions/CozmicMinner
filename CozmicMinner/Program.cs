using System;
using System.Windows.Forms;

namespace CozmicMinner
{
    using CozmicMinner.Forms;

    internal static class Program
    {
        #region Private Methods

        /// <summary>
        ///      The main entry point for the application. 
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(mainForm: new MiningDashboard());
        }

        #endregion Private Methods
    }
}