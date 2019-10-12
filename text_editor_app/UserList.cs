using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_editor_app
{
    public static class UserList
    {
        private static readonly string projectDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public static List<User> users = new List<User>();

        public static void LoadUsers(string filename)
        {
            StreamReader fileContent = new StreamReader(Path.Combine(projectDir, filename));
            User usrTemp;

            while (!fileContent.EndOfStream)
            {
                usrTemp = new User();
                string line = fileContent.ReadLine();
                usrTemp.LoadUser(line);
                users.Add(usrTemp);
            }
            fileContent.Close();
        }

        public static User GetUser(string userName, string password)
        {
            User foundUser = users.FirstOrDefault(user => user.UserName.Equals(userName) && user.Password.Equals(password));
            return foundUser;
        }

        public static void AddUser(string fileLine)
        {
            User newUser = new User();
            newUser.LoadUser(fileLine);
            users.Add(newUser);
        }
    }
}
