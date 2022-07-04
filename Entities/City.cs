using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsa.Entities
{
    public class City
    {
        public City()
        {

        }
        public City(String zipCode, String name, int provinceId)
        {
            ZipCode = zipCode;
            Name = name;
            ProvinceId = provinceId;
        }

        public City(String name, int provinceId)
        {
            Name = name;
            ProvinceId = provinceId;
        }
        public String ZipCode { get; set; }
        public String Name { get; set; }
        public int ProvinceId { get; set; }

    }
}
