using Almacen_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Almacen_.Controllers
{
    public class PuestoUsuariosController : Controller
    {
        private readonly AlmacenContext _context;//inyeccion sql

        public PuestoUsuariosController(AlmacenContext context)// constructor para optener de la inyeccion el contexto
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.PuestoUsuarios.ToListAsync());
        }
    }
}
