using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Spesa.Models;
    
namespace Spesa.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ListaSpesa _ls;

        public HomeController(ILogger<HomeController> logger, ListaSpesa ls)
        {
            _logger = logger;
            _ls = ls;
        }

        public IActionResult Index()
        {
            _ls.Aggiungi("Pane");
            _ls.Aggiungi("Bibita");
            _ls.Aggiungi("Cane");

            _ls.Rimuovi("Pane");


            var lat = new Ingrediente("latte pastorizzato");
            lat.colore = "bianco";
            lat.conservazione = "frigorifero";
            lat.consistenza = "liquido";
            lat.orgine = "animale";

            var uov = new Ingrediente("uova fresche");
            uov.colore = "giallo";
            uov.conservazione = "frigorifero";
            uov.orgine = "animale";
            uov.consistenza = "viscoso";

            List<Ingrediente> ingredienti = new List<Ingrediente>();
            ingredienti.Add(lat);
            ingredienti.Add(uov);

            var canno = new Dolce();
            canno.name = "cannolo";
            canno.ingredienti = ingredienti;
            


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
