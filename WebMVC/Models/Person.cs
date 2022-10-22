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
        [Required(ErrorMessage = "Nombre requerido")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Apellido requerido")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Fecha de nacimiento requerida")]
        public DateTime BirthDate { get; set; }
        public string Cv { get; set; }
        [DefaultValue(false)]
        public bool IsAdmin { get; set; }
        public User User { get; set; }
        public ICollection<JobProfilePerson> JobProfilePerson { get; set; }

    }
}
