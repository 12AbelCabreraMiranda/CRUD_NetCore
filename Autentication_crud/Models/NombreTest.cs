using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Autentication_crud.Models
{
    [Table("NombreTest")]
    public class NombreTest
    {
        [Key]
        public int NombreTestId { get; set; }
        public int NombreUserDataId { get; set; }
    }
}
