using SpaceVikingsGUI.Data.Users;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceVikingsGUI.Services
{
    public class Service
    {
        public interface IService<T, M>
        {
            T Get(M obj);
            List<T> GetAll();
            T Add(T obj);
        }

        public static class ServiceFactory
        {
            private const string Users = @"Data\Users.json";

            public static IService<IUser, IUser> CreateUserService(string address = Users)
                => new UserService(address);
        }
    }
}