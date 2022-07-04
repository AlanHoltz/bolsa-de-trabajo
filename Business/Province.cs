using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Business
{
    public class Province
    {
        public static List<Entities.Province> GetAll()
        {
            return Data.Province.GetAll();
        }

        public static void Insert(Entities.Province province)
        {
            Data.Province.Insert(province);
        }
        public static void Update(Entities.Province province)
        {
            Data.Province.Update(province);
        }
        public static void Delete(Entities.Province province)
        {
            Data.Province.Delete(province);
        }
    }
}
