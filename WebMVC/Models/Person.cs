using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVC.Models
{
    public class Person
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
        [Required(ErrorMessage = "Apellido requerido")]
        [Display(Name = "Apellido")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Fecha de nacimiento requerida")]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime BirthDate { get; set; }
        public string Cv { get; set; }
        [DefaultValue(false)]
        public bool IsAdmin { get; set; }
        public User User { get; set; }
        public ICollection<JobProfilePerson> JobProfilePerson { get; set; }

    }
}
