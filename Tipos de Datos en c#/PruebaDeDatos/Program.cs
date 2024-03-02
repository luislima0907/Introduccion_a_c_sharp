// la palabra reservada using nos permite importar clases de los elementos u objetos de c sharp, o bien, los metodos de igual forma, con using system estamos importando todas las clases de system y las incluye al namespace
using System;
using System.Net.Http.Headers;

namespace PruebaDeDatos // el namespace es un agrupador de clases, la primera clase que se ejecuta siempre es el Main class o class program
{
    class Program
    {
        // para invocar una funcion debemos de escribir su Nombre(parametroUno, ParametroDos)
        // en los lenguajes se utiliza mucho la identacion para ordenar mejor el codigo

        // modificador de acceso, tipo de retorno, nombre del metodo(tipo parametroUno, tipo ParametroDos) {cuerpo del metodo}
        static void Main(string[] args) // tambien se le conoce como entry point y es el primer metodo que se ejecuta en nuestro programa
        {
            // dentro del main o cualquier metodo se le conoce como seccion de sentencias que pueden iniciar declaraciones de cualquier elemento de c sharp
            // para determinar el alcance de un metodo o elemento en c sharp, tenemos que ver la llave de apertura y de cierre, estaran identificadas con un color {}

            // el byte almacena hasta el numero entero 255, pero solo del lado positivo
            // byte es igual a un byte
            byte numero = 255; // las sentencias o declaraciones se terminan con punto y coma ;

            // con la letra s decimos que la capacidad que guarda la cantidad de una palabra clave para declarar el tipo de dato, se reduzca a la mitad, tanto en negativos como en positivos
            sbyte numeroDos = 127;

            // short es igual a dos bytes
            short numeroOpcional = 90;

            // int permite valores positivos y negativos
            // int es igual a tres bytes
            int numeroTres = 12;

            // uint solo permite numeros positivos del tipo int
            uint numeroCuatro = 8;

            // ulong solo permite numeros positivos, y el long se utiliza para cantidades exageradamente grandes
            ulong numeroCinco = 900;

            // long normal permite tanto negativos como positivos dentro de su rango
            // long es igual a ocho bytes
            long numeroSeis = 0120102;

            // datos de float
            // el float es de cuatro bytes y tenemos que indicarle con una f al final del decimal para decir que es un flotante o numero con decimal
            float numeroSiete = 89.8f;

            // el double es exactamente igual al float solo que ocupa ocho bytes y se escribe d en lugar de f
            double numeroOcho = 78.9d;

            //tipos decimal
            // lo mismo que lo anterior solo que con m al final, y este es de dieciseis bytes
            decimal numeroNueve = 78.7m;

            // tipos char
            // este char es de dos bytes y se escribe dentro de comillas simples porque si usamos las dobles se convierte en una string
            char seccion = 'A';

            // tipo compuesto de char
            // esta string se escribe en comillas dobles y puedes guardar todas las letras que quieras
            string cadena = "Hola Mundo";

            // tipo de objeto
            // DateTime es una clase u objeto que contiene metodos, debemos guardar en una variable todos los metodos que contenga esa clase antes de poder usarla
            DateTime fecha = DateTime.Now;

            // tipo booleano
            // los booleanos guardan verdadero y falso, o tambien not
            bool siONo = true;

            // podemos saber el valor por defecto de un int declarando una instancia al objeto int, y si queremos imprimirlo lo pasamos a una string
            int numeroCero = new int();
            Console.WriteLine(numeroCero.ToString());

            // con el signo de interrogacion hacemos que la variable de cualquier tipo, no tenga un valor en especifico
            int? numeroCeroDos = null;
            Console.WriteLine(numeroCero.ToString());

            // var en c sharp
            // var en c sharp solo funciona dentro del main porque opera en local
            // lo que hace var es hacer una declaracion de una variable y el primer tipo de dato que le iniciemos a la misma, lo tomara el resto del programa, por ejemplo aqui toma un string, asi que no puede tomar un int mas adelante por ejemplo
            var nombre = "Luis";

            // crear una clase u objeto sin necesidad de crear una clase en otro archivo
            // este no se puede llamar por medio de un metodo como las clases normales, este tiene un uso mas especifico u anonimo
            object persona = new { nombre = "Luis", apellido = "Lima" };

            // creamos un objeto anonimo
            var personaDos = new { nombre = "Carlos", apellido = "Perez" };
            Console.WriteLine(personaDos.apellido);

            // operadores ternarios
            int edad = 18;
            int menorEdad = 15;

            edad = int.Parse(menorEdad < 18 ? "Eres mayor" : "Eres menor");
        }
    }
}
