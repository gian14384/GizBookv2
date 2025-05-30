using System.Drawing;

namespace GizBookv2
{
    public class UserRegistrationData
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public Image Avatar { get; set; }

        // Static list to store all registered users
        public static List<UserRegistrationData> RegisteredUsers { get; } = new List<UserRegistrationData>();
    }
}