using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsa.Entities
{
    public class Internship : JobProfile
    {
        public Internship()
        {

        }
        public Internship(int id, String mail, DateTime startingDate, DateTime endingDate, String address, int capacity, String description, String position, int companyId, bool agreement, int duration, DateTime starting) : base(id, mail, startingDate, endingDate, address, capacity, description, position, companyId)
        {
            Agreement = agreement;
            Duration = duration;
            Starting = starting;
        }

        public Internship(String mail, DateTime startingDate, DateTime endingDate, String address, int capacity, String description, String position, int companyId, bool agreement, int duration, DateTime starting) : base(mail, startingDate, endingDate, address, capacity, description, position, companyId)
        {
            Agreement = agreement;
            Duration = duration;
            Starting = starting;
        }
        public bool Agreement { get; set; }
        //Minimo 2 meses maximo 12 meses
        public int Duration { get; set; }
        public DateTime Starting { get; set; }

    }
}
