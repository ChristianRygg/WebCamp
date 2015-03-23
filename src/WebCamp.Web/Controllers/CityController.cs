using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebCamp.Models;

namespace WebCamp.Web.Controllers
{
    public class CityController : Controller
    {
        public ActionResult Index()
        {
            // TODO - get model
            var cities = new List<City>();
            return View(cities);
        }

        [ActionName("Details")]
        public ActionResult Details(int id)
        {
            // TODO - get model
            var city = new City();
            return View("Details", city);
        }
    }
}