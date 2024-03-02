using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticaPOOCSharp
{
    // herencia
    public class buitre : Animal
    {
        public string colorDePlumas { get; set; }

        // polimorfismo
        public override string GetNombre()
        {
            // esto devolvera cuando se llama en leon y no en animal
            return $"Soy un buitre llamado: {nombre}";
        }
        public void Volar()
        {
            Console.WriteLine("esta volando");
        }
    }
}
