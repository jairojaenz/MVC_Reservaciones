using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_ReservacionesHotel_Admin.Controllers
{
    public class RoomServiceController : Controller
    {
        // GET: RoomService
        public ActionResult Index()
        {
            return View();
        }

        // GET: RoomService/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoomService/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoomService/Create
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

        // GET: RoomService/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoomService/Edit/5
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

        // GET: RoomService/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoomService/Delete/5
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
