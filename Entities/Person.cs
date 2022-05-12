using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsa.Entities
{
    public class Person : User
    {
        public Person()
        {

        }
        public Person(int id, String mail, String password, Boolean status, DateTime signupDate, String name, String surname, String photo, String cv, Boolean isAdmin, DateTime birthDate)
        {
            Id = id;
            Mail = mail;
            Password = password;
            Status = Status;
            Date = signupDate;
            Name = name;
            Surname = surname;
            Photo = photo;
            Cv = cv;
            IsAdmin = isAdmin;
            BirthDate = birthDate;
        }
        public Person(String mail, String password, DateTime signupDate, String name, String surname, String photo, String cv, Boolean isAdmin, DateTime birthDate)
        {
            Mail = mail;
            Password = password;
            Date = signupDate;
            Name = name;
            Surname = surname;
            Photo = photo;
            Cv = cv;
            IsAdmin = isAdmin;
            BirthDate = birthDate;
        }
        public Person(int id, String password, String name, String surname)
        {
            Id = id;
            Password = password;
            Name = name;
            Surname = surname;
        }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Photo { get; set; }
        public String Cv { get; set; }
        public Boolean IsAdmin { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString()
        {
            return $"{Id}: {Name} {Surname} ({Mail}), {IsAdmin}";
        }
    }
}
