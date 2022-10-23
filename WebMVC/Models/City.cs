using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVC.Models
{
    public class City
    {
        [Key]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "Nombre requerido")]
        public string Name { get; set; }
        [ForeignKey("Province")]
        public int ProvinceId { get; set; }
        public ICollection<Company> Companies { get; set; }
        public Province Province { get; set; }
    }
}
