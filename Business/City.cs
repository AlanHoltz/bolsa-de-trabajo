using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Business
{
    public class City
    {
        public static List<Entities.City> GetAll()
        {
            return Data.City.GetAll();
        }

        public static void Insert(Entities.City city)
        {
            Data.City.Insert(city);
        }
        public static void Update(Entities.City city)
        {
            Data.City.Update(city);
        }
        public static void Delete(Entities.City city)
        {
            Data.City.Delete(city);
        }
    }
}
