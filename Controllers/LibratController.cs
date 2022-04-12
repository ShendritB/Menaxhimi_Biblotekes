using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Menaxhimi_Biblotekes.Controllers
{
    public class LibratController : Controller
    {
        // GET: LibratController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LibratController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LibratController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LibratController/Create
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

        // GET: LibratController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LibratController/Edit/5
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

        // GET: LibratController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LibratController/Delete/5
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
