using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class Province
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nombre requerido")]
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
