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
        /*Crema de leche | 1bolsa  | 1000ml|25bs|
          Saborizante H_f| 1botella| 1000ml|20bs|
          Azucar         | 1bolsa  | 1000kg|10bs|
          Leche normal   | 1bolsa  | 1000ml|6bs |
          PARA 30 PORCIONES DE HELADO DE CUALQUIER SABOR
          SE NECESITA:
          Crema de leche | 1/2bolsa  | 500ml  |12.5bs
          Saborizante H_f| 1/4botella| 250ml|5bs
          Azucar         | 1/4bolsa  | 250kg|2.5bs|
          Leche normal   | 1/2bolsa  | 500ml|3bs |
        */
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
        public Double Cantidad { get; set; }
        public Decimal PrecioT { get; set; }
        //un Porducto tiene muchos Helados
        virtual public List<Helado> Helado { get; set; }
    }
}
