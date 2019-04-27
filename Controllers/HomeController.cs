using ispsession.io.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var ctr = (int)(Session["counter"] ?? 0);
            ctr++;
            Session["counter"] = ctr;
            var application = (IApplicationCache)this.HttpContext.Items["_ISPApplicationCache"];


            var someViewClass = new SomeViewClass
            {
                SomeString = (string)((object[])application["cachethis"])[0],
                someDate = (DateTime)((object[])application["cachethis"])[1]
            };
            return View(someViewClass);
            
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
    }
}