using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Email requerido")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Contraseña requerida")]
        public string Password { get; set; }
        [DefaultValue(true)]
        public bool Status { get; set; }
        public DateTime SignupDate { get; set; }
        public ICollection<Person> Persons { get; set; }
        public ICollection<Company> Companies { get; set; }
    }
}
