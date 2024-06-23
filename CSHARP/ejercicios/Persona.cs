using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCS
{
    public abstract class Persona
    {
        private string _nombre;
        private DateTime _fechaNacimiento;
        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public string nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public DateTime fechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }
            set
            {
                _fechaNacimiento = value;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura
        /// </summary>
        public string apellidos { get; set; }
        /// <summary>
        /// Método constructor
        /// El método constructor se llama igual que la clase y no regresa dato
        /// Constructor que no requiere argumentos.
        /// </summary>
        public Persona()
        {
        }

        /// <summary>
        /// Sobrecarga del Constructor, con valores de las propiedades
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellidos"></param>
        /// <param name="fechaNacimiento"></param>
        public Persona(string nombre, string apellidos, DateTime fechaNacimiento)
        {
            _nombre = nombre;
            this.apellidos = apellidos;
            _fechaNacimiento = fechaNacimiento;
           
        }
        /// <summary>
        /// Método Virtual la clase derivada puede sobreescribirlo (overrite)
        /// </summary>
        public virtual int edad()
        {

            DateTime hoy = DateTime.Now;
            int edad = hoy.Year - _fechaNacimiento.Year;
            return edad;
        }
        /// <summary>
        /// Método Abstracto la clase derivada debe implementarlo
        /// </summary>
        public abstract string ClaveUnica();


    }
}
