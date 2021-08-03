using System.Collections.Generic;
using System.Web.Mvc;
using NewProj.Dao;
using NewProj.Models;

namespace NewProj.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<CarModel> prolist = ProductDetails.Callme();
            ViewData["pl"] = prolist;
            ViewBag.a = 1;
            return View();
        }
        public ActionResult Pro()
        {
            return View();
        }
    }
}