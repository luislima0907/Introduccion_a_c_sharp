using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            string decision;
            string conEstoSi = "si";
            string conEstoNo = "no";
            int compararDecision;
            int compararNo;
            int numeroAleatorio;
            int miNumero;
            int intentos;

            Random numero = new Random();

            numeroAleatorio = numero.Next(0, 1000);
            intentos = 0;

            // bucle do while, quiere decir que hara al menos una vez lo hay dentro de este, y luego evaluara si la condicion es falsa para romper con el bucle.
            do
            {
                intentos++;

                Console.WriteLine("Introduce un numero del 0 al 1000");
                // trata de ejecutar y sino pasa al catch
                try
                {
                    miNumero = int.Parse(Console.ReadLine());

                }
                // la primera excepcion en la jerarquia, esta solo se suele usar cuando hay muchos errores que capturar, de lo contrario, hay que ser mas especifico
                // tambien se puede omitir la excepcion de abajo y solo dejar el catch, pero solo funciona en c sharp no en otros lenguajes de programacion
                catch (Exception ex) when (ex.GetType() != typeof(FormatException)) // esta es una manera de filtrar excepciones, se utilizan los metodos del objeto ex o e para darle un trato especial a alguna excepcion que queramos.
                // solo se puede hacer un filtro a la vez xddd
                {
                    Console.WriteLine("Ha habido un error, intentelo de nuevo");
                    // con esto, hacemos un objeto de la clase exception y lo guardamos en una variable que se llame ex o e, y con esto podemos brindarle informacion sobre los posibles errores a otros programadores
                    Console.WriteLine(ex.Message);
                    miNumero = 0;

                }
                // Resuelve error de formato
                catch (FormatException ex)
                {
                    Console.WriteLine("Ingresaste texto u otro valor que no sea un numero, intentelo de nuevo");
                    miNumero = 0;
                    
                // resuelve error de rango
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("El numero ingresado esta fuera del rango de 0 y 100, intentelo de nuevo");
                    miNumero = 0;
                }

                if (miNumero > numeroAleatorio) Console.WriteLine("Es mas bajo");
                else if (miNumero < numeroAleatorio) Console.WriteLine("Es mas alto");

            } while (miNumero != numeroAleatorio);
            Console.WriteLine($"Has necesitado {intentos} intentos");

            miNumero = 101;

            intentos = 0;

            while (numeroAleatorio != miNumero)
            {
                intentos++;

                Console.WriteLine("Introduce un numero del 0 al 1000");
                miNumero = int.Parse(Console.ReadLine());

                if (miNumero > numeroAleatorio) Console.WriteLine("Es mas bajo");
                else if (miNumero < numeroAleatorio) Console.WriteLine("Es mas alto");
            }

            Console.WriteLine($"Has necesitado {intentos} intentos");

            Console.WriteLine("Quieres entrar en while");

            decision = Console.ReadLine();

            compararDecision = string.Compare(decision, conEstoSi, true);
            compararNo = string.Compare(decision, conEstoNo, false);

            while (compararDecision == 0 && compararNo == 1)
            {
                Console.WriteLine("Escribe tu nombre");

                string nombre = Console.ReadLine();

                Console.WriteLine($"Hola {nombre}, deseas repetir el bucle");

                decision = Console.ReadLine();
                compararDecision = string.Compare(decision, conEstoSi, true);
                compararNo = string.Compare(decision, conEstoNo, false);

            }

            Console.WriteLine("Haz salido del bucle");

        }
    }
}