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
        
        public IActionResult Details(int id)
        {
            Category category = _context.Categories.FirstOrDefault(c => !c.IsDeleted && c.Id == id);
            return View(category);
        }
        
        [HttpGet]
        public IActionResult Update(int id)
        {
            Category category = _context.Categories.FirstOrDefault(c => !c.IsDeleted && c.Id == id);
            return View(category);
        }
        
        [HttpPost]
        public IActionResult Update(Category category)
        {
            Category existCategory = _context.Categories.FirstOrDefault(c => !c.IsDeleted && c.Id == category.Id);
            existCategory.Name = category.Name;
            _context.Categories.Update(existCategory);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        
         
        [HttpPost]
        public IActionResult Create(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            Category category = _context.Categories.FirstOrDefault(c => c.Id == id);
            category.IsDeleted = true;
            _context.Categories.Update(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        
    }
}