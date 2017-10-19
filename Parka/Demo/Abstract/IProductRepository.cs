using Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product>Products { get; }
    }
}
