using SpaceVikingsGUI.Data.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.IO;

namespace SpaceVikingsGUI.Services
{
    public class UserService : Service.IService<IUser, IUser>
    {
        private readonly List<IUser> _users;
        private readonly string _address;

        public UserService(string address)
        {
            _address = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, address);
            _users = new List<IUser>(JsonParser.Load<User>(_address));
        }

        public IUser Get(IUser obj)
        {
            var user = _users.FirstOrDefault(x => x.Email == obj.Email && x.Password == obj.Password);
            if (user == null)
                throw new Exception("User is not valid!");

            return user;
        }

        public List<IUser> GetAll()
        {
            return _users;
        }

        public IUser Add(IUser obj)
        {

            var user = _users.Find(existingUser => existingUser.Email == obj.Email);

            if (user != null)
                throw new Exception("User already exists!");

            obj.ID = new Random().Next(1, 450000000);

            _users.Add(obj);

            JsonParser.Save(_address, _users);

            return obj;
        }
    }
}