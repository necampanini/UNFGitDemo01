using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UNFGitDemo01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var rangeOfNumbers = Enumerable.Range(1, 15);
            var evenNumbers = rangeOfNumbers.Where(x => x % 2 == 0);

            var x = 100;
            var y = 200;

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
    }
}