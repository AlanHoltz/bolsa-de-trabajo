using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Business
{
    public class Province
    {
        public List<Entities.Province> GetAll()
        {
            return Data.Province.GetAll();
        }

        public Entities.Province GetOne(int ID)
        {
            return Data.Province.GetOne(ID);
        }

        public void Insert(Entities.Province province)
        {
            Data.Province.Insert(province);
        }
        public void Update(Entities.Province province)
        {
            Data.Province.Update(province);
        }
        public void Delete(int ID)
        {
            Data.Province.Delete(ID);
        }

        public void Save(Entities.Province province)
        {
            Data.Province.Save(province);
        }
    }
}
