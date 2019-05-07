using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceVikingsGUI.Data.Users
{
    public class User : IUser
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}