using PROJECT_DESKTOP_WINFORM_FINAL.GUI;

namespace PROJECT_DESKTOP_WINFORM_FINAL.GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            Application.Run(new Login());
        }
    }
}