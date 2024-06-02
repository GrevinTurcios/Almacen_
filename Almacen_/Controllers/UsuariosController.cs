using Almacen_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Almacen_.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AlmacenContext _context;//inyeccion sql

        public UsuariosController(AlmacenContext context)// constructor para optener de la inyeccion el contexto
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var Usuario = _context.Usuarios.Include(E => E.Puesto);
            return View(await Usuario.ToListAsync());
        }

        
        
    }
}
