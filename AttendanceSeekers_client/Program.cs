using AttendanceSeekers_client;

namespace AttendanceSeekers_client
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new MainForm());
=======
            Application.Run(new welcomeForm());
        
        
>>>>>>> dec2f2bb63f2ec8b16d7d323195f3825583408fa
        }
    }
}