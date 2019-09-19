using OnlineShoppingStore.Domain.Abstract;
using OnlineShoppingStore.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;
        private int pageSize = 4;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;

        }

        // GET: Product
        public ViewResult List(int page = 1)
        {
            var products = productRepository.Products
                .OrderBy(x => x.ProductId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var pagingInfo = new PagingInfo() { CurrentPage = page, ItemPerPage = pageSize, TotalItems = productRepository.Products.Count()};

            var productsListViewModel = new ProductsListViewModel() { Products = products, PagingInfo = pagingInfo };

            return View(productsListViewModel);
        }
    }
}