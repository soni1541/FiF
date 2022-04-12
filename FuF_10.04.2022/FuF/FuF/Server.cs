using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace FuF
{
    internal class Server
    {
        static string ip = "192.168.43.84";
        static string server_port = "5006";

        public static List<User> get_all_users()
        {
            WebClient client = new WebClient();
            string s = $"http://{Server.ip}:{Server.server_port}/api/User";
            using (Stream stream = client.OpenRead(s))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string data = reader.ReadToEnd();
                    List<User> users = JsonConvert.DeserializeObject<List<User>>(data);
                    return users;
                }
            }
        }
        public static User get_user(string email, string password)
        {
            WebClient client = new WebClient();
            string s = $"http://{Server.ip}:{Server.server_port}/api/User/login";

            var vm = new {email = email, password = password};
            var dataString = JsonConvert.SerializeObject(vm);
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");

            string data = client.UploadString(s, "POST", dataString);
            
            User user = JsonConvert.DeserializeObject<User>(data);
            
            return user;

        }

        public static void update_count_nuts(User user, int count_append)
        {
            WebClient client = new WebClient();
            string s = $"http://{Server.ip}:{Server.server_port}/api/User/login";
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            int payload = user.nuts + count_append;
            client.UploadString(s, WebRequestMethods.Http.Put, JsonConvert.SerializeObject(payload));
        }

        public static void update_level(User user)
        {
            WebClient client = new WebClient();
            string s = $"http://{Server.ip}:{Server.server_port}/api/User/login";
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            int payload = user.level + 1;
            client.UploadString(s, WebRequestMethods.Http.Put, JsonConvert.SerializeObject(payload));
        }
    }
}
