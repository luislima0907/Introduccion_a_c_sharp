using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosPOO
{
    // una clase internal, se puede instanciar en el mismo proyecto, pero si creamos otro proyecto
    // e intentamos instanciar la clase, entonces nos dara error porque ya pertenece a otro ensamblado
    internal class Punto
    {
        // Ejemplos de variables o propiedades estaticas
        private static int contadorDeObjetos = 0; // una variable o metodo estatico no se puede modificar en otra clase porque siempre
        // tendra el mismo valor en cualquiera de los objetos que en esta se instancia

        // ejemplo de una constante estatica, no es necesario poner static a una constante, ya que su valor no se puede cambiar de ninguna forma
        public const int contadorPrueba = 1;

        // podemos declarar dos o mas variables separadas por una coma
        private int x, y;

        // si nosotros solo creamos un constructor, y ese contructor tiene parametros
        // entonces agarrara ese por defecto
        public Punto(int coordenadaX, int coordenadaY) 
        {
            // this hereda todos los campos de clase de una clase u objeto
            this.x = coordenadaX;
            this.y = coordenadaY;
            contadorDeObjetos++; // incrementamos en uno la variable
            Console.WriteLine($"Coordenada en X: {coordenadaX}, Coordenada en Y: {coordenadaY}");
        }

        public Punto() 
        {
            this.x = 0;
            this.y = 0;
            contadorDeObjetos++;
            Console.WriteLine("Este es el constructor por defecto");
        }

        public double DistanciaHasta(Punto otroPunto) // recibimos un objeto como parametro, en este caso Punto
        {
            // almacenamos en una variable entera el resultado de this.x, que hace referencia a la propiedad de la misma clase punto, que en este caso su valor es 0
            // y luego le restamos la x que guardemos en el objeto del Punto que pasamos como parametro, en este caso, los valores que le pasemos a los puntos al momento de instanciar la clase Punto en el Main
            int diferenciaEnX = this.x - otroPunto.x;
            int diferenciaEnY = this.y - otroPunto.y;

            // hacemos el teorema de Pitagoras con la clase estatica Math, junto con sus metodos estaticos Sqrt y Pow
            double distanciaEntreLosPuntos = Math.Sqrt(Math.Pow(diferenciaEnX, 2) + Math.Pow(diferenciaEnY, 2));

            // devolvemos el resultado del teorema de pitagoras
            return distanciaEntreLosPuntos;
        }

        // hacemos este metodo estatico para poderlo llamar fuera de la clase
        public static int ContadorDeObjetos() => contadorDeObjetos; // si nuestro metodo solo tiene una linea de codigo, podemos usar esta notacion para simplificarlo
    }
}
