using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsa.Entities
{
    public class Province:BusinessEntity
    {
        public Province()
        {

        }
        public Province(int id, String name)
        {
            Id = id;
            Name = name;
        }

        public Province(String name)
        {
            Name = name;
        }
        public int Id { get; set; }
        public String Name { get; set; }

    }
}
