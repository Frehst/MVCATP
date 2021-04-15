using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCATP.Models;

namespace MVCATP.Controllers
{
    public class CoachesController : Controller
    {
        private ApplicationDbContext _context;

        public CoachesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Coaches
        public ActionResult Index()
        {
            var coaches = _context.Coaches.ToList();
            return View(coaches);
        }
        public ActionResult Add()
        {
            var viewModel = new Coach();

            return View("Add", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Coach coach)
        {
            if (coach.CoachID == 0)
            {
                _context.Coaches.Add(coach);
            }
            else
            {
                var coachInDb = _context.Coaches.Single(m => m.CoachID == coach.CoachID);
                coachInDb.CoachName = coach.CoachName;
                coachInDb.CoachSurname = coach.CoachSurname;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Coaches");
        }
    }
}