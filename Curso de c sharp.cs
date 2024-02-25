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
    class Progra
    {
        /// <summary>
        /// Toda clase tiene que tener un metodo definido como se muestra a continuacion.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Una sentencia que termina en ; se le conoce como una instruccion, los metodos, clases, condicionales o bucles no pueden terminar con ;
            // console es la consola o terminal y writeline es que nos escriba una linea de texto, siempre y cuando le demos un atribto asi("Hola xddd")
            Console.WriteLine("Introduccion a c sharp");

            // hay que tener cuidado con el flujo de ejecucion, debemos declarar nuestro codigo de forma correcta
            
            // ejemplo de una variable, declaracion e iniciacion en la misma linea
            // tipo de dato, nombre de la variable y su valor
            int edad = 18;

            // lo anterior pero en linea diferente
            // edad = 18;
            Console.WriteLine(edad);

            // System.Console.WriteLine("Hola xdd"); esto tambien es valido pero tendriamos que hacerlo en cada sentencia que usemos la biblioteca, es mejor exportarla al inicio.
            //Instancia.metodo(atributo);
            // c sharp trabaja con algo llamado intellisense, y esto sirve para ayudar al usuario sobre los posibles problemas que podemos enfrentar en nuestro codigo
            // y esto lo hace por medio de una bombilla amarillla que si le damos click, nos desplegara un menu con diferentes opciones de correcion o aclaraciones.
            // este menu tambien aparece cuando escribimos una palabra clave.

            Console.WriteLine(7 * 5);
        }
    }
}