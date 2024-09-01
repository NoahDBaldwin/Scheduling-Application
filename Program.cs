using SchedulingApplication.Database;
using System.Net.Http.Headers;

namespace SchedulingApplication
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // Start with the login form but don't run the applicaiton until menu form shows.
            ApplicationConfiguration.Initialize();
            LoginForm loginForm = new LoginForm();
            DBConnection.startConnection();
            if(loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MenuForm());
            }
            else
            {
                Application.Exit();
            }

            DBConnection.closeConnection();
            
        }
    }
}