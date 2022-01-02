using E_Trade.BLL.RepositoryImplementation;
using E_Trade.Model.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_TradeSite.Controllers
{
    public class SearchController : Controller
    {
        public ProductRepository productRepository = new ProductRepository();
        public ProductPropertyRepository property = new ProductPropertyRepository();
        // GET: Search
        public ActionResult Index(string property)
        {

            var productStorage = productRepository.SearchList(x => x.Category.CategoryName.ToLower() == property.ToLower());
            productStorage.AddRange(productRepository.SearchList(x => x.Brand.BrandName.ToLower() == property.ToLower()));

            var result = from a in productStorage
                         group a by a.ProductProperties.Select(y => y.VarKey).ToList() into x
                         select new
                         {
                             x.Key
                         };
            result = result.ToList();


            List<string> allProperties = new List<string>();
            foreach (var item in result)
                allProperties.AddRange(item.Key);

            List<string> allKeys = new List<string>();
            for (int i = 0; i < allProperties.Count(); i++)
            {
                if (allKeys.Contains($"{allProperties[i]}"))
                {

                }
                else
                    allKeys.Add(allProperties[i]);
            }
            List<Product> productVM = new List<Product>();

            for (int i = 0; i < productStorage.Count(); i++)
            {
                var allValues = productStorage.Select(x => x.ProductProperties.Select(y => y.VarValue).ToList()).ToList()[i];
                for (int z = 0; z < allValues.Count(); z++)
                    for (int x = 0; x < allKeys.Count(); x++)
                        if (allValues[z].Replace(" ", "") == Request.QueryString[$"{allKeys[x].Replace(" ", "")}"])
                            productVM.Add(productStorage[i]);
                productVM.AddRange(productStorage.Where(x => x.ProductProperties.Select(y => y.VarValue).ToList()[i] == Request.QueryString[$"{allKeys[i]}"]));
            }
            if (productVM.Count() > 0)
                return View(productVM);
            else
                return View(productStorage);
        }
    }
}