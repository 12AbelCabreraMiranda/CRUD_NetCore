using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Autentication_crud.ViewModels
{
    public class LoginViewModels
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Usuario")]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Contraseña")]
        [MaxLength(100)]
        public string UserPassword { get; set; }
    }
}
