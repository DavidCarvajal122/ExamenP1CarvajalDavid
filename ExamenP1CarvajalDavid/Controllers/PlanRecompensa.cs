﻿using Microsoft.AspNetCore.Mvc;
using ExamenP1CarvajalDavid.Data;
using ExamenP1CarvajalDavid.Models;
using System.Linq;

namespace ExamenP1CarvajalDavid.Controllers
{
    public class PlanRecompensaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlanRecompensaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var lista = _context.PlanesRecompensa.ToList();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PlanRecompensa planRecompensa)
        {
            if (ModelState.IsValid)
            {
                _context.PlanesRecompensa.Add(planRecompensa);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(planRecompensa);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var planRecompensa = _context.PlanesRecompensa.Find(id);
            if (planRecompensa == null)
            {
                return NotFound();
            }
            return View(planRecompensa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PlanRecompensa planRecompensa)
        {
            if (ModelState.IsValid)
            {
                _context.PlanesRecompensa.Update(planRecompensa);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(planRecompensa);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var planRecompensa = _context.PlanesRecompensa.Find(id);
            if (planRecompensa == null)
            {
                return NotFound();
            }
            return View(planRecompensa);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var planRecompensa = _context.PlanesRecompensa.Find(id);
            if (planRecompensa != null)
            {
                _context.PlanesRecompensa.Remove(planRecompensa);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var planRecompensa = _context.PlanesRecompensa.Find(id);
            if (planRecompensa == null)
            {
                return NotFound();
            }
            return View(planRecompensa);
        }
    }
}
