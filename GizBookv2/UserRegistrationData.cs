using System.Drawing;

namespace GizBookv2
{
    public class UserRegistrationData
    {
        public required string name { get; set; }
        public required string username { get; set; }
        public string? password { get; set; }
        public string? confirmPassword { get; set; }
        public string? avatar { get; set; }

        // Static list to store all registered users
        public static List<UserRegistrationData> RegisteredUsers { get; } = [];
    }
}