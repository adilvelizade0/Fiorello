using System.Collections.Generic;
using System.Linq;
using Fiorello.DAL;
using Fiorello.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        // GET
        public IActionResult Index()
        {
            List<Category> categories = _context.Categories.Where(c => !c.IsDeleted).ToList();
            return View(categories);
        }
    }
}