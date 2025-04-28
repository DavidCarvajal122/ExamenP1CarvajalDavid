using Microsoft.AspNetCore.Mvc;
using ExamenP1CarvajalDavid.Data;
using ExamenP1CarvajalDavid.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ExamenP1CarvajalDavid.Controllers
{
    public class ReservaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var reservas = _context.Reservas.Include(r => r.Cliente).ToList();
            return View(reservas);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Clientes = _context.Clientes.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                _context.Reservas.Add(reserva);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Clientes = _context.Clientes.ToList();
            return View(reserva);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var reserva = _context.Reservas.Find(id);
            if (reserva == null)
            {
                return NotFound();
            }
            ViewBag.Clientes = _context.Clientes.ToList();
            return View(reserva);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                _context.Reservas.Update(reserva);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Clientes = _context.Clientes.ToList();
            return View(reserva);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var reserva = _context.Reservas.Include(r => r.Cliente).FirstOrDefault(r => r.Id == id);
            if (reserva == null)
            {
                return NotFound();
            }
            return View(reserva);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var reserva = _context.Reservas.Find(id);
            if (reserva != null)
            {
                _context.Reservas.Remove(reserva);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var reserva = _context.Reservas.Include(r => r.Cliente).FirstOrDefault(r => r.Id == id);
            if (reserva == null)
            {
                return NotFound();
            }
            return View(reserva);
        }
    }
}
