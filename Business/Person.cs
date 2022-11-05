using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Business
{
    public class Person
    {
        public List<Entities.Person> GetAll()
        {
            Data.Person dataPerson = new Data.Person();
            return dataPerson.GetAll();
        }

        public Entities.Person GetOne(int id)
        {
            Data.Person dataPerson = new Data.Person();
            return dataPerson.GetOne(id);
        }

        public void Insert(Entities.Person person)
        {
            Data.Person dataPerson = new Data.Person();
            dataPerson.Add(person);
        }
        
        public void Edit(Entities.Person person)
        {
            Data.Person dataPerson = new Data.Person();
            dataPerson.Edit(person);
        }

        public void Save(Entities.Person person)
        {
            if(person.Id != 0)
            {
                Edit(person);
            } else
            {
                Insert(person);
            }
        }

        public void Delete(int id)
        {
            Data.Person dataPerson = new Data.Person();
            dataPerson.Delete(id);
        }
    }
}
