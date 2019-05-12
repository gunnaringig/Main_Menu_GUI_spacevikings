using System;
using System.Threading.Tasks;

namespace SpaceVikingsGUI.APIConsumption
{
    public interface IHttpClientHelper
    {
        Task<Login> GetLogin(string email, string password);
        Task PostLogin(Login login);
    }
}