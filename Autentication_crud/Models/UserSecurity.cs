using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Autentication_crud.Models
{
    [Table("UserSecurity")]
    public class UserSecurity
    {
        [Key]
        public int UserSecurityId { get; set; }        

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Usuario")]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Contraseña")]
        [MaxLength(100)]
        public string UserPassword { get; set; }

        [DataType(DataType.Date)]
        public DateTime UserRegisteredDate { get; set; }

        public int UserState { get; set; }

        //Relation with UserData Model 
        public int UserDataId { get; set; }
        public UserData UserData { get; set; }
    }
}
