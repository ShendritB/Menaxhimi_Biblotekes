using Menaxhimi_Biblotekes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Menaxhimi_Biblotekes.Controllers
{
    public class LibratController : Controller
    {
        // GET: LibratController
        public ActionResult Index()
        {
            List<LibratViewModel> n = new List<LibratViewModel>();
            n.Add(new LibratViewModel());
            return View(n);
        }

        // GET: LibratController/Details/5
        public ActionResult Details(int id)
        {
            LibratViewModel l = new LibratViewModel();
            l.Titulli = "Gjenerali i ushtrise se vdekur";
            l.ShtepiaBotuese = "Dukagjini";
            l.ISBN = "978231313112";
            l.VitiBotimit = 2001;
            l.Autoret = new List<AutoretViewModel>();
            return View(l);
        }

        // GET: LibratController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LibratController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LibratViewModel model)
        {
            
            try
            {
                //save to db
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
