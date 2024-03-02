using System;
using System.Reflection.Metadata.Ecma335;

namespace PracticaPOOCSharp
{
    class Program
    {
        // public significa que podemos usar los metodos de una clase en cualquier parte del programa
        // private solo podemos usar los metodos de una clase en ella misma
        // protected sirve para que solo las clases heredadas puedan usar los metodos de la clase padre
        static void Main(string[] args)
        {
            Leon leon = new Leon(60, "Saul");
            // al momento de llamar a la clase leon nos aparecen todas los metodos heredados
            leon.Correr();
            leon.nombre = "XD";
            leon.Correr(30);
            leon.Correr("Jalapa");
            Console.WriteLine($"Llamando al metodo sobre escrito\n{leon.GetNombre()}");

            // de esta manera accedemos a una variable privada en c sharp
            leon.Velocidad = 13;
            Console.WriteLine($"Llamando a velocidad\n{leon.calcularVelocidad}");

            buitre buitre = new buitre();
            buitre.nombre = "Marvin";
            Console.WriteLine($"{buitre.GetNombre()}");
        }
    }
}