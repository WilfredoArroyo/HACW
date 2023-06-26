using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Prueba.Context
{
    public partial class pruebaContext : DbContext
    {
        public pruebaContext()
            : base("name=pruebaContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
