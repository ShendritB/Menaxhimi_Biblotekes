using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Menaxhimi_Biblotekes.Controllers
{
    public class KategoriaController : Controller
    {
        // GET: KategoriaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: KategoriaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KategoriaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KategoriaController/Create
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

        // GET: KategoriaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KategoriaController/Edit/5
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

        // GET: KategoriaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KategoriaController/Delete/5
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
