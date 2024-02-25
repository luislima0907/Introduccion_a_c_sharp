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
            // un ejemplo de return y una llamada
            System.Console.WriteLine(restaDeNumeros(9,3));

            // ejemplo de pasar parametros a un metodo en llamada, por valor
            System.Console.WriteLine(sumaDeNumeros(9,10));
            
            // Una sentencia que termina en ; se le conoce como una instruccion, los metodos, clases, condicionales o bucles no pueden terminar con ;
            // console es la consola o terminal y writeline es que nos escriba una linea de texto, siempre y cuando le demos un atribto asi("Hola xddd")
            Console.WriteLine("Introduccion a c sharp");

            // hay que tener cuidado con el flujo de ejecucion, debemos declarar nuestro codigo de forma correcta
            
            // ejemplo de una variable, declaracion e iniciacion en la misma linea
            // tipo de dato, nombre de la variable y su valor
            int edad = 18;

            // tres formas de un formato de imprimir una variable a textos.
            // esto se llama interpolacion de strings
            Console.WriteLine($"La edad de Luis es {edad}");
            Console.WriteLine("La edad de Marvin es {0}", edad);

            // esto es concatenar un texto con una variable.
            Console.WriteLine("La edad de Jose es " + edad);

            // operador de incremento y decremento.

            // esto es para incrementar en 1
            edad++;
            Console.WriteLine($"tienes una edad de {edad}");

            // esto es para incrementar el valor de una variable con su valor establecido
            edad += 3;
            Console.WriteLine($"Tu edad es {edad}");

            // disminuir un valor
            edad--;
            Console.WriteLine(edad);

            // disminuir valor como nosotros queramos.
            edad -= 2;
            Console.WriteLine(edad);

            // lo anterior pero en linea diferente
            // edad = 18;
            Console.WriteLine(edad);


            // C sharp tambien nos permite agregar el mismo valor en las variables que escojamos en una linea de codigo o varias
            int edadPersonaUno;
            int edadPersonaDos;
            int edadPersonaTres;
            int edadPersonaCuatro;

            edadPersonaUno = edadPersonaDos = edadPersonaTres = edadPersonaCuatro = 20;
            Console.WriteLine(edadPersonaUno);

            // como definir una variable por compilacion
            // lo que hacemos aqui es darle un unico tipo de valor a una variable y que no se puede moficar, es obligatorio iniciarla para poder usarla.
            var edadPersonaCinco = 15;
            Console.WriteLine(edadPersonaCinco);

            // conversion explicita
            // para cambiar el tipo de dato de una variable, tenemos que crear una variable con el tipo que queremos cambiar, y luego asignarle el mismo valor entre parentesis (int) y el nombre de la variable.
            double temperatura = 10.6;
            int temperaturaJalapa;

            temperaturaJalapa = (int) temperatura;
            Console.WriteLine(temperaturaJalapa);

            // conversion implicita
            // podemos investigarlo en google
            // podemos hacer lo anterior pero sin asignarle el tipo entre parentesis, pero las dos variables tienen estar en el mismo rango del tipo de dato, decimales con float etc.

            int habitantesCiudad = 10000000;
            long habitantesCiudad2018 = habitantesCiudad;
            Console.WriteLine(habitantesCiudad2018);

            // System.Console.WriteLine("Hola xdd"); esto tambien es valido pero tendriamos que hacerlo en cada sentencia que usemos la biblioteca, es mejor exportarla al inicio.
            //Instancia.metodo(atributo);
            // c sharp trabaja con algo llamado intellisense, y esto sirve para ayudar al usuario sobre los posibles problemas que podemos enfrentar en nuestro codigo
            // y esto lo hace por medio de una bombilla amarillla que si le damos click, nos desplegara un menu con diferentes opciones de correcion o aclaraciones.
            // este menu tambien aparece cuando escribimos una palabra clave.

            // si escribimos cw y tab nos completara el comando.
            // System.Console.WriteLine();

            // Operadores aritmeticos
            // multiplicacion
            Console.WriteLine(7 * 5);

            // resto o modulo de una division
            Console.WriteLine(9%4);

            // datos tipo double
            Console.WriteLine(5.0/2.0);

            // dato tipo float
            Console.WriteLine(5.00/3.00);

            //Ejemplo de una suma de numeros enteros ingresados por el usuario
            // Console.ReadLine nos sirve para pedir datos al usuario
            Console.WriteLine("Introduce el primer numero");
            int primerNumeroIngresado = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo numero");
            int segundoNumeroIngresado =int.Parse(Console.ReadLine());

            int totalDeSuma = primerNumeroIngresado + segundoNumeroIngresado;

            Console.WriteLine($"La suma de {primerNumeroIngresado} y {segundoNumeroIngresado} es {totalDeSuma}");

            // Constantes
            // en resumen son como las variables pero con la diferencia que su valor no puede cambiar o modificarse de ningun modo.
            // de preferencia van escritas en mayusculas y con el prefijo const antes de asignarle el tipo de dato.
            const int VALOR = 4;
            const int VALOR_DOS = 6;

            Console.WriteLine("El valor de la constante uno es {0} y de la segunda es {1}", VALOR, VALOR_DOS);

            // calculo de un radio con math
            // math es una biblioteca o clase que resguarda sus propias funciones y metodos, en este caso, matematicos.
            // en el intellense de c sharp nos aparecen iconos, el cubo significa funcion o metodo, la lista significa constante

            const double PI = 3.1416;
            System.Console.WriteLine("Introduce la medida del radio");
            double radio = double.Parse(Console.ReadLine());

            double area = Math.Pow(radio, 2)*PI;

            System.Console.WriteLine($"El area del circulo es {area}");

            // Los metodos o funciones.

            // Son sentencias que realizan una tarea en especifico, como dato, los metodos solo funcionan cuando son llamados por el usuario y no por la ejecucion de compilacion de nuestro codigo.
            // tipo_de_dato.nombre_del_metodo(parametros){
                // cuerpo del metodo
            //}
            
            // los parametros son opcionales a la hora de llamar a un metodo, pero siempre hay que colocar unos parentesis.
            // con la palabra void le estamos diciendo a la funcion que no devuelva ningun valor, es decir, con una impresion solo nos muestra el resultado que hagamos, pero no el valor como tal para utilizarlo despues dentro de la funcion.
            // void nunca llevara return en su cuerpo, y viceversa, un metodo normal siempre lleva return, de lo contrario, nos dara un error de compilacion

            // en c sharp tenemos que especificar el tipo de dato que queremos devolver, ya que, el programa nos da el primer dato que le pasemos, ya sea una string, entero, etc.

            // cuando llamamos un metodo desde el main de nuestro programa debemos de escribir su nomnbre y nos parentesis, aparte, tenemos que agregarle static void a la funcion o metodo que queremos llamar.
            System.Console.WriteLine(mensajeEnPantalla());

            // cuando trabajamos con datos primitivos tenemos que especificarlo desde el valor que queremos devolver en la funcion, asi mismo, al menos un parametro tiene que ser del tipo definido anteriormente para poder devolver el tipo de dato que deseamos.
            System.Console.WriteLine(divideNumeros(18,7));

            System.Console.WriteLine(multiplicacionDeNumeros(2,4));

            // si tenemos varios metodos con el mismo nombre pero con diferente construccion, el intellense de visual nos ayudara a escoger que cual metodo queremos, o bien, tambien le podemos pasar el tipo de datos a los parametros que necesite uno de nuestros metodos y automaticamente el programa lo detectara
            System.Console.WriteLine(Resta(8,9));

            // visual code nos ofrece ayuda si no definimos bien un metodo, solo le tenemos que dar click derecho al error y despues nos brinda las posibles soluciones a nuestro problema, cabe aclarar, que la solucion no es siempre como quisieramos que fuera, pero es una alternativa de emergencia.
            // tambien podemos simplificar nuestro metodo en una linea si nos vamos al numero de linea de codigo y le damos a la bombilla o al tornillo y despues le damos a que nos simplifique el metodo.
            // tambien podemos hacer que nos cree un metodo automaticamente con el return de nuestro metodo, esto nos sirve para poder usar el valor que nos devuelve una funcion en algun metodo mas complejo que lo necesite.
            // podemos ejecutar nuestro programa hasta la linea que nosotros deseemos, dandole click derecho a la linea de codigo donde queramos que termine y ejecutandolo hasta ahi, esto se puede hacer para un diagnostico de nuestro programa.

            // ejemplo de parametros opcionales.
            // podemos brindarle un valor por defecto a un parametro dentro de una funcion o metodo, pero no es obligatorio que a la hora de llamarlos o usarlos tengamos que escribir la misma cantidad de parametros, ya que, el parametro que nos sobre ya tendra un valor por defecto.

            int valor1 = 2;
            double valor2 = 4.5;
            double valor3 = 8.5;
            System.Console.WriteLine(multiplicacionOpcional(valor1,valor2));
        }
        // cuando nuestro metodo es llamado en visual studio code nos aparece que tiene n referencias, es decir, las veces en las que fue llamado nuestro metodo
        static void mensajeEnPantalla() {
            System.Console.WriteLine("Mensaje desde el metodo mensaje en pantalla");
        }

        static void sumaDeNumeros(int numeroUno, int numeroDos) {
            System.Console.WriteLine($"La suma es {numeroUno + numeroDos}");
        }

        static int restaDeNumeros(int restaUno, int restaDos) {
            // el return sirve para que nos devuelva un valor y que despues decidamos que hacer con el, ya sea imprimirlo, almacenarlo en una variable, etc.
            // aparte, una vez se llame un metodo con return, el main primero busca el metodo, despues el valor que devuelve el metodo, y lo almacena en la llamada
            return restaUno - restaDos;

            // lo que hay despues de un return no se ejecutara
        }
        static double divideNumeros(double numero1, int numero2) => numero1 / numero2;
        // como dato, todo lo que se encuentra dentro de las llaves de un metodo o funcion, se le denomina ambito, contexto o alcance. y todo lo que declaremos dentro del alcance, solo sera visible en el mismo metodo no fuera de este.
        // esto es un ejemplo de simplificar un metodo que tenga solo una linea de codigo, no es valido si el metodo es mas grande, esto se hace para agilizar la lectura de nuestro codigo
        static int multiplicacionDeNumeros(int mult1, int mult2) => mult1 * mult2;

        void pruebaDeClase() {
            System.Console.WriteLine($"El resultado de la suma es {numeroClaseUno + numeroClaseDos}");
        }

        // A esto se le llama sobrecarga de metodos, podemos crear varios metodos con el mismo nombre, pero no con la misma cantidad de parametros, a no ser, que sean de diferente tipo.
        static int Resta(int resta1, int resta2) => resta1 - resta2;

        static int Resta(int restador1, double restador2) => restador1 - restador2;

        static int Resta(int menos1, int menos2, int menos3) => menos1 - menos2 - menos3;

        // los parametros opcionales siempre deben de ir al final de cada funcion
        static int multiplicacionOpcional(double num1, double num2, double num3=0){
            return num1 * num2 * num3;
        }
    }
}
