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
        public string NombreCliente { get; set; }
        [Required]
        public DateTime Fecha_Hora { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public Decimal Precio_H { get; set;}

        //un pedido tiene un Cliente
        virtual public Cliente Cliente { get; set; }
        //un pedido viene de un usuario
        virtual public Usuario Usuario { get; set; }    
        //un pedido tiene solo un historial de ventas
        virtual public HistorialVenta HistorialVenta { get; set; } 
        // un pedido puede tener muchos helados 
        virtual public List<Helado> Helado { get; set; }
    }
}
