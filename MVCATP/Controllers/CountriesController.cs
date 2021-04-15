using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCATP.Models;
using MVCATP.ViewModels;

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

        public ActionResult Add()
        {
            var viewModel = new Country();

            return View("Add", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Country country)
        {
            if (country.CountryID == 0)
            {
                _context.Countries.Add(country);
            }
            else
            {
                var countryInDb = _context.Countries.Single(m => m.CountryID == country.CountryID);
                countryInDb.CountryName = country.CountryName;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Countries");
        }
    }
}