﻿using System.Web.Mvc;

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
            ViewBag.Message = "Mi contacto c.hemkes1999@gmail.com.";
            return View();
        }

        public ActionResult Info()
        {
            ViewBag.Message = "Ing en Sistemas Computacionales.";
            return View();
        }
    }
}