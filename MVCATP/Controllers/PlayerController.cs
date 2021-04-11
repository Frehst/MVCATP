using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCATP.Models;

namespace MVCATP.Controllers
{
    public class PlayerController : Controller
    {
        private ApplicationDbContext _context;

        public PlayerController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Player
        public ActionResult Index()
        {
            var players = _context.Players.Include(m => m.Country);
            return View(players.ToList());
        }
    }
}