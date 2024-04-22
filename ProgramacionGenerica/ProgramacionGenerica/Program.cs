using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionGenerica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // la programacion generica consiste en que todos los elementos de una clase
            // sean del mismo tipo, lo que se le conoce como casting
            // mi almacen de objetos es de 4 elementos

            // pero si al momento de declarar la clase agregamos <T> nos ahorramos el casting
            // porque al momento de inicializar una clase le decimos el tipo de objeto que almacenara en su interior
            // a traves de NombreDeLaClae<TipoDeObjetoQueAlmacenara>
            AlmacenDeObjetos<Empleado> archivosEmpleado = new AlmacenDeObjetos<Empleado>(4);

            // ahora almacena objetos de tipo empleado
            archivosEmpleado.AgregarElementos(new Empleado(1500));
            archivosEmpleado.AgregarElementos(new Empleado(2300));
            archivosEmpleado.AgregarElementos(new Empleado(4200));
            archivosEmpleado.AgregarElementos(new Empleado(6700));

            Empleado salarioDelEmpleado = archivosEmpleado.GetDatosDeElementos(3);
            Console.WriteLine(salarioDelEmpleado.GetSalario());

            // la ventaja de la programacion generica es de que si tenemos un error
            // nos lo mostrara en tiempo de compilacion y no de ejecucion
            AlmacenDeObjetos<String> archivosString = new AlmacenDeObjetos<String>(4);

            // estos eran objetos de tipo string
            archivosString.AgregarElementos("Luis");
            archivosString.AgregarElementos("Marco");
            archivosString.AgregarElementos("Antonio");
            archivosString.AgregarElementos("Daniel");

            // conviertiendo el getter a una string con ToString();
            string nombreDeLaPersona = archivosString.GetDatosDeElementos(2).ToString();

            // lo mismo de arriba pero haciendo un casting
            //nombreDeLaPersona = (String)archivosString.GetDatosDeElementos(2).ToString();

            Console.WriteLine(nombreDeLaPersona);

            AlmacenDeObjetos<DateTime> archivosDeFecha = new AlmacenDeObjetos<DateTime>(4);

            archivosDeFecha.AgregarElementos(new DateTime());
            archivosDeFecha.AgregarElementos(new DateTime());
            archivosDeFecha.AgregarElementos(new DateTime());
            archivosDeFecha.AgregarElementos(new DateTime());

            DateTime fecha = archivosDeFecha.GetDatosDeElementos(2);

            Console.WriteLine(fecha);

            AlmacenDeEmpleados<Director> empleadoDirector = new AlmacenDeEmpleados<Director>(3);

            empleadoDirector.AgregarElementos(new Director(4000));
            empleadoDirector.AgregarElementos(new Director(2000));
            empleadoDirector.AgregarElementos(new Director(1000));

            //empleadoDirector.

            Director director = empleadoDirector.GetEmpleado(0);
            double salario = director.GetSalario();
            Console.WriteLine(salario);

            AlmacenDeEmpleados<Secretaria> empleadoSecretaria = new AlmacenDeEmpleados<Secretaria>(3);

            empleadoSecretaria.AgregarElementos(new Secretaria(4000));
            empleadoSecretaria.AgregarElementos(new Secretaria(2000));
            empleadoSecretaria.AgregarElementos(new Secretaria(1000));

            // cuando intentamos definirle el tipo de objeto a una clase generica que tiene como parametro una interfaz
            // y tipo que le estamos pasando en <TipoDeObjeto> no tiene heredada esa interfaz, no sera posible y nos dara error
            // porque esto sirve para tener una plantilla predifinida para nuestras clases genericas
            
            //AlmacenDeEmpleados<Estudiante> empleadoEstudiante = new AlmacenDeEmpleados<Estudiante>(3);

            //empleadoEstudiante.AgregarElementos(new Estudiante(4000));
            //empleadoEstudiante.AgregarElementos(new Estudiante(2000));
            //empleadoEstudiante.AgregarElementos(new Estudiante(1000));
        }
    }

    // cuando declaramos <T> la clase podra agregar cualquier tipo de objeto
    class AlmacenDeObjetos<T>
    {

        private T[] datosDeElementos;
        private int indice = 0;

        public AlmacenDeObjetos(int cantidadDeElementosParaAlmacenar)
        {
            datosDeElementos = new T[cantidadDeElementosParaAlmacenar];
        }

        public void AgregarElementos(T obj)
        {
            // agregamos elementos de tipo objeto al array con la ayuda del indice
            datosDeElementos[indice] = obj;
            indice++;
        }

        public T GetDatosDeElementos(int indice) 
        {
            // nos devolvera el elemento que este en la posicion
            // que le pasemos como parametro
            return datosDeElementos[indice];
        }

    }

    // creamos una clase generica que tenga como parametro
    // lo que se implemente en la interfaz
    class AlmacenDeEmpleados<T> where T : IParaEmpleados
    {
        private int indice = 0;

        private T[] datosDeEmpleados;

        public AlmacenDeEmpleados(int cantidadDeElementos)
        {
            datosDeEmpleados = new T[cantidadDeElementos];
        }

        public void AgregarElementos(T obj)
        {
            datosDeEmpleados[indice] = obj;
            indice++;
        }

        public T GetEmpleado(int indice)
        {
            return datosDeEmpleados[indice];
        }
    }

    class Empleado
    {
        private double salario;

        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }

    interface IParaEmpleados
    {
        double GetSalario();
    }

    class Director : IParaEmpleados
    {
        private double salario;
        public Director(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }

    class Secretaria : IParaEmpleados
    {
        private double salario;
        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }

    class Electricista : IParaEmpleados
    {
        private double salario;
        public Electricista(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }

    class Estudiante
    {
        private double edad;

        public Estudiante(double edad)
        {
            this.edad = edad;
        }

        public double GetEdad()
        {
            return edad;
        }
    }
}
