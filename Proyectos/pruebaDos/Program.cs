// este es un ejemplo de clase predefinida, si la borramos, no podremos usar los metodos u objetos que contiene, en resumen, funciona como una biblioteca en python.
using System;
// comentarios

// los comentarios nos sirven para explicar nuestro codigo, hay dos tipos de comentario, de una linea o de mas lineas.
// este es un comentario de una linea se hace con //
/* este es un comentario de varias lineas
 * jajaja
 * xddd
 * siempre terminan en "* /"
 * */
// los comentarios tambien nos sirven para hacer pruebas con la invalidacion de lineas.
// hay botones para crear comentarios y quitarlos en la barra de tareas.

// ejecutar el programa

// con la opcion de compilar solucion, nos puede dar una prueba de nuestro programa y decirnos si hay errores o no.
// podemos ejecutar el programa sin depurar, esto nos abrira una consola del sistema donde nos dara el resultado de nuestro programa.

// datos de c sharp

// c sharp utiliza el tipo de escritura case sensitive, o sea, distingue entre mayusculas y minusculas. 
// los namespace pueden interpretarse como una especie de carpeta donde guardamos las clases y lo demas, por esa razon, no podemos nombrar dos clases u otra cosa con el mismo nombre.

// errores de sintaxis

/// los errores de sintaxis nos remarca con color rojo el propio visual studio, un error de sintaxis nos puede perjudicar en nuestro codigo
/// a la hora de ejcutar nos dice los errores de sintaxis que tengamos y tambien en que linea lo cometimos.
/// si nosotros le damos click al error que cometimos nos llevara a esa linea en especifico para poder facilitarnos la correcion.

/// los identificadores
/// se usadn para nombrar a los elementos de nuestro programa.
/// namespace, clases, metodos, variables y constantes,
/// solo se pueden usar letras para nombrar los identificadores, numeros y guiones bajos.
/// siempre tienen que comenzar con una letra o guion bajo pero nunca con un numero.
/// no se pueden usar palabras clave como identificador

/// las palabras clave
/// son de color azul y sirven para crear algo en concreto en el programa.
namespace programacionOrientadaAObjetos
// lo que esta dentro de las llaves se le conoce como un bloque de codigo, y este se puede reutilizar dependiendo las funciones que creemos.
{
    /// <summary>
    /// clases
    /// 
    /// Una clase será una especie de modelo que usaremos para crear algo, con todo y sus características.
    /// como aclaracion, no podemos crear dos clases con el mismo nombre, a no ser, que lo hagamos con namespace.
    /// las clases propias son las que creamos nosotros con la ayuda de c sharp pero las clases predefinidas son las que se encuentran en las bibliotecas de clases o API.
    /// un ejemplo de clase predefinida es Console, ya que esta posee varios metodos para poder utilizarla
    /// </summary>
    class Program
    {
        // todo lo que se declare e inicie dentro una clase, se les conoce como campos de clase, y estos los podemos llamar en cualquier parte del programa, ya que es lo primero que lee el programa antes del Main principal donde contiene todos los metodos y funciones de nuestro programa.
        int numeroClaseUno = 10;
        
        int numeroClaseDos = 12;
        // Toda clase tiene que tener un metodo definido como se muestra a continuacion.
        // static es un metodo al igual que Main, string[] es un arreglo donde tambien contiene un argumento como parametro.
        // el metodo Main es el primero que se va a ejecutar en nuestro programa y despues todo lo que contenga, es como el esqueleto y cuerpo de nuestro programa, de ahi su nombre.
        // un dato sobre main, es que siempre se va a ejecutar primero, antes que otros metodos o funciones que tengamos en nuestro programa, esto es porque main es el metodo principal como lo mencionamos anteriormente.
        static void Main(string[] args)
        {

            //int valor1 = 2;
            //double valor2 = 4.5;
            //double valor3 = 8.5;
            //System.Console.WriteLine(multiplicacionOpcional(valor1,valor2));

            // los valores boleanos y la condicional IF

            // IF se puede interpretar como un controlador de flujo, es decir, dependiendo que ingrese el usuario podria cambiar el rumbo del programa

            Console.WriteLine("Vamos a evaluar si puedes conducir")
            bool carnet = false;

            if (carnet == false)
            {
                Console.WriteLine("no puedes conducir");
            }
            Console.ReadKey();

            //bool haceCalor = false;

            //// con el signo ! invertimos el valor de un boleano, si es true pasa a ser false, y viceversa.
            //Console.WriteLine(!haceCalor);

            //int mayorDeEdad;
            //mayorDeEdad = int.Parse(Console.ReadLine());

            //// tambien podemos omitir las llaves de apertura y cierre que contenga el if, siempre y cuando solo tengamos una linea de codigo adentro de esta condicional.
            //if (mayorDeEdad >= 18)
            //{
            //    Console.WriteLine("Tu eres mayor de edad");
            //}
            //else
            //{
            //    Console.WriteLine("Tu eres menor de edad");
            //}

            //Console.WriteLine("Vamos a evaluar si puedes conducir")
            //bool carnet = false;

            //if (carnet == false)
            //{
            //    Console.WriteLine("no puedes conducir");
            //}
        }
        static double multiplicacionOpcional(int num1, double num2, double num3=0){
            return num1 * num2 * num3;
        }
        // cuando tenemos dos metodos con el mismo nombre pero un metodo tiene parametros opcionales, a la hora de llamar y accionar el metodo va a escoger la funcion que mas se adapte.
        static double multiplicacionOpcional(int num1, double num2){
            return num1 * num2;
        }


    }
}
