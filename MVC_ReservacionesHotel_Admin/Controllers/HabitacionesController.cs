using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_ReservacionesHotel_Admin.Views.Companion
{
    public class HabitacionesController : Controller
    {
        // GET: Habitaciones
        public ActionResult Index()
        {
            return View();
        }

        // GET: Habitaciones/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Habitaciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Habitaciones/Create
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

        // GET: Habitaciones/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Habitaciones/Edit/5
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

        // GET: Habitaciones/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Habitaciones/Delete/5
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
