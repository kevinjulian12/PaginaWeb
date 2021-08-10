using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_web.Models
{
    public class Usuario
    {
    [Key]
    public int id { get; set; }

        [Required]
        [MaxLength (20)]
        [Display(Name ="usuario")]
        public string Usuario_ { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "contraseña")]
        public string Contraseña { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "nombre")]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "apellido")]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(40)]
        [Display(Name = "email")]
        public string Email { get; set; }

        [Required]
        [MaxLength(40)]
        [Display(Name = "genero")]
        public string Genero { get; set; }

        [Required]
        [Display(Name = "fecha_de_nacimiento")]
        public  DateTime Fecha_de_nacimiento { get; set; }

    }
}
