using System;

namespace Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;

            try
            {
                // se almacena las lineas de texto del archivo
                string linea;

                int contador = 0;

                // directorio al archivo, siempre se coloca una @ para hacerlo
                string path = @"C:\Users\ruben\OneDrive\Desktop\Finally\tirar.txt";

                // accedemos al archivo y lo leemos por medio del path como parametro
                archivo = new System.IO.StreamReader(path);

                // si hay lineas de texto por leer en un archivo que lo almacene ahi y lo imprima
                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);

                    contador++;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error.");
            }

            // lo que hacemos con un finally es, ejecutar unas lineas de codigo si o si, esto nos puede servir principalmente para liberar recursos de nuestra compu y este es un ejemplo, siempre se usa con un try y catch
            finally
            {
                if (archivo != null) archivo.Close();
                Console.WriteLine("El directorio ha sido cerrado");
            }
        }
    }
}