using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bolsa.Entities
{
    public class Relationship
    {

        [Key]
        [ForeignKey("JobProfile")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tiempo de trabajo requerido")]
        public int WorkdayTime { get; set; }
        public JobProfile JobProfile { get; set; }
    }
}
