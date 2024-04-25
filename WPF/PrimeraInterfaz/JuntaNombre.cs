using Microsoft.TeamFoundation.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraInterfaz
{
    public class JuntaNombre : INotifyPropertyChanged
    {
        private string nombre;
        private string apellido;
        private string nombreCompleto;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public string Nombre
        {
            get { return nombre; }
            set 
            { 
                nombre = value;
                OnPropertyChanged("nombreCompleto");
            }
        }
        public string Apellido
        {
            get { return apellido; }
            set 
            {
                apellido = value;
                OnPropertyChanged("nombreCompleto");
            }
        }
        public string NombreCompleto
        {
            get 
            {
                string nombre_completo = $"{Nombre} {Apellido}"; 
                return nombre_completo;
            }
            set 
            {
                nombreCompleto = value;
                OnPropertyChanged("apellido");
            }
        }
    }
}
