using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeladosLDSisInf.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom_Producto { get; set; }
        [Required]
        public string Tipo_Envase { get; set; }
        [Required]
        public string Tipo_Unidad { get; set; }
        [Required]
        public Decimal PrecioU { get; set; }
        [Required]
        public int Cantidad { get; set; }
        public Decimal PrecioT { get; set; }
    }
}
