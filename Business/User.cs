using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Business
{
    public class User
    {
        public static List<Entities.User> GetAll()
        {
            return Data.User.GetAll();
        }
    }
}
