using RequestMaker.AppSettings;

namespace UserManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            AppSettingsBase.AppType = "Desktop";
            AppSettingsBase.BaseUrl = Environment.GetEnvironmentVariable("BASEURL_AUTHENTICATIONAPI")
                ?? throw new Exception("Could not initialise Base URL");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}