using FuhoWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace FuhoWeb.Controllers
{
    public class EmployeeController : Controller
    {
        private  readonly FuhoWebContext _context;
        public EmployeeController(FuhoWebContext context) 
        { 
            _context = context;
        }
        public IActionResult Index()
        {
            List<Employee> employees = _context.Employees.ToList();
            return View(employees);
        }
    }
}
