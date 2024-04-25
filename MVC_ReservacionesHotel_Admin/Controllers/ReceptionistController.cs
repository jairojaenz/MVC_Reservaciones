using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_ReservacionesHotel_Admin.Controllers
{
    public class ReceptionistController : Controller
    {
        // GET: Receptionist
        public ActionResult Index()
        {
            return View();
        }

        // GET: Receptionist/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Receptionist/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Receptionist/Create
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

        // GET: Receptionist/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Receptionist/Edit/5
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

        // GET: Receptionist/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Receptionist/Delete/5
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
