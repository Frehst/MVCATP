using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCATP.Models;

namespace MVCATP.Controllers
{
    public class CountriesController : Controller
    {

        private ApplicationDbContext _context;

        public CountriesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Countries
        public ActionResult Index()
        {
            var countries = _context.Countries.ToList();
            return View(countries);
        }
    }
}