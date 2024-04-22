using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManejoDeArchivos miArchivo = new ManejoDeArchivos();

            miArchivo.mensaje();
        }
    }

    class ManejoDeArchivos
    {
        StreamReader archivo = null;

        int contador = 0;

        string linea;

        public ManejoDeArchivos()
        {
            // abrimos una conexion hacia un archivo en nuestra pc
            // para poder leerlo con StreamReader
            archivo = new StreamReader(@"C:\Users\ruben\OneDrive\Desktop\Destructores\texto.txt");

            // aca estamos diciendo que mientras el archivo tenga lineas por leer
            // que las lea todas, y que incremente el contador de lineas en uno
            while ((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                contador++;
            }
        }

        public void mensaje()
        {
            Console.WriteLine($"Hay {contador} lineas");
        }

        // esta es la sintaxis de un destructor, un destructor nos sirve para liberar
        // espacio en la memoria, esto puede servir para manejo de archivos, bases de datos, etc
        ~ManejoDeArchivos() // ~ simbolo para la declaracion de un destructor
        {
            archivo.Close(); // cerramos la conexion hacia ese archivo
        }
    }
}
