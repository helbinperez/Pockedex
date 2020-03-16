using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PokemonTarea.Controllers
{
    public class PokemonDetallesController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult DetallesPokemon()
        {
            
            return ViewBag();
        }
    }
}