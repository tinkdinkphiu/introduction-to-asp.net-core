using FuhoWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FuhoWeb.Controllers
{
    public class HomeController : Controller
    {
        /*private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/
        private readonly FuhoWebContext _context;
        public HomeController(FuhoWebContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {   
            List<Client> client = _context.Clients.ToList();
            return View(client);
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