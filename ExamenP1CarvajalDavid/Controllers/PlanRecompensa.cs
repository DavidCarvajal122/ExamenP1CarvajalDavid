using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamenP1CarvajalDavid.Controllers
{
    public class PlanRecompensa : Controller
    {
        // GET: PlanRecompensa
        public ActionResult Index()
        {
            return View();
        }

        // GET: PlanRecompensa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlanRecompensa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlanRecompensa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlanRecompensa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlanRecompensa/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlanRecompensa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlanRecompensa/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
