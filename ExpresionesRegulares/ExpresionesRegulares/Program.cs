using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpresionesRegulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fraseDos = "mi web es https://www.pildorasinformaticas.es";

            // ? este signo hace que sea opcional la expresion que pongamos adentro ()
            string patronWeb = "https://(www.)?pildorasinformaticas.es";

            string frase = "Mi nombre es Luis y mi numero de telefono es +502-5582-0113, +34-123-45-78 y mi codigo postal es 2100";
            
            // [cualquier letra] nos permite buscar cualquier tipo de letra
            string patron = "[L]";

            // la @ antes de una string nos permite almacenar
            // caracteres especiales
            string patronNumeros = @"\d";

            // cuando ponemos \d{4} le indicamos la cantidad de digitos juntos
            // tiene que encontrar la expresion regular
            string patronTelefono = @"\+502-\d{4}-\d{4}";

            string patronDeComparacion = @"\+502|\+34";

            // creamos una coleccion con las coincidencias
            Regex miRegex = new Regex(patron);
            Regex miSegundoRegex = new Regex(patronNumeros);
            Regex miTercerRegex = new Regex(patronTelefono);
            Regex miCuartoRegex = new Regex(patronDeComparacion);
            Regex miRegexWeb = new Regex(patronWeb);

            MatchCollection elQuintoMatch = miRegexWeb.Matches(fraseDos);

            MatchCollection elCuartoMatch = miCuartoRegex.Matches(frase);

            MatchCollection elMatchTres = miTercerRegex.Matches(frase);

            MatchCollection elMatchDos = miSegundoRegex.Matches(frase);

            // busque coincidencias en la frase, y que lo almacene en la coleccion
            MatchCollection elMatch = miRegex.Matches(frase);

            if(elQuintoMatch.Count > 0) Console.WriteLine("Web si");
            else Console.WriteLine("Web no");

            if (elCuartoMatch.Count > 0) Console.WriteLine("cel de guate o espania");
            else Console.WriteLine("nose wey");

            if (elMatchTres.Count > 0) Console.WriteLine("Si hay un numero telefonico de guate");
            else Console.WriteLine("No hay numero de cel de guate");

            if (elMatchDos.Count > 0) Console.WriteLine("Hay numeros");
            else Console.WriteLine("no hay numeros");

            if (elMatch.Count > 0) Console.WriteLine("Se ha encontrado L");
            else Console.WriteLine("No has encontrado L");
        }
    }
}
