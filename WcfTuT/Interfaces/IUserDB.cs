using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfTuT
{
    public interface IUserDB
    {
        User GetUserData(int userID);
        void AddUser(User user);
        void RemoveUser(int userID);
        void UpdateUser(User user);
    }
}
