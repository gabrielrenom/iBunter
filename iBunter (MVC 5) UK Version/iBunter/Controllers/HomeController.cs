using iBunter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iBunter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

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

        public ActionResult Rating(int? id, int?  rate)
        {
            int? i = id;
            int? i2 = rate;

            var model = new List<Product>();
            model.Add(new Product() { Id = 122, Name = "Apple Juice", Description = "Best juice in the house" });
            model.Add(new Product() { Id = 132, Name = "Orange Juice", Description = "Made with only the best oranges" });
            model.Add(new Product() { Id = 142, Name = "Strawberry Juice", Description = "If only I could say something .... WOW!" });
            model.Add(new Product() { Id = 152, Name = "pineapple Juice", Description = "Only with Brazilian pineapples" });
            model.Add(new Product() { Id = 162, Name = "Coconut Juice", Description = "Directly from Dominican Republic" });

            return View(model);
        }        
    }
}