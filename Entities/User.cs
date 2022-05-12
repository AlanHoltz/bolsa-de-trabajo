using System;

namespace Bolsa.Entities
{
    public abstract class User
    {
        public int Id { get; set; }
        public String Mail { get; set; }
        public String Password { get; set; }
        public Boolean Status { get; set; }
        public DateTime Date { get; set; }
    }
}
