using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;

namespace vidly.Controllers
{
    public class VideosController : Controller
    {
        private ApplicationDbContext _context;
        public VideosController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult ReadOnlyList()
        {
            var video = _context.Videos.Include(c => c.Category).ToList();
            return View(video);
        }

        public ActionResult Details(int id)
        {
            var video = _context.Videos.Include(c => c.Category).SingleOrDefault(c => c.Id == id);
            return View(video);
        }
    }
}