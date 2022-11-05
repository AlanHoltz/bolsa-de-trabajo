using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bolsa.Entities
{
    public class Internship
    {
        [Key]
        [ForeignKey("JobProfile")]
        public int Id { get; set; }
        public bool Agreement { get; set; }
        [Required(ErrorMessage = "Duración requerida")]
        public int Duration { get; set; }
        public DateTime Starting { get; set; }
        public JobProfile JobProfile { get; set; }
    }
}
