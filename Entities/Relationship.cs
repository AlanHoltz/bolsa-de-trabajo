using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsa.Entities
{
    public class Relationship : JobProfile
    {
        public Relationship()
        {

        }
        public Relationship(int id, String mail, DateTime startingDate, DateTime endingDate, String address, int capacity, String description, String position, int companyId, int workdayTime) : base(id, mail, startingDate, endingDate, address, capacity, description, position, companyId)
        {
            WorkdayTime = workdayTime;
        }

        public Relationship(String mail, DateTime startingDate, DateTime endingDate, String address, int capacity, String description, String position, int companyId, int workdayTime) : base(mail, startingDate, endingDate, address, capacity, description, position, companyId)
        {
            WorkdayTime = workdayTime;
        }
        public int WorkdayTime { get; set; }

    }
}
