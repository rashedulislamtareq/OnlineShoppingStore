using OnlineShoppingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public EFDbContext():base("DefaultConnection")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
