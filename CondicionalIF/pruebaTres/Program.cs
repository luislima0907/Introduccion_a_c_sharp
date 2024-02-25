using System;

namespace CondicionalIF
{
    class Program
    {
        static void Main(string[] args)
        {
            bool carnetPrueba = false;
            int edad;
            string carnet;
            int comparar;
            string conEsto = "si";
            string decision = "si";
            int compararDecision;
            int edadDeLaPersona;

            Console.WriteLine("Introduce tu edad y te diremos si eres joven, ect");
            edadDeLaPersona = int.Parse(Console.ReadLine());

            if (edadDeLaPersona < 10) Console.WriteLine("Eres nene");

            // seria como un elif pero en c sharp
            else if (edadDeLaPersona < 18) Console.WriteLine("Eres adolescente");
            else if (edadDeLaPersona < 30) Console.WriteLine("Eres adulto wey");
            else Console.WriteLine("Ya estas viejo xddd");



            Console.WriteLine("Quieres promediar tu nota de examen");
            decision = Console.ReadLine();
            compararDecision = string.Compare(decision, conEsto, true);

            if (compararDecision == 0 ) examenesMariano();


            // ejemplo de un if con una linea de codigo y sin llaves
            // tambien podemos omitir la comparacion si el valor que tenemos es un true, ya que if evalua primero el true y luego el false
            if (carnetPrueba) Console.WriteLine("No puedes manejar xdddd");
            else Console.WriteLine("Menti si puedes xdddddd");

            // alternativa logica
            Console.WriteLine("Ingresa tu edad");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("tienes carnet");
                carnet = Console.ReadLine();

                // lo que hace el string.Compare(arg1, arg2, arg3) es comparar los argumentos, tenemos que pasarle una variable de tipo string, luego una string que queremos comparar, puede ser otra variable de tipo string, y luego decirle que sea verdad o mentira, si es verdad devuelve 0 y sino devuelve 1
                comparar = string.Compare(carnet, conEsto, true);

                if (comparar == 0) Console.WriteLine("Puedes conducir");
                else Console.WriteLine("No puedes conducir");

            }
            else Console.WriteLine("No puedes conducir si eres menor de edad");
        }
        
        static void examenesMariano()
        {
            int parcialUno;
            int parcialDos;
            int examenFinal;

            Console.WriteLine("Nota de tu primer parcial");
            parcialUno = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota de tu segundo parcial");
            parcialDos = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota de examen final");
            examenFinal = int.Parse(Console.ReadLine());

            if (parcialUno >= 5 || parcialDos >= 5 || examenFinal >= 15)
            {

                Console.WriteLine($"Tu promedio es {(parcialUno + parcialDos + examenFinal)/3}");

            }

        }
    }
}
