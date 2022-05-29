using System.Linq;
using Fiorello.DAL;
using Fiorello.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiorello.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        // GET
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Sliders = _context.Sliders.ToList(),
                Abouts = _context.Abouts.ToList(),
                Experts = _context.Experts.ToList(),
                Blogs = _context.Blogs.ToList(),
                Says = _context.Says.ToList(),
                Categories = _context.Categories.ToList(),
                Products = _context.Products.Where(p => !p.IsDeleted).Include(p => p.Category).ToList()
            };
            return View(homeViewModel);
        }
    }
}