using HeladosLDSisInf.Context;
using HeladosLDSisInf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeladosLDSisInf.Controllers
{
    public class PedidoController
    {
        HeladeriaContext _context= new HeladeriaContext();
        //RETORNA TODOS LOS PEDIDOS
        public List<Pedido> GetAll()
        {
            return _context.Pedido.ToList();
        }
    }
}
