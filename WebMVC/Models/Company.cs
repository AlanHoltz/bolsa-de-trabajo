using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVC.Models
{
    public class Company
    {
        [Key]
        [ForeignKey("User")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nombre requerido")]
        public string Name { get; set; }
        [Required(ErrorMessage = "CUIT requerido")]
        public string Cuit { get; set; }
        [Required(ErrorMessage = "Dirección requerida")]
        public string Address { get; set; }
        public string Photo { get; set; }
        [Required]
        public string CityZipCode { get; set; }
        public string ReferenceName { get; set; }
        public string ReferencePhone { get; set; }
        public string ReferenceEmail { get; set; }
        public string ReferenceArea { get; set; }
        public string ReferenceWorkingOnCompany { get; set; }
        public User User { get; set; }
        [ForeignKey("CityZipCode")]
        public City City { get; set; }
    }
}
