using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_editor_app
{
    public static class User
    {
        public enum UserType
        {
            Edit, View
        }

        public static string UserName { get; set; } = "";
        public static string Password { get; set; } = "";
        public static UserType Type { get; set; }
        public static string FName { get; set; } = "";
        public static string LName { get; set; } = "";
        public static string DOB { get; set; } = "";
    }
}
