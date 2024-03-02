using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOOCSharp
{
    public class Leon : carnivoro
    {
        // esta variable se puede modificar dentro de un set y get
        private int velocidad = 20;
        public string color {  get; set; }

        // sobreescribir un metodo
        public override string GetNombre()
        {
            // esto devolvera cuando se llama en leon y no en animal
            return $"Soy un leon llamado: {nombre}";
        }

        // ejemplo de como usar el get y set

        public int Velocidad
        {
            get
            {
                return velocidad;
            }
            set
            {
                if (velocidad == 0) Console.WriteLine("La velocidad no puede ser 0");
                // value sirve para asignarle un valor por defecto, esto depende si la variable ya ha sido declarada con un tipo de dato con anterioridad
                velocidad = value;
                Console.WriteLine($"La velocidad del leon es {velocidad}");
            }
        }
        // metodo de get para una variable privada de la misma clase
        public int calcularVelocidad
        {
            get
            {
                return velocidad * 1000;
            }
        }

        // este es el constructor de la clase
        public Leon(int velocidad, string color)
        {
            // el this.nombreDelAtributo es para hacer referencia al atributo de la clase
            this.velocidad = velocidad;
            // y lo que va despues del igual o asignacion es el parametro del constructor
            this.color = color;
        }



        // ejemplo de sobrecarga
        // una sobrecarga consiste en poner varios metodos con el mismo nombre pero con diferentes cuerpos o parametros que los diferencien

        public void Correr(string lugar)
        {
            Console.WriteLine($"El leon corrio hasta: {lugar}");
        }
        public void Correr()
        {
            Console.WriteLine("Esta corriendo el leon");
        }

        public void Correr(int velocidad)
        {
            Console.WriteLine($"El leon corrio: {velocidad}km");
        }
    }
}