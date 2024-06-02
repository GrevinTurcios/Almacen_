using Almacen_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Almacen_.Controllers
{
    public class ProductosController : Controller
    {
        private readonly AlmacenContext _context;

        public ProductosController(AlmacenContext context)
        { 
            _context = context;
        }

        public async  Task<IActionResult> Index()
        {
            var Producto = _context.Productos.Include(c => c.Categoria);
            return View(await Producto.ToListAsync());
        }

        public IActionResult Create() 
        {
            ViewData["Productos"] = new SelectList(_context.Categoria, "Categoria_ID", "Categoria_Nombre");
            return View();
        }

        [HttpPost]
        public IActionResult Create(int a)
        {
            ViewData["Productos"] = new SelectList(_context.Categoria, "Categoria_ID", "Categoria_Nombre");
            return View();
        }

    }
}
