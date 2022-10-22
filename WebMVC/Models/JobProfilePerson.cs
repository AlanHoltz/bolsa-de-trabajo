using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class JobProfilePerson
    {
        [Key]
        public int Id { get; set; }
        public JobProfile JobProfiles { get; set; }
        [Required]
        public int JobProfilesId { get; set; }
        [Required]
        public Person Persons { get; set; }
        [Required]
        public int PersonsId { get; set; }
        [MaxLength(100)]
        public string Observations { get; set; }
        [MaxLength(50)]
        public string Status { get; set; }
    }
}
