using business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using entities;
using data;

namespace MVC_Razor_ADO.Controllers
{
    public class AlumnosController : Controller
    {

        NAlumno _oNAlumno = new NAlumno();
        NEstado _oNEstado = new NEstado();
        NEstatusAlumno _oNEstatusAlumno2 = new NEstatusAlumno();

        public ActionResult Index()
        {

            List<Alumno> alumnoList = new List<Alumno>();
            alumnoList = _oNAlumno.Consultar();
            return View(alumnoList);
        }
        public ActionResult Details(int id)
        {

            Alumno oAlumno = _oNAlumno.Consultar(id);
            return View(oAlumno);
        }



        public ActionResult Delete(int id)
        {
            Alumno alumnoDel = _oNAlumno.Consultar(id);
            return View(alumnoDel);
        }

        [HttpPost]
        public ActionResult Delete(int id, Alumno alumno)
        {
            _oNAlumno.Eliminar(id);
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            Estados();
            Estatus();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                _oNAlumno.Agregrar(alumno);
                return RedirectToAction("Index");
            }
            return View(alumno);
        }
        
        private void Estados()
        {

            List<Estado> listaEstado = _oNEstado.Consultar();
            ViewBag.idEstado = new SelectList(listaEstado, "id", "nombre");
            ViewBag.estados = listaEstado;

        }
        private void Estatus()
        {

            List<EstatusAlumno> listaEstatus = _oNEstatusAlumno2.Consultar();
            ViewBag.idEstatus = new SelectList(listaEstatus, "id", "nombre");
            ViewBag.estatus = listaEstatus;

        }
        public ActionResult Edit(int id)
        {
            Estados();
            Estatus();
            Alumno alumno = _oNAlumno.Consultar(id);

            return View(alumno);
        }
    }
}