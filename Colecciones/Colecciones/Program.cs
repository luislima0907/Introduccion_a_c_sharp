using System;

// para importar las listas en c# se utiliza esto
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BUSCAR E INVESTIGAR EN LA LIBRERIA DE .NET

            // un diccionario trabaja con clave y valor, asi que tenemos que definirle el tipo
            // de clave y el tipo de valor que va a almacenar
            Dictionary<string, int> personas = new Dictionary<string, int>();

            // Rellenar el diccionario
            // add lo que hace es rellenar el diccionario con el tipo de clave y valor que definimos
            personas.Add("Luis", 18);
            personas.Add("Carla", 20);
            personas.Add("Luisa", 28);

            personas["Maria"] = 12;
            personas["Juan"] = 10;

            //recorrer el diccionario por medio de su clave y valor
            foreach(KeyValuePair<string, int> persona in personas)
            {
                Console.WriteLine($"Nombre: {persona.Key} Edad: {persona.Value}");
            }

            // stack es lo contrario del queue, utiliza lifo
            // lifo = last in first out el ultimo en entrar es el primero en salir
            Stack<int> stacks = new Stack<int>();

            // Rellenando elementos a un stack
            foreach (int stack in new int[5] { 1, 2, 3, 4, 5 })
            {
                stacks.Push(stack);
            }

            // recorriendo el stack
            Console.WriteLine("recorriendo stack");

            foreach (int Stack in stacks)
            {
                Console.WriteLine(Stack);
            }

            //eliminando elementos del stack
            Console.WriteLine("Eliminando");
            stacks.Pop(); // este metodo elimina el ultimo elemento que entro al stack

            foreach (int stacK in stacks)
            {
                Console.WriteLine(stacK);
            }


            // Queue es una especie de cola, funciona en base a Fifo
            // fifo = First in First Out
            // en resumen el primer elemento que se agregue a la cola
            // cuando lo eliminemos o ya no lo necesitemos pues que pase al siguiente
            Queue<int> numeross = new Queue<int>();
            //numeross.Enqueue(1);

            foreach(int numerosss in new int[5] { 1, 2, 3, 4, 5})
            {
                numeross.Enqueue(numerosss);
            }

            Console.WriteLine("recorriendo queue");

            foreach(int nUmero in numeross)
            {
                Console.WriteLine(nUmero);
            }

            // eliminando elementos de una cola
            Console.WriteLine("Eliminando");
            numeross.Dequeue(); // este metodo elimina el primer elemento que entro a la cola

            foreach(int nUmero in numeross)
            {
                Console.WriteLine(nUmero);
            }


            LinkedList<int> numero = new LinkedList<int>();

            // por cada numero que nos encontremos en el array 
            // que lo agregue al primer elemento de la linkedlist
            foreach(int Numero in new int[] {10,8,6,4,2,0})
            {
                // addfirst guarda en la primera posicion el elemento de una lista
                // y si tiene otro, recorre el que ya estaba y pone el ultimo agregado como el primero
                numero.AddFirst(Numero);
            }

            // remove lo que hace es remover de la linkedlist
            // el valor del elemento que le pasemos por parametro
            numero.Remove(10);

            // este es el otro constructor del linkedlistnode, almacena un valor segun que parametro y tipo de dato hayamos ingresado
            LinkedListNode<int> nodoImportante = new LinkedListNode<int>(12);
            numero.AddFirst(nodoImportante);

            // en un for creamos una linkedlistnode de tipo entero, que
            // se encargara de almacenar el primer elemento de la linkedlist anterior
            // y mientras nodo sea diferente de nulo o que ya no tenga elementos por leer
            // entonces que pase al siguiente nodo
            for(LinkedListNode<int> Nodo = numero.First; Nodo != null; Nodo = Nodo.Next) 
            {
                // guardamos los numeros de la linkedList
                int numerO = Nodo.Value;

                // imprimimos los valores
                Console.WriteLine(numerO);
            }

            foreach (int Numero in numero) 
            {
                Console.WriteLine(Numero);
            }

            List<int> numeros = new List<int>(); // declaramos una lista

            Console.WriteLine("Introduce elementos en la coleccion (0 para salir)");

            int elemento;

            do
            {
                elemento = int.Parse(Console.ReadLine());
                numeros.Add(elemento);
            }
            while (elemento != 0);

            // remoteAt remueve el ultimo elemento de una lista
            // el count nos devuelve la canitdad de elementos de una lista
            // pero sin tener en cuenta el indice
            numeros.RemoveAt(numeros.Count - 1);

            Console.WriteLine("Elementos introducidos: ");
            foreach (int elementos in numeros) 
            {
                Console.WriteLine(elementos);
            }

            //Console.WriteLine("Cuantos elementos quieres introducir?");

            //int contador = 0;

            //int cantidadDeElementos = int.Parse(Console.ReadLine());

            //// para recorrer una lista se usa el metodo Count
            //for(int i = 0; i < cantidadDeElementos; i++)
            //{
            //    Console.WriteLine($"Escriba el elemento {contador++}");
            //    numeros.Add(int.Parse(Console.ReadLine()));
            //}

            //for(int i = 0; i < numeros.Count;i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}

            //int[] listaDeNumeros = new int[] {2,3,4,5};

            //// este for almacena los elementos que contiene el array a una lista
            //// para recorrelos en el array

            // para recorrer los arrays se usa el metodo length
            //for (int i = 0; i < listaDeNumeros.Length; i++) 
            //{
            //    numeros.Add(listaDeNumeros[i]);
            //}

            //// este segundo for recorre e imprime los elementos de la lista numeros
            
            //for (int i = 0; i < numeros.Count; i++) 
            //{
            //    Console.WriteLine(numeros[i]);
            //}
        }
    }
}
