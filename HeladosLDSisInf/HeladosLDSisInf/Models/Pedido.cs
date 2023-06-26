using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeladosLDSisInf.Models
{
    public class Pedido
    {
        [Key]
        public int P_Id { get; set; }
        [Required]
        public DateTime Fecha_Hora { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public Decimal Precio_H { get; set;}
    }
}
