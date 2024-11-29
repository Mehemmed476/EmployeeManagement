using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
