using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEnPOO
{
    public class Avion : Vehiculo
    {
        private string nombreDelAvion;

        private string marcaDelAvion;

        public void GetInformacionDelAvion()
        {
            Console.WriteLine($"El avion es: {nombreDelAvion} y su marca es: {marcaDelAvion}");
        }

        public Avion(string nombreDelAvion, string marcaDelAvion)
        {
            this.marcaDelAvion = marcaDelAvion;
            this.nombreDelAvion = nombreDelAvion;
        }
        public void Volar()
        {
            Console.WriteLine("El avion esta volando");
        }

        public void Planear()
        {
            Console.WriteLine("El avion esta planeando para aterrizar");
        }

        public override void ConducirElVehiculo()
        {
            Console.WriteLine($"El {nombreDelAvion} esta empezando a salir para su vuelo");
        }

    }
}
