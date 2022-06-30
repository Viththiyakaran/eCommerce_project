using eCommerce_project.Data;
using eCommerce_project.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_project.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorService _service;

        public ActorController(IActorService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }
    }
}
