using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
