using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosPredicadosYLambdas
{
    internal class Program
    {
        // definicion del objeto delegado
        delegate void ObjetoDelegado(string nombre);

        public delegate int OperacionesMatematicas(int numero);

        public delegate bool ComparaPersonas(int edadUno, int edadDos);
        static void Main(string[] args)
        {
            // creamos un objeto delegado apuntando la tarea de la clase y su metodo al saludo bienvenida
            ObjetoDelegado elDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoDeBienvenida);
            elDelegado("Luis");

            elDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDeDespedida);
            elDelegado("Marco");

            List<int> listaDeNumeros = new List<int>();
            // addrange permite agregar mas de un valor a una lista
            listaDeNumeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, });

            // declaramos delegado predicado
            // un predicado devuelve true o false, y se almacena en una lista de tipo generica
            // que a su vez es predicate, y de ultimo en el constructor le pasamos el metodo que queremos evaluar
            // tambien tiene que ser booleano
            Predicate<int> delegadoPredicado = new Predicate<int>(DameLosNumerosPares);

            // para almacenar las coincidencias que encuentre el metodo findall tenemos que crear
            // una lista del mismo tipo y pasarle como parametro el delegado que creamos
            List<int> numerosPares = listaDeNumeros.FindAll(delegadoPredicado);

            // iteramos la lista con las coincidencias encontradas en el predicado
            foreach(int numero in numerosPares)
            {
                Console.WriteLine(numero);
            }

            List<Personas> gente = new List<Personas>();
            Personas personaUno = new Personas();
            personaUno.Nombre = "Luis";
            personaUno.Edad = 18;

            Personas personaDos = new Personas();
            personaDos.Nombre = "Maria";
            personaDos.Edad = 28;

            ComparaPersonas compararEdad = (personaUnos, personaDoss) => personaUno == personaDos;
            Console.WriteLine(compararEdad(personaUno.Edad, personaDos.Edad));

            // uso de un delegado con expresion lambda
            // lambda = (zona de parametros) =>(simbolo lambda) (operacion con esos parametros)
            OperacionesMatematicas operacion = new OperacionesMatematicas((Numero) => Numero * Numero);
            Console.WriteLine(operacion(4));

            List<int> numeros = new List<int> { 1,2,3,4,5,6 };
            List<int> numerosParess = numeros.FindAll(i => i % 2 == 0);

            foreach(int numero in numerosParess)
            {
                Console.WriteLine(numero);
            }

            // forma de simplificar el foreach con expresiones lambda
            numerosParess.ForEach(numero => {
                Console.WriteLine("El numero par es: ");
                Console.WriteLine(numero); }); // si queremos agregar mas de una linea de codigo
            // a una expresion lambda entonces encerramos cada sentencia entre las llaves y terminamos con punto y coma


            gente.AddRange(new Personas[] { personaUno, personaDos });

            Predicate<Personas> delegadoDePersonas = new Predicate<Personas>(ExisteLuis);
            bool existe = gente.Exists(delegadoDePersonas);

            if (existe) Console.WriteLine("Hay un luis");
            else Console.WriteLine("no hay luis");
        }

        // FUNCION NORMAL
        //public static int Cuadrado(int numero)
        //{
        //    return numero * numero;
        //}


        static bool ExisteLuis(Personas persona)
        {
            if (persona.Nombre == "Luis") return true;
            else return false;
        }

        static bool DameLosNumerosPares(int numeroAEvaluar)
        {
            if (numeroAEvaluar % 2 == 0) return true;
            else return false;
        }
    }

    class Personas
    {
        private string nombre;
        private int edad;

        public string Nombre { get { return nombre; } set { nombre = value; } }

        public int Edad { get { return edad; } set { edad = value; } }
    }

    class MensajeBienvenida
    {
        public static void SaludoDeBienvenida(string nombre)
        {
            Console.WriteLine($"Bienvenidos a todos, como estas {nombre}");
        }
    }

    class MensajeDespedida
    {
        public static void SaludoDeDespedida(string nombre)
        {
            Console.WriteLine($"Adios {nombre}");
        }
    }

}
