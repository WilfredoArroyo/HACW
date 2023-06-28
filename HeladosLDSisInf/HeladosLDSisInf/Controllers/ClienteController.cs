using HeladosLDSisInf.Context;
using HeladosLDSisInf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeladosLDSisInf.Controllers
{
    public class ClienteController
    {
        HeladeriaContext _context = new HeladeriaContext();

        public List<Cliente> GetAll()
        {
            return _context.Cliente.ToList();
        }
    }
}
