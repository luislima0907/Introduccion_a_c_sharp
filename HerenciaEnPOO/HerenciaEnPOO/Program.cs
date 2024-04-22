using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEnPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instanciamos las clases que recibieron herencia de mamiferos y definimos sus
            // parametros de los contructores por defectos para darles un estado inicial
            Caballo miBabieca = new Caballo("Babieca");

            // Con esto hacemos que el objeto caballo a partir de la clase que herda que es mamiferos
            // sea un mamifero terrestre por medio de una interfaz, que seria como los metodos o diractrices que debe tener
            // una clase al momento en que se la heredemos
            IMamiferosTerrestres IMiBabieca = miBabieca;

            Console.WriteLine($"Babieca tiene: {IMiBabieca.NumeroPatas()} patas");

            Humano miHumano = new Humano("Juan");

            Mamiferos miAnimal = new Mamiferos("xd");

            miAnimal = miBabieca;

            Gorila miGorila = new Gorila("Copito");

            // ejemplo del principio de sustitucion, "siempre es un..."
            Mamiferos animal = new Caballo("buz");

            // ejemplo de lo que nos quiere decir POO, todo lo que creemos es un objeto
            Object miPersona = new Humano("Luis");

            // hacemos un array de tipo mamiferos, y si queremos acceder a sus metodos,
            // ubicamos la posicion del objeto junto con su indice
            // y accedemos a los metodos de mamiferos, no de las clases heredadas
            Mamiferos[] almacenDeMamiferos = new Mamiferos[3];

            almacenDeMamiferos[0] = miHumano;

            almacenDeMamiferos[1] = miBabieca;

            almacenDeMamiferos[2] = miGorila;

            for (int i = 0; i < 3; i++) 
            {
                almacenDeMamiferos[i].Pensar();
            }

            // Ejemplo de protected
            //animal.Respirar();

            //miBabieca.NumeroPatas();

            miBabieca.CuidarCrias();

            //miHumano.GetNombreDelSerVivo();

            Carro miCarro = new Carro("Honda", "Rayo");

            Avion miAvion = new Avion("Ua", "mundo");

            miCarro.ConducirElVehiculo();

            miAvion.ConducirElVehiculo();

            // polimorfismo en accion, siempre es un...
            Vehiculo miVehiculo = miCarro;

            miVehiculo.ConducirElVehiculo();

            miVehiculo = miAvion;

            miVehiculo.ConducirElVehiculo();

            Lagartija miLagartija = new Lagartija("Juan");
            miLagartija.Respirar();
            miLagartija.GetNombre();

            Humano miHumanoDos = new Humano("Marco");
            miHumanoDos.Respirar();
            miHumanoDos.GetNombre();
        }
    }

    // las interfaces son los metodos por defecto
    // que debe tener una clase que los herede
    interface IMamiferosTerrestres
    {
        // los metodos de interfaces son siempre publicos
        // y no tienen codigo adentro solo se declara el tipo del metodo
        int NumeroPatas();

        // ademas cuando lo llamemos en una clase que le heredemos la interfaz
        // el metodo tiene que tener el mismo tipo de retorno, mismo nombre y misma cantidad de parametros
    }

    interface IAnimalesYDeportes
    {
        string TipoDelDeporte();

        bool DeporteOlimpico();
    }

    interface ISaltoConPatas
    {
        int NumeroPatas();
    }

    // esta es una clase abstracta, va por encima del nivel de la jerarquia
    // de las clases al momento de heredar, y tiene como minimo un metodo abstracto
    abstract class Animales
    {
        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        // esto es un metodo abstracto, sirven para que las clases abtractas
        // al momento de heredar, la clase que recibio esa heredacion
        // tenga que crear el metodo que declaramos como abstracto
        public abstract void GetNombre();

    }

    class Lagartija : Animales
    {
        private string nombreDelReptil;

        public Lagartija(string nombreDelReptil)
        {
            this.nombreDelReptil = nombreDelReptil;
        }
        public override void GetNombre()
        {
            Console.WriteLine($"El nombre del reptil es: {nombreDelReptil}");
            //throw new NotImplementedException();
        }
    }

    // la clase supercosmica en todas las clases padres que hagamos
    // junto con las otras clases que creamos, siempre la clase superior sera object
    class Mamiferos : Animales // : Object
    {
        private string nombreDelSerVivo;

        public Mamiferos(string nombreDelSerVivo)
        {
            this.nombreDelSerVivo = nombreDelSerVivo;
        }

        // virtual hace que se puedan sobreescribir el metodo de una superclase
        // cuando haga una heredacion
        public virtual void Pensar()
        {
            Console.WriteLine("Pensamiento basico");
        }

        // sobreescribimos el metodo abstracto de la clase abtractos
        public override void GetNombre()
        {
            Console.WriteLine($"El nombre del ser vivo es: {nombreDelSerVivo}");
        }

        // protected lo que hace es que todas las clases que heredan de la superclase
        // puedan usar el metodo o campo de clase, pero no podemos usarlo en una clase que no este heredada
        //protected void Respirar() 
        //{
        //    Console.WriteLine("soy capaz de respirar");
        //}

        public void CuidarCrias()
        {
            Console.WriteLine("cuido de mis crias");
        }
    }

    // con esto se hereda una clase la clase padre mamiferos
    // no podemos heredar varias clases a una, pero si varias interfaces
    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas // esta es la sintaxis para heredar una interfaz para una clase
        // con esto obligamos a añadir los metodos que hayamos definido en la interfaz cuando la heredemos
    {
        // cada vez que instanciemos la clase caballo o una clase que herede una superclase
        // y esa superclase tiene un constructor propio, tenemos que crear un constructor
        // para cada una de las clases heredadas y pasarle minimo un parametro, despues
        // heredamos el constructor de la superclase a las clases heredadas con la palabra reservada :base()
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {

        }

        public string TipoDelDeporte()
        {
            return "Hipica";
        }

        public bool DeporteOlimpico()
        {
            return true;
        }

        // Para referirnos a un metodo de alguna interfaz que le heredemos a una clase
        // debemos poner el nombre de la interfaz y su metodo
        int IMamiferosTerrestres.NumeroPatas()
        {
            return 4;
        }

        int ISaltoConPatas.NumeroPatas()
        {
            return 2;
        }

        public void Galopar()
        {
            Console.WriteLine("soy capaz de galopar");
        }
    }


    class Humano : Mamiferos
    {
        public Humano(string nombreDelHumano) : base(nombreDelHumano)
        {

        }

        // si creamos dos metodos con el mismo nombre, tipo de dato y numero de parametros
        // y recibe una heredacion de una superclase entonces el metodo heredado se ocultara
        // hasta que agreguemos override que significa sobreescribir un metodo
        public override void Pensar()
        {
            Console.WriteLine("soy capaz de pensar");
        }
    }

    class Adolescente : Humano
    {
        public Adolescente(string nombreDelAdolescente) : base(nombreDelAdolescente)
        {

        }

        // un metodo sellado nos impide poder usarlo al momento
        // en el que heredemos esta clase
        public sealed override void Pensar()
        {
            Console.WriteLine("Las hormonas me impiden pensar");
        }

    }

    // podemos sellar una clase con la palabra reservada sealed
    // con esto hacemos que la clase no pueda heredar sus metodos y atrebutos
    class Gorila : Mamiferos, IMamiferosTerrestres
    {
        public Gorila(string nombreDelGorila) : base(nombreDelGorila)
        {

        }

        public int NumeroPatas()
        {
            return 2;
        }

        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        // ejemplo de polimorfismo, poli = muchas, morfismo = formas
        // esto ayuda a que los metodos o propiedades de las clases,
        // se comporten de diferente forma cuando los sobreescribimos con override
        // de un metodo de la superclase en modo virtual
        public override void Pensar()
        {
            Console.WriteLine("pensamiento de instinto gorila");
        }
    }

    class Chimpance : Gorila
    {
        public Chimpance(string nombreDelChimpance) : base(nombreDelChimpance)
        {

        }
    }

    class Ballena : Mamiferos
    {
        public Ballena(string nombreDeLaBallena) :base(nombreDeLaBallena)
        {

        }

        public void Nadar()
        {
            Console.WriteLine("puedo nadar");
        }
    }
}
