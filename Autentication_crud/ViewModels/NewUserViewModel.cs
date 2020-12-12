using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Autentication_crud.ViewModels
{
    public class NewUserViewModel
    {                
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        
        [Display(Name = "Apellido")]
        public string LastName { get; set; }                
        
        [Display(Name = "Nombre de Usuario")]
        public string UserName { get; set; }
        
        [Display(Name = "Contraseña")]
        public string UserPassword { get; set; }

        public string ErrorMessage { get; set; }

        public int UserSecurityId { get; set; }
        public int UserDataId { get; set; }

    }
}
