using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Menaxhimi_Biblotekes.Controllers
{
    public class PjesmarresitController : Controller
    {
        // GET: PjesmarresitController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PjesmarresitController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PjesmarresitController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PjesmarresitController/Create
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

        // GET: PjesmarresitController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PjesmarresitController/Edit/5
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

        // GET: PjesmarresitController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PjesmarresitController/Delete/5
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
