using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDeInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico avisoUno = new AvisosTrafico();
            IAvisos aviso = avisoUno;

            aviso.MostrarAviso();

            AvisosTrafico avisoDos = new AvisosTrafico("Luis", "Hola mundo", "hoy");

            Console.WriteLine(avisoDos.GetFecha());
            //Console.WriteLine(aviso.GetFecha());
        }
    }
}
