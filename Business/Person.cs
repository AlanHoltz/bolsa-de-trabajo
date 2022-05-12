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

        public static void Insert(Entities.Person person)
        {
            Data.Person.Insert(person);
        }

        public static void Update(Entities.Person person)
        {
            /*
             * TODO
             * Faltaría hacer acá la subida de imágenes y cv y asignarle la url a
             * person.Photo y person.Cv con los setters
             */
            person.Photo = "";
            person.Cv = "";

            Data.Person.Update(person);
        }
        public static void Delete(Entities.Person person)
        {
            Data.Person.Delete(person);
        }
    }
}
