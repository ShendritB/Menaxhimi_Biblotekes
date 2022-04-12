using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Menaxhimi_Biblotekes.Controllers
{
    public class RoletController : Controller
    {
        // GET: RoletController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RoletController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoletController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoletController/Create
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

        // GET: RoletController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoletController/Edit/5
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

        // GET: RoletController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoletController/Delete/5
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
