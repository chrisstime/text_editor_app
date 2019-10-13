using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace text_editor_app
{
    public static class UserList
    {
        private static readonly string projectDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        // Create a list of users.
        public static List<User> users = new List<User>();

        public static void LoadUsers(string filename)
        {
            StreamReader fileContent = new StreamReader(Path.Combine(projectDir, filename));

            // Read each file line and load it into a user.
            // Add the user into the users list.
            while (!fileContent.EndOfStream)
            {
                string line = fileContent.ReadLine();
                AddUser(line);
            }
            fileContent.Close();
        }

        /* Method for getting user from the list of users based on username and password.
         */
        public static User GetUser(string userName, string password)
        {
            // If a user with the matching username and password is found, return the user. Default if not found is null.
            User foundUser = users.FirstOrDefault(user => user.UserName.Equals(userName) && user.Password.Equals(password));
            return foundUser;
        }

        /* Method for adding user to the list.
         * Param: file line with user details in string format.
         */
        public static void AddUser(string fileLine)
        {

            User newUser = new User();
            newUser.LoadUser(fileLine);
            users.Add(newUser);
        }
    }
}
