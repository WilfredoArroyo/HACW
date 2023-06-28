using HeladosLDSisInf.Context;
using HeladosLDSisInf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeladosLDSisInf.Controllers
{
    public class UsuarioController
    {
         HeladeriaContext _context = new HeladeriaContext();
        public int Login(string cuenta, string password) 
        {
            //List<Usuario> usuarios = _context.Usuario.Where(x => x.Cuenta == cuenta && x.Password == password).ToList();
            int Contador = 0;
            var usuarios = _context.Usuario.ToList();   
            foreach (var usuario in usuarios)
            {
                if (usuario.Cuenta == cuenta && usuario.Password == password && usuario.TipoUsuario == "Admin")
                {
                    Contador = 1;
                    return Contador;
                }
                else if (usuario.Cuenta == cuenta && usuario.Password == password && usuario.TipoUsuario == "Empleado")
                {
                    Contador=2;
                    return Contador;
                }
                    
            }
            
            return Contador;
        }
        //CRUD
        //Devuelva Todos los usuarios
        public List<Usuario> GetAll()
        {
            return _context.Usuario.ToList();
        }
        //Para que devuelva solo un Usuario a traves del Primary Key
        public Usuario Get(String Cuenta)
        {
            return _context.Usuario.Find(Cuenta);
        }
        //Buscar
        public List<Usuario> Search(String par)
        {
            if (String.IsNullOrEmpty(par))
            {
                return GetAll();
            }
            else
            {
                //Pe Devolver Perez 
                //Da Devolver Daniel,David,Danilo
                return _context.Usuario.Where(x => x.Cuenta.Contains(par) ||
                        x.NombreCompleto.Contains(par)).ToList();
            }
        }


        //Crear, Actualizar y Eliminar

        public bool Create(Usuario usuario)
        {
            _context.Usuario.Add(usuario); //Agregando a la tabla Usuario
            return _context.SaveChanges() > 0; //Guardando cambios en la base de datos
        }

        public bool Update(Usuario usuario)
        {
            _context.Usuario.Attach(usuario); //Buscar en la tabla Usuario
            _context.Entry(usuario).State = System.Data.Entity.EntityState.Modified; //Modifique al Usuario En la BBDD
            return _context.SaveChanges() > 0; //Guardando cambios en la base de datos
        }

        public bool Delete(Usuario usuario)
        {
            _context.Usuario.Remove(usuario); //Buscar y lo va eliminar en la BBDD
            return _context.SaveChanges() > 0; //Guardando cambios en la base de datos
        }
    }
}
