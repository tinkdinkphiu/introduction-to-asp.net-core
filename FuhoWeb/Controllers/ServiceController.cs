using FuhoWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace FuhoWeb.Controllers
{
    public class ServiceController : Controller
    {
        private readonly FuhoWebContext _context;

        public ServiceController(FuhoWebContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Service> services = _context.Services.ToList();
            return View(services);
        }
    }
}
