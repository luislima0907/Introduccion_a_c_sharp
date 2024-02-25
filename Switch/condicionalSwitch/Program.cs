using System;

namespace 
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDeMeses;

            Console.WriteLine("Introduce un mes para hacer el calculo de tu sueldo");

            numeroDeMeses = int.Parse(Console.ReadLine());

            // la condicional switch funciona como el if, solo que aqui solo puede evaluar un tipo de dato que se tiene que mantener constante durante todo el bloque
            switch (numeroDeMeses)
            {
                case 1:
                    Console.WriteLine("Has escogido enero");
                    break;

                case 2:
                    Console.WriteLine("Has escogido febrero");
                    break;

                case 3:
                    Console.WriteLine("Has escogido marzo");
                    break;

                case 4:
                    Console.WriteLine("Has escogido abril");
                    break;

                case 5:
                    Console.WriteLine("Has escogido mayo");
                    break;

                case 6:
                    Console.WriteLine("Has escogido junio");
                    break;

                case 7:
                    Console.WriteLine("Has escogido julio");
                    break;

                case 8:
                    Console.WriteLine("Has escogido agosto");
                    break;

                case 9:
                    Console.WriteLine("Has escogido septiembre");
                    break;

                case 10:
                    Console.WriteLine("Has escogido octubre");
                    break;

                case 11:
                    Console.WriteLine("Has escogido noviembre");
                    break;

                case 12:
                    Console.WriteLine("Has escogido diciembre");
                    break;

                default:
                    Console.WriteLine("Ese numero no representa ningun mes");
                    break;
            }
        }
    }
}