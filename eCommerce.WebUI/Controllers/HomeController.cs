using eCommerce.Contracts.Repositories;
using eCommerce.DAL.Data;
using eCommerce.DAL.Repositories;
using eCommerce.Model;
using eCommerce.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace eCommerce.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IRepositoryBase<Customer> customers;
        IRepositoryBase<Product> products;
        public HomeController(IRepositoryBase<Customer> customers, IRepositoryBase<Product> products)
        {
            this.customers = customers;
            this.products = products;
        }
        public ActionResult Index()
        {
            var productList = products.GetAll();
             
            return View(productList);
        }

        public ActionResult Details(int id)
        {
            var product = products.GetById(id);

            return View(product);
        }

        //public ActionResult AddToBasket(int id)
        //{
        //    BasketService.AddToBasket(this.HttpContext, id, 1); //Always add one to the basket
        //    var product = products.GetById(id);

        //    return View(product);
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}