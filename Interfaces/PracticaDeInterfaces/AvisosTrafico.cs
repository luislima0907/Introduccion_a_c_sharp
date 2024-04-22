using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDeInterfaces
{
    internal class AvisosTrafico : IAvisos
    {

        public AvisosTrafico() 
        {
            this.remitente = "DGT";
            this.mensaje = "Sancion cometida: multa de 1000 por exceso de velocidad";
            this.fecha = "";
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }

        public string GetFecha()
        {
            return fecha;
        }

        string IAvisos.GetFecha()
        {
            return this.fecha;
        }

        void IAvisos.MostrarAviso()
        {
            Console.WriteLine($"Mensaje {mensaje} ha sido enviado por {remitente} el dia {fecha}");
        }

        private string remitente;
        private string mensaje;
        private string fecha;

    }
}
