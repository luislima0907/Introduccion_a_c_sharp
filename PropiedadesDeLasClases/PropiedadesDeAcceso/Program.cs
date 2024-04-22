using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadesDeAcceso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado miEmpleado = new Empleado("Luis");

            // esta es la utilidad de las propiedades encapsuladas o privadas
            // podemos modificarla como si fuera una variable normal pero
            // tambien podemos brindarle sus restricciones como es en este caso
            // de que el salario no puede ser negativo por que devuelve 0

            //miEmpleado.SALARIO = 1200;

            //miEmpleado.SALARIO += 700;

            miEmpleado.SALARIO = -4000;

            Console.WriteLine($"El salario del empleado es: {miEmpleado.SALARIO}");

            //miEmpleado.SetSalario(2000);
            //Console.WriteLine($"El salario del empleado es: {miEmpleado.GetSalario()}");
        }
    }

    class Empleado
    {
        // los campos de clase privados podemos
        // definirlos asi: _nombreDelCampo, a la hora
        // de llamarlo con el menu inteligence no nos aparecera
        // y deberemos escribirlo nosotros,
        // esto sirve para diferenciar un campo de clase
        // de una propiedad
        private string _prueba;

        private string nombre { get; set; }

        private double salario { get; set; }

        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }

        private double evaluarElSalario(double salario)
        {
            if (salario < 0) return 0;
            else return salario;
        }

        // Creacion de una propiedad de la clase
        // para acceder a un campo de clase privado debemos de
        // hacer una propiedad publica  con el tipo de dato que duelva el campo de clase
        // luego con get que es conseguir en ingles, recuperamos el valor del campo de clase que tenemos en privado
        // y ya despues con set, que es establecer en ingles, modificamos su valor inicial
        
        public double SALARIO // mismo metodo que el de abajo pero con la escritrua langba
        {
            // get nos indica que sera una propiedad de solo lectura
            get => this.salario;

            // set nos indica que sera una propiedad de solo escritura
            set => this.salario = evaluarElSalario(value);
        }
        
        //public double SALARIO
        //{
        //    get { return this.salario; }

        //    set { this.salario = evaluarElSalario(value); }

        //}

        //public double GetSalario()
        //{
        //    return salario;
        //}

        //public void SetSalario(double salario)
        //{
        //    if (salario < 0)
        //    {
        //        Console.WriteLine("El salario no puede ser negativo, se asignara 0 como salario");
        //        this.salario = 0;
        //    }
        //    else
        //    {
        //        this.salario = salario;
        //    }
        //}
    }
}
