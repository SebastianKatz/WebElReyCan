using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebElReyCan.Data;
using WebElReyCan.Models;

namespace WebElReyCan.Controllers
{
    public class MascotaController : Controller
    {
        public string fechaActual = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();

        private static CanDbContext context = new CanDbContext();

        public ActionResult Index()
        {
            var turno = context.Mascotas.ToList();

            return View("Index", turno);
        }
        // GET: Mascota
        public ActionResult Turno()
        {
            DateTime fecha = Convert.ToDateTime(DateTime.Today.ToShortDateString());
            var turnos = (from t in context.Mascotas
                          where t.Fecha == fecha
                          select t).ToList();

            if (turnos != null)
            {
                return View("Index", turnos);
            }
            return HttpNotFound();
        }


        [HttpGet] // /Mascota/Create
        public ActionResult Create()
        {
            return View("Create", new Mascota());
        }

        [HttpPost] // /Mascota/Create
        public ActionResult Create(Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                context.Mascotas.Add(mascota);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View("Create", mascota);
        }



    }
}