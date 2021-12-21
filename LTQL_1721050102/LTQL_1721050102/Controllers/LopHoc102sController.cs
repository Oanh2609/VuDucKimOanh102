using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQL_1721050102.Controllers
{
    public class LopHoc102sController : Controller
    {
        // GET: LopHoc102s
        public ActionResult Index()
        {
            return View();
        }

        // GET: LopHoc102s/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LopHoc102s/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LopHoc102s/Create
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

        // GET: LopHoc102s/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LopHoc102s/Edit/5
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

        // GET: LopHoc102s/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LopHoc102s/Delete/5
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
