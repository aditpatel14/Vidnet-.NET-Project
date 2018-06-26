﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidnet.Controllers
{
    public class MoviesController : Controller
    {
        // GET: movies/random
        public ActionResult Random()
        {
            var movie = new Models.Movie(){ Name = "Shrek!" };
            return View(movie);
        }

        //movies/edit
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("PageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }


        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        

    }
}