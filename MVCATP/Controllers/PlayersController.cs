using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCATP.Models;
using System.Data.Entity;
using MVCATP.ViewModels;

namespace MVCATP.Controllers
{
    public class PlayersController : Controller
    {
        private ApplicationDbContext _context;

        public PlayersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Players
        public ActionResult Index()
        {
            var players = _context.Players.Include(m => m.Country);
            return View(players.ToList());
        }

        public ActionResult Details(int id)
        {
            var players = _context.Players.Include(m => m.Coach).Include(m => m.Surface).SingleOrDefault(m => m.PlayerID == id);

            if (players == null)
                return HttpNotFound();

            return View(players);


        }
        public ActionResult New()
        {
            var coaches = _context.Coaches.ToList();
            var countries = _context.Countries.ToList();
            var surfaces = _context.Surfaces.ToList();


            var viewModel = new PlayerFormViewModel
            {
                Coaches = coaches,
                Countries = countries,
                Surfaces = surfaces

            };

            return View("PlayerForm", viewModel);

            
        }

        public ActionResult Edit(int id)
        {
            var coaches = _context.Coaches.ToList();
            var countries = _context.Countries.ToList();
            var surfaces = _context.Surfaces.ToList();

            var player = _context.Players.SingleOrDefault(c => c.PlayerID == id);
            if (player == null)
                return HttpNotFound();

            var viewModel = new PlayerFormViewModel(player)
            {
                Coaches = coaches,
                Countries = countries,
                Surfaces = surfaces

            };

            return View("PlayerForm", viewModel);
        }
    }
}