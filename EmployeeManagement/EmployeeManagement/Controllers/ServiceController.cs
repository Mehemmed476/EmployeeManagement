using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
