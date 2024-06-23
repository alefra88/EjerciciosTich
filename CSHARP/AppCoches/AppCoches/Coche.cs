using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCoches
{
    internal class Coche
    {

        private StructCoche _datosCoche;

        public Coche(int id, string marca, string modelo, int km, decimal precio)
        {
            _datosCoche = new StructCoche(id,marca,modelo,km.ToString(),precio);
        }
    public override string ToString()
        {
            return $"ID: {_datosCoche.id} marca: {_datosCoche.marca} modelo: {_datosCoche.modelo} km: {_datosCoche.km} precio; {_datosCoche.precio}";
        }
    }
    

}
