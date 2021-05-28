using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace habonapp.Controllers
{
    public class LoginHomeController : Controller
    {
        // GET: LoginHome
        public ActionResult Index()
        {
            return View();
        }

        // GET: LoginHome/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginHome/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginHome/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginHome/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginHome/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginHome/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginHome/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
