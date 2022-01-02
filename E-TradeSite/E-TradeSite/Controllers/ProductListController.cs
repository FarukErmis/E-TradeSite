using E_Trade.BLL.RepositoryImplementation;
using E_Trade.Model.Entity;
using System.Collections.Generic;
using System.Linq;
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
            if (name != null && Request.QueryString.Count > 0)
            {
                List<Product> productStorage = new List<Product>();
                List<Product> product = new List<Product>();


                foreach (var item in  Request.QueryString.AllKeys)
                {

                    var a = Request.QueryString[$"{item}"];

                    productStorage.AddRange( property.SearchList(y => y.VarKey.Replace(" ", "") == item).Where(y => y.VarValue.Replace(" ", "").Replace("+","") == Request.QueryString[$"{item}"].Replace(" ", "")).Select(x => x.Product).Where(z=>z.Category.CategoryName.ToLower() == name.ToLower()).ToList());

                     productStorage.AddRange(property.SearchList(y => y.VarKey.Replace(" ", "") == item).Where(y => y.VarValue.Replace(" ", "").Replace("+", "") == Request.QueryString[$"{item}"].Replace(" ", "")).Select(x => x.Product).Where(z => z.Brand.BrandName.ToLower() == name.ToLower()).ToList());
                }

                var filtreSayisi = productStorage.Select(x => x.Id).ToList();

                for (int i = 0; i < filtreSayisi.Count(); i++)
                {
                    if (productStorage.Where(x=>x.Id == filtreSayisi[i]).Count() == Request.QueryString.AllKeys.Count())
                        if (!product.Contains(productStorage[i]))
                            product.Add(productStorage[i]);
                }
                return View(product);
            }

            var products = productRepository.SearchList(x => x.Category.CategoryName.ToLower() == name.ToLower());
            products.AddRange(productRepository.SearchList(x => x.Brand.BrandName.ToLower() == name.ToLower()));

            return View(products);
        }
    }
}