using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Esta es una prueba de mi primera apicacion con ASP.NET.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Mi contacto.";
            return View();
        }
    }
    
}