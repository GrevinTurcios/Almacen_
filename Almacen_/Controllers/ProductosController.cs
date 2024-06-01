using Almacen_.Models;
using Microsoft.AspNetCore.Mvc;
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

            return View(await _context.Productos.ToListAsync());
        }
    }
}
