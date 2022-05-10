using System;

namespace Bolsa.Entities
{
    public class User
    {
        public User(int id, string name, string height)
        {
            Id = id;
            Name = name;
            Height = height;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Height { get; set; }
        public override string ToString()
        {
                return $"{Id.ToString()}: {Name}, {Height}";
        }
    }
}
