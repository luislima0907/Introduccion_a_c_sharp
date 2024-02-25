using System;

namespace Checked
{
    class Program
    {
        static void Main(string[] args)
        {
            // con checked hacemos que nos de en consola el tipo de error si lo hubiese, pero tambien hay una opcion avanzada en visual studio que permite ahorrarse este paso de escribir su palabra clave

            // si tenemos activada esa opcion, entonces tenemos que usar unchecked para desactivarla segun nos convenga
            unchecked
            {
                int numeroMaximo = int.MaxValue;
                int numeroNormal = numeroMaximo + 20;
                Console.WriteLine(numeroNormal);
            }

            // este chequeo solo permite datos de tipo int y long, con lo demas no se puede
        }
    }
}