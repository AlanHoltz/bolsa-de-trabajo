using System;

namespace Bolsa.Entities
{
    public abstract class User
    {
        public User(int id)
        {
            Id = id;
        }
        public User(int id, String mail, String password, Boolean status, DateTime signupDate)
        {
            Id = id;
            Mail = mail;
            Password = password;
            Status = status;
            Date = signupDate;
        }
        public User(String mail, String password, Boolean status, DateTime signupDate)
        {
            Mail = mail;
            Password = password;
            Status = status;
            Date = signupDate;
        }
        public User(String mail, String password)
        {
            Mail = mail;
            Password = password;
        }
        public int Id { get; set; }
        public String Mail { get; set; }
        public String Password { get; set; }
        public Boolean Status { get; set; }
        public DateTime Date { get; set; }
    }
}
