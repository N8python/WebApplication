using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()

        {
            var movie = new Movies() {Name = "Shrek"};
            return View(movie);
        }
        public ActionResult Edit(int id) 
        {
            return Content("id=" + id);
        }
        public ActionResult Index(int? pageIndex, string SortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(SortBy));
            SortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy{1}", pageIndex, SortBy));
        }
    }
}