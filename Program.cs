using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone
{
    static class Program
    {

        public static User[] users = new User[] { new User("Alex", "Password"),
        new User("James", "Password")};
        public static string loggedUser = "Login";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

       

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
