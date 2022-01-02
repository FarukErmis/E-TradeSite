using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace E_TradeSite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "CategoryList",
                url: "search={name}",
                defaults: new { controller = "ProductList", action = "Index", name = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ProductDetail",
                url: "detail/{id}",
                defaults: new { controller = "ProductDetail", action = "Index" , id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "CategoryListPriceSort",
                url: "search={name}/sortPrice={toLowPrice}",
                defaults: new { controller = "ProductList", action = "SortPrice", name = "name", toLowPrice = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "CategoryListRateSort",
                url: "search={name}/sortRate={toLowRate}",
                defaults: new { controller = "ProductList", action = "SortRate", name = "name", toLowRate = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
