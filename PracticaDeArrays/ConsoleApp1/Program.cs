using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDeArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaramos un array despues del tipo de dato int[]
            int[] edades; // el valor por defecto de un int es 0
            edades = new int[4]; // inicializamos el array con new y entre corchetes ponemos cuantos elementos tendra

            // asignacion de elementos al array, segun su indice
            edades[0] = 15;
            edades[1] = 27;
            edades[2] = 19;
            edades[3] = 80;

            // si intentamos asignar un valor mas del que permite el array da error o excepcion

            // creacion de un array y asignacion de elementos en la misma linea
            string[] nombres = { "Luis", "Marco", "Josue" };

            // array implicito
            // var nos permite crear una variable o array y segun lo que le asignemos primero, entonces tomara ese tipo de valor
            var datos = new[] { "Juan", "Diaz", "Guatemala" };

            var valores = new[] { 15, 20 }; // este array almacena el tipo de dato int

            // Bucle for pero para complicarse la vida XD
            int contador = 0; // iniciamos en 0 nuestro contador para leer el indice del array

            for (int i = 15; i >= 14; i--) // este for itera los elementos de mi array valores 
            {
                // la variable contador va adentro del indice de mi array valores,
                // por ejemplo cuando contador sea 0, entonces imprimira el primer elemento del array.
                // luego en la otra vuelta del bucle contador ya no va a ser 0,
                // sino 1, entonces imprimira el segundo elemento del array y asi suscesivamente.
                Console.WriteLine(valores[contador]);
                contador++; // incrementamos el valor de contador en uno para la siguiente vuelta del for
            }


            // Ejemplo de bucle for
            // iniciamos la variable i en 0, i hace referencia a index que es el indice del array
            // luego lee la condicion, i <= tamaño del array(valores.Length) y si la condicion es verdad entonces la variable i incrementa en uno
            // despues de leer y devolver el resultado de la condicion mientras sea verdadera entonces, el for ejecutara lo de adentro

            for (int i = 0; i < valores.Length; i++) // le decimos menor o igual a uno para hacer referencia a los indices del array
            {
                // la variable i va adentro del indice, porque por ejemplo cuando i sea 0, entonces imprimira el primer elemento del array.
                // luego en la otra vuelta del bucle i ya no va a ser 0, sino 1, entonces imprimira el segundo elemento del array y asi suscesivamente.
                Console.WriteLine(valores[i]);
            }

            // array de objetos

            Empleados Luis = new Empleados("Luis", 18); // instanciamos la clase empleados y le damos parametros al constructor para almacenarlos en la variable Luis

            Empleados[] listaDeEmpleados = new Empleados[2]; // Creamos un array de tipo objeto(Empleados), despues lo instanciamos y le decimos entre corchetes cuantos elementos va a almacenar dentro del array

            listaDeEmpleados[0] = new Empleados("Fernan", 20); // como Empleados solo tiene el constructor de nombre y edad toma ese por defecto y eso lo almacenara en la posicion 0 del array

            listaDeEmpleados[1] = Luis; // almacenamos en la posicion 1 del array el objeto Luis que creamos a partir de la clase Empleados

            // de esta manera iteramos el objeto de una clase
            for(int i = 0; i < listaDeEmpleados.Length; i++)
            {
                // para iterar el objeto de una clase, tenemos que crear un metodo que nos den
                // los atributos que tiene la clase pero sin poderlos modificar
                Console.WriteLine(listaDeEmpleados[i].getInformacionDelEmpleado());
            }

            // Ejemplo del foreach
            // este sirve para iterar objetos, es decir si tenemos un array de tipo int, entonces almacena objetos enteros
            // de tipo Int, si tenemos una clase llamada empleados, entonces almacenara objetos de tipo empleados
            // ademas tenemos que crear una variable despues del objeto para almacenar sus valores en la iteracion
            // lo que hace in, es de que recorre el array que le pasemos despues es decir, escribamos el nombre del array
            //
            foreach(Empleados iteradorDeEmpleados in listaDeEmpleados)
            {
                Console.WriteLine(iteradorDeEmpleados.getInformacionDelEmpleado());
            }

            // arrays de tipos o clases anonimas

            // creamos un array con var para no asignarle un tipo de valor especifico
            var personas = new[]
            {
                // almacenamos clases anonimas u objetos en las posiciones del array
                // todos los elementos de una clase anonima dentro de un array siempre tienen que tener el mismo tipo de dato, orden y cantidad de elementos
                new {Nombre = "Juan", Edad = 19},
                new {Nombre = "Maria", Edad = 49},
                new {Nombre = "Diana", Edad = 35}
            };

            foreach(var listaDePersonas in personas)
            {
                Console.WriteLine(listaDePersonas);
            }

            //Console.WriteLine(personas[1]);

            int[] numeros = { 4, 2, 9, 10};

            ProcesarLosDatos(numeros);

            // una vez hecha la suma de 10 en cada elemento, imprimimos nuevamente
            // los elementos del array numeros con la nueva informacion
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }

            int[] arrayElementos = LeerDatos();

            Console.WriteLine("Desde el main");
            foreach (int i in arrayElementos)
            {
                Console.WriteLine(i);
            }
        }

        static void ProcesarLosDatos(int[] datos)
        {
            // diferencia entre el for y foreach
            // for sirve para iterar, modificar e imprimir elementos del array
            // pero el foreach solo puede imprimir, no los puede modificar
            for(int i = 0; i < datos.Length;i++)
            {
                // aqui estamos diciendo que todos los elementos del array
                // que le pasamos como parametro a este metodo, les sume 10
                datos[i] += 10;
            }
        }

        // Ejemplo de un array dinamico
        static int[] LeerDatos()
        {
            // preguntamos por consola cuantos elementos quiere en el array
            Console.WriteLine("Cuantos elementos quieres en el array");
            int respuesta = int.Parse(Console.ReadLine()); // convertimos la respuesta a entero

            int numeroDeElementos = respuesta;
            // le damos como parametro al numero de elementos al array datos
            // la respuesta con el numero que nos pase el usuario
            int[] datos = new int[numeroDeElementos];

            for(int i = 0; i < numeroDeElementos; i++)
            {
                Console.WriteLine("Introduce el dato en tu array");
                // almacenamos el tipo de dato para el array
                respuesta = int.Parse(Console.ReadLine());
                int datosElemento = respuesta;
                // usamos i para los indices y almacenamos los datosElemento en el indice del array
                // que le toca en el for
                datos[i] = datosElemento;
            }
            return datos;
        }
    }

    class Empleados
    {
        private string nombre;
        private int edad;
        public Empleados(string nombre, int edad) 
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        // hacemos un metodo getter para conseguir la informacion de las variables de la clase
        // y poder saber que contienen con un bucle for mas adelante
        public string getInformacionDelEmpleado()
        {
            return $"El nombre del empleado es: {nombre} y su edad es: {edad}";
        }
    }
}
