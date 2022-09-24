using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjercicioClase.Models;

namespace EjercicioClase.Controllers
{
    public class librosController : Controller
    {
        // GET: libros
        public ActionResult Index()
        {
            List<libros> libros = new List<libros>();
            using (bibliotecaEntities biblioteca = new bibliotecaEntities())
            {
                libros = biblioteca.libros.ToList<libros>();
            }
            return View(libros);
        }

        // GET: libros/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: libros/Create
        public ActionResult Create()
        {
            return View(new libros());
        }

        // POST: libros/Create
        [HttpPost]
        public ActionResult Create(libros libros)
        {
            using (bibliotecaEntities biblioteca = new bibliotecaEntities())
            {
                biblioteca.libros.Add(libros);
                biblioteca.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // GET: libros/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: libros/Edit/5
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

        // GET: libros/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: libros/Delete/5
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
