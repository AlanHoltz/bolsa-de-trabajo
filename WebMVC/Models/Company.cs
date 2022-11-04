using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVC.Models
{
    public class Company
    {
        [Key]
        [ForeignKey("User")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Email requerido")]
        [EmailAddress(ErrorMessage = "Ingrese un email válido")]
        [NotMapped]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Contraseña requerida")]
        [Display(Name = "Contraseña")]
        [NotMapped]
        public string Password { get; set; }
        [Required(ErrorMessage = "Nombre requerido")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Required(ErrorMessage = "CUIT requerido")]
        public string Cuit { get; set; }
        [Required(ErrorMessage = "Dirección requerida")]
        [Display(Name = "Dirección")]
        public string Address { get; set; }
        public string Photo { get; set; }
        [Required]
        [Display(Name = "Ciudad")]
        public string CityZipCode { get; set; }
        [Display(Name = "Nombre de referencia")]
        public string ReferenceName { get; set; }
        [Display(Name = "Teléfono de referencia")]
        public string ReferencePhone { get; set; }
        [EmailAddress(ErrorMessage = "Ingrese un email válido")]
        [Display(Name = "Email de referencia")]
        public string ReferenceEmail { get; set; }
        public string ReferenceArea { get; set; }
        public string ReferenceWorkingOnCompany { get; set; }
        public string Status { get; set; }
        public User User { get; set; }
        [ForeignKey("CityZipCode")]
        public City City { get; set; }
    }
}
