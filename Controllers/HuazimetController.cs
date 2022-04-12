using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Menaxhimi_Biblotekes.Controllers
{
    public class HuazimetController : Controller
    {
        // GET: HuazimetController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HuazimetController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HuazimetController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HuazimetController/Create
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

        // GET: HuazimetController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HuazimetController/Edit/5
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

        // GET: HuazimetController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HuazimetController/Delete/5
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
