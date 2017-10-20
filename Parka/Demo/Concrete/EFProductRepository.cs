using Demo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Entities;

namespace Demo.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private readonly EFDbContext context;

        public EFProductRepository(EFDbContext _context)
        {
            context = _context;
        }
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
            
        }
    }
}
