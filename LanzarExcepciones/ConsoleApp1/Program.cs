using System;

namespace LanzarExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero de mes");
            int numeroMes = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(NumeroDeMes(numeroMes));

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Mensaje de la excepcion: {ex.Message}");
            }
            Console.WriteLine("Aqui continua xdddd");
        }

        public static string NumeroDeMes(int numeroMes)
        {

            switch (numeroMes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "febrero";
                case 3:
                    return "marzo";
                case 4:
                    return "abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "agosto";
                case 9:
                    return "septiembre";
                case 10:
                    return "octubre";
                case 11:
                    return "noviembre";
                case 12:
                    return "diciembre";
                default:
                    // con throw lanzamos excepciones por si el usuario u programador necesita informacion sobre el posible error que esta cometiendo al ingresar informacion al programa, esto se puede ver en la libreria de .net framework
                    throw new ArgumentOutOfRangeException();

            }

        }
    }
}