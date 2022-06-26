using eCommerce_project.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_project.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AppDbContext _context;

        public CinemaController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var All_Cinema = await _context.Cinemas.ToListAsync();
            return View(All_Cinema);
        }
    }
}
