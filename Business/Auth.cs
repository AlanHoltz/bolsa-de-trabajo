using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Business
{
    public class Auth
    {
        public static Boolean Login(Entities.User user)
        {
            return Data.Auth.Login(user);
        }
    }
}
