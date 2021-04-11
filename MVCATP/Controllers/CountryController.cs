using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCATP.Models;

namespace MVCATP.Controllers
{
    public class CountryController : Controller
    {
        private ApplicationDbContext _context;

        public CountryController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Country
        public ActionResult Index()
        {
            var countries = _context.Countries.ToList();
            return View(countries);
        }
    }
}