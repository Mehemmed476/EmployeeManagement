using EmployeeManagement.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.ViewComponents
{
    public class MainSliderViewComponent : ViewComponent 
    {
        private readonly AppDbContext _context;

        public MainSliderViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync() 
        {
            return View();
        }
    }
}
