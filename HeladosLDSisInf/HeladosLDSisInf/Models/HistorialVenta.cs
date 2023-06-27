using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeladosLDSisInf.Models
{
    public class HistorialVenta
    {
        [Key]
        public int V_Id { get; set; }
        public Decimal Ganancia { get; set;}
        public string V_Desc { get; set;}
        //un historial de ventas tiene muchos pedidos 
        virtual public List<Pedido> Pedido { get; set; }   
    }
}
