using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamenP1CarvajalDavid.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using HotelReservaMVC.Data;
    using HotelReservaMVC.Models;
    using System.Linq;
    using ExamenP1CarvajalDavid.Models;

    namespace HotelReservaMVC.Controllers
    {
        public class ClienteController : Controller
        {
            private readonly ApplicationDbContext _context;

            public ClienteController(ApplicationDbContext context)
            {
                _context = context;
            }

            // Mostrar todos los clientes
            public IActionResult Index()
            {
                var lista = _context.Clientes.ToList();
                return View(lista);
            }

            // Formulario para crear cliente
            public IActionResult Crear()
            {
                return View();
            }

            // Guardar cliente
            [HttpPost]
            public IActionResult Crear(Cliente cliente)
            {
                if (ModelState.IsValid)
                {
                    _context.Clientes.Add(cliente);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(cliente);
            }

            // Formulario para editar cliente
            public IActionResult Editar(int id)
            {
                var cliente = _context.Clientes.Find(id);
                if (cliente == null)
                {
                    return NotFound();
                }
                return View(cliente);
            }

            // Guardar cambios
            [HttpPost]
            public IActionResult Editar(Cliente cliente)
            {
                if (ModelState.IsValid)
                {
                    _context.Clientes.Update(cliente);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(cliente);
            }

            // Ver detalles
            public IActionResult Detalles(int id)
            {
                var cliente = _context.Clientes.Find(id);
                if (cliente == null)
                {
                    return NotFound();
                }
                return View(cliente);
            }

            // Confirmar eliminar
            public IActionResult Eliminar(int id)
            {
                var cliente = _context.Clientes.Find(id);
                if (cliente == null)
                {
                    return NotFound();
                }
                return View(cliente);
            }

            // Borrar cliente
            [HttpPost, ActionName("Eliminar")]
            public IActionResult EliminarConfirmado(int id)
            {
                var cliente = _context.Clientes.Find(id);
                if (cliente != null)
                {
                    _context.Clientes.Remove(cliente);
                    _context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
        }
    }

}
