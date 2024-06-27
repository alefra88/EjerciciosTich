﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
    public class Alumno
    {
        public Alumno()
        {
        }

        public Alumno(int id, string nombre, string primerApellido, string segundoApellido, string correo, string telefono, DateTime fechaNacimiento, string curp, decimal sueldoMensual, int idEstadoOrigen, int idEstatus)
        {
            this.id = id;
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.correo = correo;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
            this.curp = curp;
            this.sueldoMensual = sueldoMensual;
            this.idEstadoOrigen = idEstadoOrigen;
            this.idEstatus = idEstatus;
        }

        public int id { get; set; }
        public string nombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string curp { get; set; }
        public decimal sueldoMensual { get; set; }
        public int idEstadoOrigen { get; set; }
        public int idEstatus { get; set; }

    }
}
