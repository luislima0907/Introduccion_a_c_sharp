using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleadoUno = new Empleado(1200, 250);

            empleadoUno.CambiaElSalario(empleadoUno, 100);

            Console.WriteLine(empleadoUno);
        }
    }

    // LIFO = Lost in first out
    // stack almacena valores temporales = LIFO = Lo primero que se almaceno, sale lo ultimo
    // heap almacena valores permanentes durante la ejecucion del programa

    // una struct hace que todo se almacene en la memoria stack
    // de nuestra pc, y eso hace que no tome un valor por refrencia al momento de instanciarla
    // sino mas bien, almacena solo un tipo de dato en una copia interna de la memoria stack
    // en resumen se puede decir que todo lo que hagamos en una estructura no se puede modificar
    // a comparacion de una clase que si se puede modificar
    public struct Empleado
    {
        public double salarioBase;

        public double comision;

        public Empleado(int salarioBase, int comision)
        {
            this.salarioBase = salarioBase;
            this.comision = comision;
        }

        public override string ToString()
        {
            return string.Format($"El salario base es: {this.salarioBase} y la comision es {this.comision}");
        }

        public void CambiaElSalario(Empleado empleado, double incremento) 
        {
            empleado.salarioBase += incremento;
            empleado.comision += incremento;
        }
    }
}
