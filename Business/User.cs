using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Business
{
    public class User
    {
        public Entities.User Login(string mail, string password)
        {
            Data.User dataUser = new Data.User();
            Entities.User foundUser = dataUser.GetOne(mail);

            if (foundUser != null && foundUser.Password == password) return foundUser;

            return null;
        }

    }
}
