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
        public Person(int id, String mail, String password, Boolean status, DateTime signupDate, String name, String surname, String photo, String cv, Boolean isAdmin, DateTime birthDate) : base(id, mail, password, status, signupDate)
        {
            Name = name;
            Surname = surname;
            Photo = photo;
            Cv = cv;
            IsAdmin = isAdmin;
            BirthDate = birthDate;
        }
        public Person(String mail, String password, Boolean status, DateTime signupDate, String name, String surname, String photo, String cv, Boolean isAdmin, DateTime birthDate) : base(mail, password, status, signupDate)
        {
            Name = name;
            Surname = surname;
            Photo = photo;
            Cv = cv;
            IsAdmin = isAdmin;
            BirthDate = birthDate;
        }
        public Person(int id, String password, String name, String surname) : base(id)
        {
            Password = password;
            Name = name;
            Surname = surname;
        }
        public Person(String mail, String password) : base(mail, password)
        {
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
