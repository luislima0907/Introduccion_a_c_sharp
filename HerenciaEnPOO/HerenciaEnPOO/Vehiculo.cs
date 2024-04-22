using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEnPOO
{
    public class Vehiculo
    {
        public void ArrancarElMotor()
        {
            Console.WriteLine("El motor esta arrancando...");
        }

        public virtual void ConducirElVehiculo()
        {
            Console.WriteLine("El vehiculo de esta moviendo");
        }

        public void ApagarElMotor()
        {
            Console.WriteLine("El motor se apago...");
        }
    }
}
