using OnlineShoppingStore.Domain.Abstract;
using OnlineShoppingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private readonly EFDbContext _context = new EFDbContext();


        public IEnumerable<Product> Products
        {
            get { return _context.Products; }
        }
    }
}
