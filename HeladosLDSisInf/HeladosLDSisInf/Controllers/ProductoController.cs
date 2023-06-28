using HeladosLDSisInf.Context;
using HeladosLDSisInf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeladosLDSisInf.Controllers
{
    public class ProductoController
    {
        HeladeriaContext _context = new HeladeriaContext();

        //Devuelva Todos los usuarios
        public List<Producto> GetAll()
        {
            return _context.Producto.ToList();
        }
        public bool Update(Producto producto,int Cant)
        {
            _context.Producto.Attach(producto); //Buscar en la tabla producto
            producto.Cantidad = Cant+producto.Cantidad;
            _context.Entry(producto).State = System.Data.Entity.EntityState.Modified; //Modifique al Producto En la BBDD
            return _context.SaveChanges() > 0; //Guardando cambios en la base de datos
        }
    }
}
