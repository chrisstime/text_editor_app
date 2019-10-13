namespace text_editor_app
{
    public class User
    {
        // Enums for UserTypes.
        public enum UserType
        {
            Edit, View
        }

        // Get and setters for the user attributes.
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string DOB { get; set; }

        /* Method for loading the user into the User class from the login text file line.
         */
        public void LoadUser(string fileLine)
        {
            // Split the comma seperated string into fields.
            string[] fields = fileLine.Split(',');

            // Assign values to respective attributes.
            UserName = fields[0];
            Password = fields[1];
            Type = fields[2].ToLower().Equals("view") ? User.UserType.View : User.UserType.Edit; ;
            FName = fields[3];
            LName = fields[4];
        }

        /* Method to check if the user can edit files or not.
         * Returns a bool true if they can edit, false if they can't.
         */
        public bool CanEdit()
        {
            return Type.Equals(User.UserType.Edit);
        }
    }
}
