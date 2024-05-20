using System.Configuration;
using System.Reflection.Metadata;

namespace DBProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static string? connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}