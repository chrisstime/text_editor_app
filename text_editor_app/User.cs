using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_editor_app
{
    public class User
    {
        public enum UserType
        {
            Edit, View
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string DOB { get; set; }

        public void LoadUser(string fileLine)
        {
            // Split the comma seperated string into fields 
            string[] fields = fileLine.Split(',');

            // Assign values to respective properties/ members
            UserName = fields[0];
            Password = fields[1];
            Type = fields[2].ToLower().Equals("view") ? User.UserType.View : User.UserType.Edit; ;
            FName = fields[3];
            LName = fields[4];
        }
    }
}
