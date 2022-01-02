using E_Trade.BLL.RepositoryImplementation;
using E_Trade.Model.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_TradeSite.Controllers
{
    public class ProductDetailController : Controller
    {
        public ProductRepository productRepository = new ProductRepository();
        // GET: ProductDetail
        public ActionResult Index(string name ,int? id)
        {
            //List<Product> vm = db.Products.Where(x => x.Id == id).ToList();
            if (id == null)
            {
                var productVm = productRepository.SelectAll();
                return View("~/Views/Home/Index.cshtml", productVm);
            }
            else
            {
                var productVM = productRepository.SearchList(x => x.Id == id);
                //Product productVM = productRepository.SelectById(id.Value);
                return View(productVM);
            }
        }
    }
}