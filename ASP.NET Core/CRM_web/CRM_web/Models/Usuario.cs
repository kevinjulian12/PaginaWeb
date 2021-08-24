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

        [Required (ErrorMessage ="El nombre de usuario el obligatorio")]
        [MinLength(5,ErrorMessage ="El nombre de usuario debe tener un minimo de 5 caracter")]
        [MaxLength (20)]
        [Display(Name ="usuario")]
        public string Usuario_ { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatorio")]
        [MinLength(8, ErrorMessage = "La contraseña debe tener un minimo de 8 caracter")]
        [MaxLength(20)]
        [Display(Name = "contraseña")]
        public string Contraseña { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MinLength(3, ErrorMessage = "El nombre debe tener un minimo de 3 caracter")]
        [MaxLength(20)]
        [Display(Name = "nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [MinLength(4, ErrorMessage = "El apellido debe tener un minimo de 4 caracter")]
        [MaxLength(20)]
        [Display(Name = "apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        [MaxLength(40)]
        [EmailAddress(ErrorMessage ="debe ingresar un email valido")]
        [Display(Name = "email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Seleccione un genero")]
        [MaxLength(40)]
        [Display(Name = "genero")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Seleccione la fecha de nacimiento")]
        [Display(Name = "fecha_de_nacimiento")]
        public  DateTime Fecha_de_nacimiento { get; set; }

       

    }
}
