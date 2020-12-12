using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Autentication_crud.Models
{
    [Table("UserData")]
    public class UserData
    {
        [Key]
        public int UserDataId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Apellido")]
        [MaxLength(50)]
        public string LastName { get; set; }

        //Relation with UserSecurity Model 
        public List<UserSecurity> UserSecurity { get; set; }
    }
}
