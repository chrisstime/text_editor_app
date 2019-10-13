using System;
using System.Windows.Forms;

namespace text_editor_app
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

            // Load the users from the login text file
            UserList.LoadUsers("login.txt");
            // Run the login form
            Application.Run(new LoginForm());
        }
    }
}
