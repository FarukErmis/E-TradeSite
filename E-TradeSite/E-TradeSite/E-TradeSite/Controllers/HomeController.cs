using E_Trade.BLL.RepositoryImplementation;
using E_Trade.Model.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_TradeSite.Controllers
{
    public class HomeController : Controller
    {
        public ProductRepository productRepository = new ProductRepository();
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            //List<Product> vm = db.Products.Where(x => x.CategoryId == x.CategoryId).ToList();

            var  productVm = productRepository.SelectAll();
            return View(productVm);
        }
    }
}