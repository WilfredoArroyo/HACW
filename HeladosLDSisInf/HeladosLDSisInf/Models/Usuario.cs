using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeladosLDSisInf.Models
{
    public class Usuario
    {
        [Key]
        public string Cuenta { get; set; }
        [Required]
        public string Password { get; set; }
        public string NombreCompleto { get; set; }
        [Required]
        public string TipoUsuario { get; set; }
    }
}
