using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebCamp.Models;

namespace WebCamp.Web.Controllers
{
    public class CityController : Controller
    {
        // GET: City
        public ActionResult Index()
        {
            // TODO - get model
            var cities = new List<City>();
            return View(cities);
        }

        [ActionName("Index")]
        public ActionResult Index(int id)
        {
            // TODO - get model
            var city = new City();
            return View("CityDetails", city);
        }
    }
}