using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVC.Models
{
    public class JobProfile
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string EmailReceptor { get; set; }
        [Required]
        public DateTime StartingDate { get; set; }
        [Required]
        public DateTime EndingDate { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int Capacity { get; set; }
        public string Description { get; set; }
        [Required]
        public string Position { get; set; }
        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<JobProfilePerson> JobProfilePerson { get; set; }
        public ICollection<Career> Careers { get; set; }
        public Internship Internship { get; set; }
        public Relationship Relationship { get; set; }

    }
}
