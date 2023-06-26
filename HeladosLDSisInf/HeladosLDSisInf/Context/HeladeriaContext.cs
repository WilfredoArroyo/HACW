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
    }
}
