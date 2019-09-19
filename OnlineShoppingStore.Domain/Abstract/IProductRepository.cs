using OnlineShoppingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingStore.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
