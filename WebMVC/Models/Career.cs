using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class Career
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<JobProfile> JobProfiles { get; set; }
    }
}
