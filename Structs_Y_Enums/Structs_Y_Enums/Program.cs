using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_Y_Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estaciones? alergiaDos = null;

            Estaciones alergia = Estaciones.Primavera;

            string laAlergia = Estaciones.Primavera.ToString();

            Console.WriteLine(alergia);

            Console.WriteLine(laAlergia);

            Bonus Luis = Bonus.Bueno;

            // hacemos un casting para acceder al valor real del enum
            // y no a su nombre de la constante
            double bonusLuis = (double)Luis;

            // asi modificamos el valor de un enum
            double salarioLuis = 1500 + bonusLuis;

            Console.WriteLine(salarioLuis);

            Empleado Luisa = new Empleado(Bonus.Extra, 1300.50);

            Console.WriteLine($"El salario es de: {Luisa.GetSalario()}");

        }
    }

    class Empleado
    {
        private double salario;
        private Bonus bonusEmpleado;
        public Empleado(Bonus bonusEmpleado, double salario)
        {
            this.bonusEmpleado = bonusEmpleado;
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario + (double)bonusEmpleado;
        }
    }

    // esta es una declaracion de un enum, que los valores que tiene
    // dentro son constantes que no se pueden modificar y que el nombre
    // que tienen inician con un entero
    enum Estaciones { Primavera, Verano, Otoño, Invierno}

    // tambien les podemos asignar valores por defecto en las constantes de los enums
    enum Bonus { Bajo = 500, Normal = 1000, Bueno = 1500, Extra = 3000}

}
