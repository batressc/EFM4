using EFM4.Controllers;
using System;
using System.Windows.Forms;

namespace EFM4.Main {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainController mainController = new MainController();
            Application.Run(mainController.View);
        }
    }
}
