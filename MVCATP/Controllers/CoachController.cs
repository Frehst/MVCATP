using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCATP.Models;

namespace MVCATP.Controllers
{
    public class CoachController : Controller
    {
        private ApplicationDbContext _context;

        public CoachController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Coach
        public ActionResult Index()
        {
            var coaches = _context.Coaches.ToList();

            return View(coaches);
        }
    }
}