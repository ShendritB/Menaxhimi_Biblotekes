using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Menaxhimi_Biblotekes.Controllers
{
    public class AntarsimiController : Controller
    {
        // GET: AntarsimiController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AntarsimiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AntarsimiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AntarsimiController/Create
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

        // GET: AntarsimiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AntarsimiController/Edit/5
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

        // GET: AntarsimiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AntarsimiController/Delete/5
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
