using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using atssistem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Protocol;
using Microsoft.Extensions.Logging;


namespace atssistem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index(string arama)
        {
            
            using(var db=new atsDbContext())
            {
                var ilan = db.ilanlar.ToList();

                if (!string.IsNullOrEmpty(arama))
                {
                    ilan = ilan
                        .Where(x => x.isbaslik.Contains(arama))
                        .ToList();
                }

                return View(ilan);

            }
        }
        public IActionResult Detay(int id)
        {
            using(var db=new atsDbContext())
            {
                var ilan = db.ilanlar.FirstOrDefault(x => x.Id == id);
                return View(ilan);
            }
            
        }

        public IActionResult Index()
        {
         return View();
        }
        public IActionResult sirket()
        {
            return View();
        }
        public IActionResult kariyer()
        {
            return View();
        }
        public IActionResult iletisim()
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
