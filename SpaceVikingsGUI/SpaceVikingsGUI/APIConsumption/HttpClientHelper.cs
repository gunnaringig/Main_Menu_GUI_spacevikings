using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SpaceVikingsGUI.APIConsumption
{
    public class HttpClientHelper
    {
        public SerializationDeserialization SerializationDeserialization1 = new SerializationDeserialization();
        public async Task<Login> GetLogin(string email, string password)
        {
            Login login = new Login();
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"http://localhost:56096/api/Login?email={email}&password={password}");
                
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    return SerializationDeserialization1.FromJsonToObject(responseBody);
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task PostLogin(Login login)
        {
            var loginAsJson = SerializationDeserialization1.FromObjectToJson(login);
            var content = new StringContent(loginAsJson, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.PostAsync($"http://localhost:56096/api/Logins", content);
                    response.EnsureSuccessStatusCode();
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                }
            }
        }
    }
}