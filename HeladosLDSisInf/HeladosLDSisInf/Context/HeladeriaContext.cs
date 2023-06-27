using HeladosLDSisInf.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HeladosLDSisInf.Context
{
    public partial class HeladeriaContext : DbContext
    {
        public HeladeriaContext()
            : base("name=HeladeriaContext")
        {
        }
        // la clave persistente usuario se va converitr en un tabla usuario en sql server
        virtual public DbSet<Usuario> Usuario { get; set; }
        virtual public DbSet<Cliente> Cliente { get; set; }
        virtual public DbSet<Pedido> Pedido { get; set; }
        virtual public DbSet<Producto> Producto { get; set; }
        virtual public DbSet<Helado> Helado { get; set; }
        virtual public DbSet<HistorialVenta> HistorialVenta { get; set; }

    }
}
