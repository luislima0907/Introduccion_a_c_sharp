using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEnPOO
{
    public class Carro : Vehiculo
    {
        private string marcaDelCarro;

        private string nombreDelCarro;

        public void GetInformacionDelCarro()
        {
            Console.WriteLine($"El carro es:\nMarca: {marcaDelCarro} Nombre: {nombreDelCarro}");
        }
        public Carro(string marcaDelCarro, string nombreDelCarro) 
        {
            this.marcaDelCarro = marcaDelCarro;
            this.nombreDelCarro = nombreDelCarro;
        }
        public void IrDeRetroceso()
        {
            Console.WriteLine("El carro se esta moviendo hacia atras");
        }

        public void PonerIntermitentes()
        {
            Console.WriteLine("El carro se va a estacionar");
        }

        public override void ConducirElVehiculo()
        {
            // le estamos diciendo que haga los mismo que en su clase padre
            //base.ConducirElVehiculo();
            Console.WriteLine($"El {nombreDelCarro} esta avanzando");
        }
    }
}
