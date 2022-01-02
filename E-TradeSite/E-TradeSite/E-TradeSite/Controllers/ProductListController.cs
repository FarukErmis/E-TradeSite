using E_Trade.BLL.RepositoryImplementation;
using E_Trade.Model.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_TradeSite.Controllers
{
    public class ProductListController : Controller
    {
        public ProductRepository productRepository = new ProductRepository();
        public ProductPropertyRepository property = new ProductPropertyRepository();
        // GET: ProductList
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Index(string name)
         {
            var request = Request.QueryString["name"];
            if (name != null && Request.QueryString.Count > 0)
            {
                
                List<Product> productStorage = new List<Product>();
                List<ProductProperty> productPropertyStorage = new List<ProductProperty>();
                foreach (var item in  Request.QueryString.AllKeys)
                {
                    for (int i = 0; i < productStorage.Count(); i++)
                    {
                    }

                    productStorage.AddRange( property.SearchList(y => y.VarKey.Replace(" ", "") == item).Where(y => y.VarValue.Replace(" ", "") == Request.QueryString[$"{item}"]).Select(x => x.Product).Where(z=>z.Category.CategoryName.ToLower() == name.ToLower()).ToList());

                     productStorage.AddRange(property.SearchList(y => y.VarKey.Replace(" ", "") == item).Where(y => y.VarValue.Replace(" ", "") == Request.QueryString[$"{item}"]).Select(x => x.Product).Where(z => z.Brand.BrandName.ToLower() == name.ToLower()).ToList());
                    
                    productPropertyStorage.AddRange(property.SearchList(y => y.VarKey.Replace(" ", "") == item).Where(y => y.VarValue.Replace(" ", "") == Request.QueryString[$"{item}"]).Where(z=>z.Product.Category.CategoryName.ToLower() == name.ToLower()).ToList());

                    productPropertyStorage.AddRange(property.SearchList(y => y.VarKey.Replace(" ", "") == item).Where(y => y.VarValue.Replace(" ", "") == Request.QueryString[$"{item}"]).Where(z => z.Product.Brand.BrandName.ToLower() == name.ToLower()).ToList());
                }
                var filtreSayisi = productStorage.Select(x => x.Id).ToList();
                List<Product> product = new List<Product>();
                for (int i = 0; i < filtreSayisi.Count(); i++)
                {
                    if (productStorage.Where(x=>x.Id == filtreSayisi[i]).Count() == Request.QueryString.AllKeys.Count())
                    {
                        if (!product.Contains(productStorage[i]))
                        {
                            product.Add(productStorage[i]);
                        }

                    }
                }
                return View(product);
            }
            var products = productRepository.SearchList(x => x.Category.CategoryName.ToLower() == name.ToLower());
            products.AddRange(productRepository.SearchList(x => x.Brand.BrandName.ToLower() == name.ToLower()));
            return View(products);
        }


        [HttpGet]
        public ActionResult SortPrice(string name,string toLowPrice)
        {
            var productVM = productRepository.SearchList(x => x.Category.CategoryName.ToLower() == name.ToLower());
            productVM.AddRange(productRepository.SearchList(x => x.Brand.BrandName.ToLower() == name.ToLower()));
            if (toLowPrice == "true")
            {
                productVM = productVM.OrderByDescending(x => x.TrullyPrice).ToList();
            }
            else
            {
                productVM = productVM.OrderBy(x => x.TrullyPrice).ToList();
            }
            return View("~/Views/ProductList/Index.cshtml", productVM);
        }

        public ActionResult SortRate(string name, string toLowRate)
        {
            var productVM = productRepository.SearchList(x => x.Category.CategoryName.ToLower() == name.ToLower());
            productVM.AddRange(productRepository.SearchList(x => x.Brand.BrandName.ToLower() == name.ToLower()));
            if (toLowRate == "true")
            {
                productVM = productVM.OrderByDescending(x => x.Rates).ToList();
            }
            else
            {
                productVM = productVM.OrderBy(x => x.Rates).ToList();
            }
            return View("~/Views/ProductList/Index.cshtml", productVM);
        }
    }
}