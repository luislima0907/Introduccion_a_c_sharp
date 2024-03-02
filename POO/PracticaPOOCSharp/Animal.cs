using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOOCSharp
{
    public class Animal
    {
        public string nombre {  get; set; }

        // ejemplo de sobreescritura
        public virtual string GetNombre()
        {
            // esto devuelve originalmente sin sobreescritura en otra clase
            return $"El nombre del animal es:\n {nombre}";
        }
    }
}
