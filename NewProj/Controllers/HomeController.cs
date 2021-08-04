using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using NewProj.Dao;
using NewProj.Models;
using PagedList;

namespace NewProj.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    List<CarModel> prolist = ProductDetails.Callme();
        //    ViewData["pl"] = prolist;
        //    ViewBag.a = 1;
        //    return View();
        //}
        SashaEntities alo = new SashaEntities();
        public ActionResult Index() { return View(); }
        public ActionResult Index(int? page)
        {
            
            int pagesize = 20, pageindex = 1;
            pageindex = page.HasValue ? Convert.ToInt32(page) : 1;
            //List<CarModel> list = ProductDetails.Callme();
            var list = alo.Cars.OrderByDescending(x => x.Model).ToList();
            IPagedList<Car> cars = list.ToPagedList(pageindex, pagesize);
            ViewData["pl"] = list;
            ViewBag.a = 1;
            return View(list.ToPagedList(pageindex, pagesize));
        }
        public ActionResult Pro()
        {
            return View();
        }
    }
}