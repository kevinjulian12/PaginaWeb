using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_web.Models
{
    public class Users
    {
    [Key]
    public int UserID{ get; set; }

        [Required (ErrorMessage ="El nombre de usuario el obligatorio")]
        [MinLength(5,ErrorMessage ="El nombre de usuario debe tener un minimo de 5 caracter")]
        [MaxLength (20)]
        [Display(Name = "LoginName")]
        public string LoginName { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatorio")]
        [MinLength(8, ErrorMessage = "La contraseña debe tener un minimo de 8 caracter")]
        [MaxLength(20)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MinLength(3, ErrorMessage = "El nombre debe tener un minimo de 3 caracter")]
        [MaxLength(20)]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [MinLength(4, ErrorMessage = "El apellido debe tener un minimo de 4 caracter")]
        [MaxLength(20)]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        [MaxLength(40)]
        [EmailAddress(ErrorMessage ="debe ingresar un email valido")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Seleccione un genero")]
        [MaxLength(40)]
        [Display(Name = "GENDER")]
        public string GENDER { get; set; }

        [Required(ErrorMessage = "Seleccione la fecha de nacimiento")]
        [Display(Name = "DateoOfBirth")]
        public  DateTime DateoOfBirth { get; set; }

       

    }
}
