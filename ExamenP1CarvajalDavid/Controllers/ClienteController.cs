using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExamenP1CarvajalDavid.Data;
using ExamenP1CarvajalDavid.Models;


namespace ExamenP1CarvajalDavid.Controllers
{

        public class ClienteController : Controller
        {
            private readonly ApplicationDbContext _context;

            public ClienteController(ApplicationDbContext context)
            {
                _context = context;
            }

            public IActionResult Index()
            {
                var lista = _context.Clientes.ToList();
                return View(lista);
            }

            public IActionResult Crear()
            {
                return View();
            }

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

            public IActionResult Editar(int id)
            {
                var cliente = _context.Clientes.Find(id);
                if (cliente == null)
                {
                    return NotFound();
                }
                return View(cliente);
            }


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

            public IActionResult Detalles(int id)
            {
                var cliente = _context.Clientes.Find(id);
                if (cliente == null)
                {
                    return NotFound();
                }
                return View(cliente);
            }

            public IActionResult Eliminar(int id)
            {
                var cliente = _context.Clientes.Find(id);
                if (cliente == null)
                {
                    return NotFound();
                }
                return View(cliente);
            }


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
