using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCATP.Models;
using System.Data.Entity;

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
            return View();
        }

    
    }
}