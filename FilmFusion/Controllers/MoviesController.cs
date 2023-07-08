using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmFusion.Models;
using FilmFusion.ViewModels;

namespace FilmFusion.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random(int? page)
        {
            string id = Request.QueryString["id"];
            var movie = new Movie();
            var movie2 = new Movie();

            movie = new Movie() { Name = "Shrek!" };




            //ViewData["Movie"] = movie;
            var movies = new List<Movie>
            {
                new Movie{Name ="Departed "},
                new Movie{Name ="Lost"}

            };
            var vieModels = new RandomMovieViewModel
            {
                Movies = movies

            };

            return View(vieModels);
        }

        public ActionResult Customer(int page)
        {


            //ViewData["Movie"] = movie;
            var customers = new List<Customer>
            {
                new Customer{Name ="Customer 1"},
                new Customer{Name ="Customer 2"}

            };
            var vieModels = new RandomMovieViewModel
            {
                Customers = customers

            };
            return View(vieModels);
        }
        //mvc attribute route constraints
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int? year, int? month)
        {

            return Content(String.Format(year + "/" + month));
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}