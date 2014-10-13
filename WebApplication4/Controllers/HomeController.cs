using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Data"] = "Hellow from controller";

            return View();
        }

        public ActionResult WithMenu()
        {
            return View();
        }

        public ActionResult Cars()
        {
            var list = new CarList()
            {
                new Car{ Name = "Logan" },
                new Car{ Name = "Note" },
            };

            return View(list);
        }
    }
}