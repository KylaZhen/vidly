using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();  
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();    
        }
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Hello World!!!" };
            var customers = new List<Customer>() {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers

            };
            return View(viewModel);
        }

        public ViewResult Index()
        {
            var movie = _context.Movies.Include(c => c.Genre).ToList();
            return View(movie);
        }

        public ActionResult Details(int id) { 
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);   
            return View(movie);
        }

        //private IEnumerable<Movie> GetMovies()
        //{
        //    return new List<Movie> {
        //        new Movie{Id = 1, Name = "Movie 1"},
        //        new Movie{Id = 2, Name = "Movie 2"}
        //    };
        //}
    }
}