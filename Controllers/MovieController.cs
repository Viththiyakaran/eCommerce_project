using eCommerce_project.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_project.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext _context;

        public MovieController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            //We can inculde Two modes using Incude
            var All_Movie = await _context.Movies.Include( c=>c.Cinema).OrderBy(n=>n.Name).ToListAsync();
            return View(All_Movie);
        }
    }
}
