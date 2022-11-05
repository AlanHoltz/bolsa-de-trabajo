using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bolsa.Entities
{
    public class JobProfile
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Email requerido")]
        [EmailAddress(ErrorMessage = "Ingrese un email válido")]
        [Display(Name = "Email de recepción")]
        public string EmailReceptor { get; set; }
        [Required(ErrorMessage = "Fecha de inicio requerida")]
        [Display(Name = "Fecha de inicio")]
        public DateTime StartingDate { get; set; }
        [Required(ErrorMessage = "Fecha de fin requerida")]
        [Display(Name = "Fecha de finalización")]
        public DateTime EndingDate { get; set; }
        [Required(ErrorMessage = "Dirección requerida")]
        [Display(Name = "Dirección")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Capacidad requerida")]
        [Display(Name = "Capacidad")]
        public int Capacity { get; set; }
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Posición requerida")]
        [Display(Name = "Puesto de trabajo")]
        public string Position { get; set; }
        [Display(Name = "Tipo")]
        public string Type { get; set; }
        public bool Status { get; set; }
        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<JobProfilePerson> JobProfilePerson { get; set; }
        public ICollection<Career> Careers { get; set; }
        public Internship Internship { get; set; }
        public Relationship Relationship { get; set; }

    }
}
