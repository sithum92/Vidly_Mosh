﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies


  


        public ActionResult Index()
        {
            var movies = GetMovies();

            if (movies == null)
                return HttpNotFound();

            return View(movies);
        }

        public ActionResult Details(int Id)
        {
            var movie = GetMovies().SingleOrDefault(c => c.Id == Id);
            return View(movie);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            { 
            new Movie{Id = 1, Name = "Shrek"},
            new Movie{ Id = 2, Name = "Wall-e"} 
            };
        }

        #region Old

        //public ActionResult Random()
        //{
        //    var movie = new Movie()
        //    {
        //        Name = "Shrek!"
        //    };
        //    //ViewData["Movie"] = movie;

        //    var customers = new List<Customer>
        //    {
        //    new Customer{ Name = "Customer 1"},
        //    new Customer{ Name = "Customer 2"}
        //    };

        //    var viewModel = new RandomMovieViewModel
        //    {
        //        Movie = movie,
        //        Customers = customers
        //    };

        //    return View(viewModel);

        //return View(movie);
        //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        //}
        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}

        //movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrEmpty(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));

        //}

        //[Route("movies/relesed/{year}/{month:regex(\\d{4}):range(1,12)}")]
        //public ActionResult ByReleseDate(int year, int month)
        //{
        //    return Content(year+"/"+month);
        //}
        #endregion
    }
}