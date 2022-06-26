using eCommerce_project.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_project.Controllers
{
    public class ProducerController : Controller
    {
        private readonly AppDbContext _context;

        public ProducerController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Producers.ToListAsync();
            return View(data);
        }
    }
}
