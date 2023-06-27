using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeladosLDSisInf.Models
{
    public class Cliente
    {
        [Key]
        public int C_Id { get; set; }
        [Required]
        public string NombreCompleto { get; set; }
        public int Ci { get; set; }
        //un Cliente tiene muchos pedidos
        virtual public List<Pedido> Pedidos { get; set; }
    }
}
