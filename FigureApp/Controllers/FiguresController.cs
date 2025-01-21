using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using FigureApp.Data;
using FigureApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FigureApp.Controllers
{
    public class FiguresController : Controller
    {
        private readonly FigureContext _context;

        public FiguresController(FigureContext context)
        {
            _context = context;
        }

        // GET: Figure Circle
        public IActionResult Circle(int size = 1, string color = "000000")
        {
            ViewData["Size"] = size;
            ViewData["Color"] = color;
            return View();
        }

        // GET: Figure Triangle
        public IActionResult Triangle(int size = 1, string color = "000000")
        {
            ViewData["Size"] = size;
            ViewData["Color"] = color;
            return View();
        }

        // GET: Figure Square
        public IActionResult Square(int size = 1, string color = "000000")
        {
            ViewData["Size"] = size;
            ViewData["Color"] = color;
            return View();
        }

        // POST: Save Figure
        [HttpPost]
        public async Task<IActionResult> Save(string type, int size, string color)
        {
            var figure = new Figure { Type = type, Size = size, Color = color };
            _context.Add(figure);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // GET: Index
        public async Task<IActionResult> Index()
        {
            return View(await _context.Figures.ToListAsync());
        }

        // POST: Delete Figure
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var figure = await _context.Figures.FindAsync(id);
            if (figure != null)
            {
                _context.Figures.Remove(figure);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}
