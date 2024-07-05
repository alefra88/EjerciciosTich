using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Razor_EF.Models;

namespace MVC_Razor_EF.Controllers
{
    
    public class AlumnosController : Controller
    {

        private DB_TICH _DBContext = new DB_TICH();
        private List<Alumnos> _oListAlumnos;
        private Alumnos _oAlumno;
        //private Estados _oEstados;
        //private EstatusAlumnos _oEstatusAlumnos;
        // GET: Alumnos
        public ActionResult Index()
        {
            _oListAlumnos = _DBContext.Alumnos.ToList();
            return View(_oListAlumnos);
        }

        // GET: Alumnos/Details/5
        public ActionResult Details(int id)
        {
            //_DBContext.Configuration.LazyLoadingEnabled = false;
            _oAlumno = _DBContext.Alumnos.Find(id);
            return View(_oAlumno);
        }

        // GET: Alumnos/Create
        public ActionResult Create()
        {           
            return View();
        }

        // POST: Alumnos/Create
        [HttpPost]
        public ActionResult Create(Alumnos alumnos)
        {
            try
            {

                _DBContext.Alumnos.Add(alumnos);
                _DBContext.SaveChanges();
               

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Edit/5
        public ActionResult Edit(int id)
        {
            _oAlumno = _DBContext.Alumnos.Find(id);
            return View(_oAlumno);
            
        }

        // POST: Alumnos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var alumnoEdit = _DBContext.Alumnos.FirstOrDefault(e => e.id == id);
                if (alumnoEdit != null)
                {
                    
                    alumnoEdit.nombre = collection["nombre"];
                    alumnoEdit.primerApellido = collection["primerApellido"];
                    alumnoEdit.segundoApellido = collection["segundoApellido"];
                    alumnoEdit.correo = collection["correo"];
                    alumnoEdit.telefono = collection["telefono"];
                    alumnoEdit.fechaNacimiento = Convert.ToDateTime(collection["fechaNacimiento"]);
                    alumnoEdit.sueldoMensual = Convert.ToDecimal(collection["sueldoMensual"]);
                    alumnoEdit.idEstadoOrigen = Convert.ToInt16(collection["idEstadoOrigen"]);
                    alumnoEdit.idEstatus = Convert.ToInt16(collection["idEstatus"]);
                    _DBContext.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Delete/5
        public ActionResult Delete(int id)
        {
            _oAlumno = _DBContext.Alumnos.Find(id);
            
     
            return View(_oAlumno);
        }

        // POST: Alumnos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id,Alumnos alumnos)
        {
            try
            {
                var alumno = _DBContext.Alumnos.FirstOrDefault(e => e.id == id);
                if(alumno != null)
                {
                    _DBContext.Alumnos.Remove(alumno);
                    _DBContext.SaveChanges();
                }
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
