using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsa.Entities
{
    public class JobProfile
    {
        public JobProfile()
        {

        }
        public JobProfile(int id, String mail, DateTime startingDate, DateTime endingDate, String address, int capacity, String description, String position, int companyId)
        {
            Id = id;
            MailReceptor = mail;
            StartingDate = startingDate;
            EndingDate = endingDate;
            Address = address;
            Capacity = capacity;
            Description = description;
            Position = position;
            CompanyId = companyId;
        }

        public JobProfile(String mail, DateTime startingDate, DateTime endingDate, String address, int capacity, String description, String position, int companyId)
        {
            MailReceptor = mail;
            StartingDate = startingDate;
            EndingDate = endingDate;
            Address = address;
            Capacity = capacity;
            Description = description;
            Position = position;
            CompanyId = companyId;
        }
        public int Id { get; set; }
        public String MailReceptor { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public String Address { get; set; }
        public int Capacity { get; set; }
        public String Description { get; set; }
        public String Position { get; set; }
        public int CompanyId { get; set; }

    }
}
