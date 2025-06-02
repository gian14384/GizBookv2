using Newtonsoft.Json;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GizBookv2
{
    public class UserRegistrationData
    {
        public required string name { get; set; }
        public required string username { get; set; }
        public string? password { get; set; }
        public string? confirmPassword { get; set; }
        public string? avatar { get; set; }

        public static dynamic FetchUserData(string username)
        {
            using HttpClient client = new();
            client.DefaultRequestHeaders.CacheControl = new System.Net.Http.Headers.CacheControlHeaderValue
            {
                NoCache = true,
                NoStore = true
            };

            var endpoint = new Uri($"https://gizbook.vercel.app/api/users/{username}");
            var response = client.GetAsync(endpoint).Result;
            var result = JsonConvert.DeserializeObject<dynamic>(response.Content.ReadAsStringAsync().Result)!;

            return result;
        }
    }
}