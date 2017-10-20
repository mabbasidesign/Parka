using Demo.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Concrete
{
    public class EFDbContext : DbContext
    {
        //public EFDbContext() : base("EFDbContext") { }

        public DbSet<Product> Products { get; set; }
    }
}
