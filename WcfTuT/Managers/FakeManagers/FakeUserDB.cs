using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfTuT
{
    public class FakeUserDB : IUserDB
    {
        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUserData(int userID)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(int userID)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}