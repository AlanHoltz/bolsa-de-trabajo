using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bolsa.Entities
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
