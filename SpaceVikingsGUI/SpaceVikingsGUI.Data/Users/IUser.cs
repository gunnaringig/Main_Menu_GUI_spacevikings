using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceVikingsGUI.Data.Users
{
    public interface IUser
    {
        int ID { get; set; }
        string Email { get; set; }
        string Password { get; set; }
    }
}