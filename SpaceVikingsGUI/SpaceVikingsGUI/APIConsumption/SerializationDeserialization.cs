using Newtonsoft.Json;

namespace SpaceVikingsGUI.APIConsumption
{
    //Get newtonsoft json from nuget
    public class SerializationDeserialization
    {

        public Login FromJsonToObject(string jsonFromApi)
        {
            var login = JsonConvert.DeserializeObject<Login>(jsonFromApi);
            return login;
        }

        public string FromObjectToJson(Login login)
        {
            var loginAsJson = JsonConvert.SerializeObject(login);
            return loginAsJson;
        }

    }
}