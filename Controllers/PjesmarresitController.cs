using Menaxhimi_Biblotekes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Menaxhimi_Biblotekes.Controllers
{
    public class PjesmarresitController : Controller
    {

        // GET: PjesmarresitController
        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult ChangePassword()
        {
            return View();
        }
        // GET: PjesmarresitController/Details/5
        public ActionResult SignUp(int id)
        {
            return View();
        }

        public ActionResult Profili(PjesmarresitViewModel model)
        {
            return View(model);
        }
        /*  // GET: PjesmarresitController/Create
          public ActionResult Edit()
          {
              return View();
          }*/

        /* // POST: PjesmarresitController/Create
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
         }*/

        // GET: PjesmarresitController/Edit/5
        public ActionResult Edit(PjesmarresitViewModel model)
        {
            return View(model);
        }

        [HttpPost]
        public void Save()
        {
           /* try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }*/
        }

        // POST: PjesmarresitController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: PjesmarresitController/Delete/5
        public ActionResult Delete(int id)
        {
            //Deactivate form DB
            return RedirectToAction("Index", "Home");
        }

        // POST: PjesmarresitController/Delete/5
        /* [HttpPost]
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
         }*/
    }
}
