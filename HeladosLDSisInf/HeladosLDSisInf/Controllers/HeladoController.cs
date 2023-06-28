using HeladosLDSisInf.Context;
using HeladosLDSisInf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeladosLDSisInf.Controllers
{
    public class HeladoController
    {
        HeladeriaContext _context= new HeladeriaContext();
        // mostrar todos los datos de la lista
        public List<Helado> GetAll()
        {
            return _context.Helado.ToList();
        }
        public bool Update(Helado helado, int Cant)
        {
            _context.Helado.Attach(helado); //Buscar en la tabla producto
            helado.Cantidad_P = Cant + helado.Cantidad_P;
            _context.Entry(helado).State = System.Data.Entity.EntityState.Modified; //Modifique al Producto En la BBDD
            return _context.SaveChanges() > 0; //Guardando cambios en la base de datos
        }
    }
}
