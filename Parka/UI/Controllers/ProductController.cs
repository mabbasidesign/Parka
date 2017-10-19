using Demo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ActionResult List()
        {
            return View(repository.Products);
        }
    }
}