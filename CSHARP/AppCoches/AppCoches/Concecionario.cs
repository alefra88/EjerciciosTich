using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCoches
{
    //tendra un array de objetos coche y un limite de coches
    //se crearan los siguientes metodos 
    // -aniadirCoche(Coche c)
    // -mostrarCoches()
    // -vaciarCoches()
    //eliminarCoches(Coche c)
    internal class Concecionario
    {
        private StructConcecionario _concecionario;

        //constructor que recibe el objeto StructConcecionario
        public Concecionario(StructConcecionario concecionario)
        {
            _concecionario = concecionario;

        }
        public void aniadirCoche(Coche c)
        {
            // Buscar la primera posición disponible en el arreglo _coches
            for (int i = 0; i < _concecionario.coches.Length; i++)
            {
                if (_concecionario.coches[i] == null)
                {
                    _concecionario.coches[i] = c; // Añadir el coche a la posición encontrada
                    Console.WriteLine($"Coche añadido: {c.ToString()}");
                    return;
                }
            }
            // Si no hay posiciones disponibles, mostrar mensaje de concesionario lleno
            Console.WriteLine("No se pudo añadir el coche. El concesionario está lleno.");
        }

        // Método para mostrar todos los coches en el concesionario
        public void mostrarCoches()
        {
            Console.WriteLine("Listado de coches en el concesionario:");
            foreach (Coche c in _concecionario.coches)
            {
                if (c != null)
                {
                    Console.WriteLine(c.ToString()); // Mostrar información del coche usando ToString()
                }
            }
        }

        // Método para vaciar todos los coches del concesionario
        public void vaciarCoches()
        {
            _concecionario.coches = new Coche[_concecionario.limite]; // Crear un nuevo arreglo vacío del tamaño original
            Console.WriteLine("Se han vaciado todos los coches del concesionario.");
        }

        // Método para eliminar un coche específico del concesionario
        public void eliminarCoche(Coche c)
        {
            for (int i = 0; i < _concecionario.coches.Length; i++)
            {
                if (_concecionario.coches[i] == c)
                {
                    _concecionario.coches[i] = null; // Eliminar el coche estableciendo la posición a null
                    Console.WriteLine($"Coche eliminado: {c.ToString()}");
                    return;
                }
            }
            // Si no se encuentra el coche, mostrar mensaje de coche no encontrado
            Console.WriteLine("No se encontró el coche especificado en el concesionario.");
        }

    }
}
