using System.Drawing;

namespace GizBookv2
{
    public class UserRegistrationData
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Image Avatar { get; set; }

        public UserRegistrationData() { }

        public UserRegistrationData(string name, string username, string password, Image avatar)
        {
            Name = name;
            Username = username;
            Password = password;
            Avatar = avatar;
        }
    }
}