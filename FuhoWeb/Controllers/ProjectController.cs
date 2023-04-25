using FuhoWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace FuhoWeb.Controllers
{
    public class ProjectController : Controller
    {
        private readonly FuhoWebContext _context;

        public ProjectController(FuhoWebContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Project> projects = _context.Projects.ToList();
            return View(projects);
        }
    }
}
