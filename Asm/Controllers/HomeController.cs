using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asm.Models;

namespace Asm.Controllers
{
    public class HomeController : Controller
    {
        MultiShopDbContext db = new MultiShopDbContext();
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
        public ActionResult Category()
        {
            var model = db.Categories;
            return PartialView("Category", model);
        }
    }
}