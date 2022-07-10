using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Business
{
    public class Person
    {
        public static List<Entities.Person> GetAll()
        {
            return Data.Person.GetAll();
        }

        public Entities.Person GetOne(int ID)
        {
            return Data.Person.GetOne(ID);
        }

        public void Insert(Entities.Person person)
        {
            Data.Person.Insert(person);
        }

        public static void Delete(int ID)
        {
            Data.Person.Delete(ID);
        }

        public void Save(Entities.Person person)
        {
            Data.Person.Save(person);
        }
    }
}
