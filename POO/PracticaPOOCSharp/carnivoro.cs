using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOOCSharp
{
    // este es el ejemplo de una herencia de clase, ponemos dos puntos : y luego el nombre de la clase que queremos heredar
    public class carnivoro : Animal
    {
        public int cantidadDeComida {  get; set; }

        public void ComerCarne() 
        {
            Console.WriteLine("Esta comiendo carne");
        }
    }
}
