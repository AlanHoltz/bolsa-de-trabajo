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

        public Entities.City GetOne(String zipCode)
        {
            return Data.City.GetOne(zipCode);
        }

        public static void Insert(Entities.City city)
        {
            Data.City.Insert(city);
        }
        public static void Update(Entities.City city)
        {
            Data.City.Update(city);
        }
        public static void Delete(String zipCode)
        {
            Data.City.Delete(zipCode);
        }
        public void Save(Entities.City city)
        {
            Data.City.Save(city);
        }
    }
}
