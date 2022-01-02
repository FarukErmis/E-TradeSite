using E_Trade.BLL.RepositoryImplementation;
using E_Trade.Model.Entity;
using E_Trade.Model.Entity.VM;
using E_Trade.Model.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_TradeSite.Controllers
{
    public class ShoppingCartController : Controller
    {
        private ProductRepository productRepository;

        public ShoppingCartController()
        {
            productRepository = new ProductRepository();
        }
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult List()
        {
            if (Session["sepet"] != null)
            {
                CartHelper cart = Session["sepet"] as CartHelper;
                List<ProductVM> proList = cart.CartList
                    .Select(x => new ProductVM
                    {
                        Id = x.Id,
                        ProductName = x.ProductName,
                        TrullyPrice = x.TrullyPrice,
                        TotalPrice = x.TotalPrice,
                        Image = x.Image,
                        Discount = x.Discount,
                        Quantity = x.Quantity,
                        CategoryName = x.CategoryName,
                        IsShippingFree = x.IsShippingFree,
                        BrandName = x.BrandName
                    }).ToList();
                return Json(proList, JsonRequestBehavior.AllowGet);
            }
            return Json(new List<ProductVM>(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Add(int id)
        {
            Product x = productRepository.SelectById(id);
            var a = x.ProductImages.Where(y => y.ProductId == id).Select(y => y.Image).ToList()[0];
            ProductVM vm = new ProductVM
            {
                Id = x.Id,
                ProductName = x.ProuductName,
                Image = x.ProductImages.Where(y => y.ProductId == id).Select(y => y.Image).ToList()[0],
                TotalPrice = x.TotalPrice,
                TrullyPrice = x.TrullyPrice,
                Discount = x.Discount,
                CategoryName = x.Category.CategoryName,
                Quantity = 1,
                IsShippingFree = x.IsShippingFree,
                BrandName = x.Brand.BrandName
            };
            var b = vm;

            if (Session["sepet"] != null)
            {
                CartHelper cart = Session["sepet"] as CartHelper;
                cart.AddCart(vm);
                Session["sepet"] = cart;
            }
            else
            {
                CartHelper cart = new CartHelper();
                cart.AddCart(vm);
                Session.Add("sepet", cart);
            }
            return Json("Emppty", JsonRequestBehavior.AllowGet);
        }


        public JsonResult DecreaseCart(int id)
        {
            if (Session["sepet"] != null)
            {
                CartHelper cart = Session["sepet"] as CartHelper;
                cart.DecreaseCart(id);
                Session["sepet"] = cart;
            }
            return Json("Emppty", JsonRequestBehavior.AllowGet);
        }

        public JsonResult RemoveCart(int id)
        {
            if (Session["sepet"] != null)
            {
                CartHelper cart = Session["sepet"] as CartHelper;
                cart.RemoveCart(id);
                Session["sepet"] = cart;
            }
            return Json("Empty", JsonRequestBehavior.AllowGet);
        }
    }
}