using Demo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models;

namespace UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public int PageSize = 4;

        //public ActionResult List(int page = 1)
        //{
        //    return View(repository.Products
        //        .OrderBy(p => p.Id)
        //        .Skip((page - 1) * PageSize)
        //        .Take(PageSize)
        //        );
        //}

        public ActionResult List(int page = 1)
        {
            var model = new ProductListViewModel
            {
                Products = repository.Products
                .OrderBy(p => p.Id)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemPerPage = PageSize,
                    TotalItem = repository.Products.Count(),
                }
            };

            return View(model);
        }

    }
}