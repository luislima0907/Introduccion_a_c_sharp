using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// estas importaciones estaticas nos sirven para ahorrar escritura
// a la hora de llamar metodos estaticos de algunas clases,
// pero no es muy recomendable porque puede generar confusion en la declaracion de un codigo muy grande
// siempre es mejor ser lo mas claro posible a la hora de manipular codigo

//using static System.Math;
//using static System.Console;

namespace EjemplosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creacion de una variable que aguarde todos los metodos o propiedades de un objeto o clase
            Circulo oCirculo; // variable de tipo objeto
            
            // Inicializar una variable de tipo objeto en una linea
            Circulo miCirculo = new Circulo(); // con la palabra reservada new, estamos instanciando una clase
            Console.WriteLine(miCirculo.CalcularArea(5));// Ejemplo de la nomenclatura del punto para acceder a las propiedades o metodos de un objeto o clase

            ConversorDeQuetzalADolar obj = new ConversorDeQuetzalADolar();
            Console.WriteLine(obj.ConvierteADolares(10));
            obj.CambiarValorDelQuetzal(2.5);
            Console.WriteLine(obj.ConvierteADolares(4));

            // segundo ejemplo de encapsulacion pero en un constructor
            Carro oCarro = new Carro();
            Console.WriteLine(oCarro.getRuedas()); // de esta manera obtenemos la informacion de una propiedad privada con un metodo getter
            Console.WriteLine(oCarro.getInformacionDelCarro()); // metodo getter que devolvera la informacion del carro en este caso.
            
            Carro oCarroDos = new Carro(7600.2, 3600.5);
            Console.WriteLine(oCarroDos.getInformacionDelCarro());
            Console.WriteLine(oCarroDos.getExtrasDelCarro());

            oCarroDos.setExtrasDelCarro(true, "cuero");
            Console.WriteLine(oCarroDos.getExtrasDelCarro());

            RealizarUnaTarea();

            // declaracion de una clase anonima, creamos el una instancia vacia en las llaves, y adentro definimos sus atributos
            var miClaseAnonima = new { Nombre = "Luis", Edad = 18};

            Console.WriteLine($"Mi nombre es: {miClaseAnonima.Nombre} y tengo la edad de: {miClaseAnonima.Edad}");

            var miOtraClaseAnonima = new { Nombre = "Marco", Edad = 30 };

            Console.WriteLine($"Mi nombre es: {miOtraClaseAnonima.Nombre} y tengo la edad de: {miOtraClaseAnonima.Edad}");

            // se pueden almacenar clases anonimas solo si son del mismo tipo, cantidad y orden de los atributos
            miClaseAnonima = miOtraClaseAnonima;

            //double raiz = Sqrt(9);

            //double potencia = Pow(3, 3);

            //WriteLine($"raiz: {raiz} y potencia: {potencia}");

            //Console.Read();
        }

        static void RealizarAlgo()
        {
            // Este tipo de comentarios TODO, nos sirven para colocar un punto de control en nuestro programa
            // y asi poder recordarnos de las tareas pendientes que tenemos en nuestro programa cuando queramos retomarlo
            // TODO:
        }

        static void RealizarUnaTarea()
        {
            // esta instancia devolvera el objeto punto, con el estado de 0 en sus coordenadas
            Punto origen = new Punto(); // el constructor de una clase por defecto, siempre no tiene ningun parametro
            
            // en cambio esta instancia, devolvera el objeto pero iniciado en 128 y 80.
            Punto destino = new Punto(128, 80);

            // Punto.contadorPrueba; // las variables y metodos estaticos, solo se pueden llamar a traves del nombre de la clase

            // la distancia entre los puntos es igual a: la variable de tipo objeto origen
            // llamando a su metodo DistanciaHasta que pertenece a su clase Punto
            // Y como ese metodo recibe como parametro dos numeros, le pasamos la variable de tipo
            // objeto destino, que almacena la instancia de los dos puntos, gracias al segundo constructor
            double DistanciaEntreLosPuntos = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre los puntos es de: {DistanciaEntreLosPuntos}");

            // ejemplo de lo que es un metodo con variable estatica
            Console.WriteLine($"Numero de objetos creados con una variable estatica: {Punto.ContadorDeObjetos()}");
        }
    }

    // internal se refiere a que solo se puede usar en un mismo ensamblado
    class Circulo // cuando no ponemos modificador de acceso en una clase o propiedad, su valor por defecto sera interno o privado
    {
        // Campos de clase = declarar sus propiedades y metodos

        // Ejemplo de encapsulacion con private
        // hacemos privada la propiedad para no poderla modificar, y una constante para que su valor se mantenga
        private const double pi = 3.1416; // propiedad de la clase circulo

        // este es un comportamiento del circulo
        public double CalcularArea(int radio) // metodo de clase. Que pueden hacer los objetos de tipo circulo
        {
            return pi * radio * radio;
        }
    }

    class ConversorDeQuetzalADolar
    {
        private double quetzal = 7.5;

        public double ConvierteADolares(double cantidadDeDolares)
        {
            return cantidadDeDolares * quetzal;
        }

        // creamos un metodo de acceso para una propiedad privada
        public void CambiarValorDelQuetzal(double nuevoValorDelQuetzal)
        {
            if (nuevoValorDelQuetzal < 0) quetzal = 7.5;
            else quetzal = nuevoValorDelQuetzal;
        }
    }

    // partial, nos sirve para dividir o modular nuestrar clases en c#, haciendo mas legibles porque las dividimos por trosos
    // es decir, en un partial de la clase, colocamos solo los metodos, en otro partial class, solo colocamos las propiedades etc
    partial class Carro
    {
        private int ruedas;

        private double largo;

        private double ancho;

        private bool climatizador; // el valor por defecto de un booleano siempre es false

        private string tapiceria; // el valor por defecto de una string siempre es vacio

        // ejemplo de constructor, no devuelve ningun valor, solo es el elemento que nos permite decirle al objeto
        // como estara construido internamente antes de poderlo usar o modificar
        public Carro() // le da un estado inicial al objeto carro
        {
            ruedas = 4;
            tapiceria = "Tela";
            largo = 2300.5;
            ancho = 0.800;
        }

        // ejemplo de sobrecarga de constructores, esto sirve al momento de instanciar una clase
        // podemos definir que tipo de parametros o estado inicial tendra nuestro objeto
        public Carro(double largo, double ancho)
        {
            ruedas = 4;
            tapiceria = "Tela";
            this.largo = largo;
            this.ancho = ancho;
        }
    }

    // segunda parte de la clase, contiene sus metodos
    partial class Carro 
    {
        // este es un metodo getter, que se denominan asi a los metodos que se utilizan para acceder a propiedades privadas de un objeto
        public int getRuedas()
        {
            return ruedas;
        }

        public string getInformacionDelCarro()
        {
            return $"Informacion del Carro:\n Ruedas: {ruedas} Largo: {largo} Ancho: {ancho}";
        }

        // este es un metodo setter, que sirve para establecer un valor a las propiedades
        public void setExtrasDelCarro(bool climatizador, string tapiceria)
        {
            // con la palabra reservada this, nos ayuda a hacer referencia a un campo de clase, es decir, a la propiedad de una clase
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }

        // la diferencia entre un metodo set y uno get, es que el get, solo obtiene un valor y en cambio set establece un valor
        public string getExtrasDelCarro()
        {
            return $"Los extras del Carro son:\n Climatizador: {climatizador} Tapiceria: {tapiceria}";
        }
    }
}
