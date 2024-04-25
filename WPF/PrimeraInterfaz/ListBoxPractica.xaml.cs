using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PrimeraInterfaz
{
    /// <summary>
    /// Lógica de interacción para ListBoxPractica.xaml
    /// </summary>
    public partial class ListBoxPractica : Window
    {
        public ListBoxPractica()
        {
            InitializeComponent();
            List<Poblaciones> listaDePob = new List<Poblaciones>();
            listaDePob.Add(new Poblaciones() { poblacion = "Jalapa", poblacionDos = "Guatemala", temperatura = 23, temperaturaDos = 19, diferenciaDeTemperatura = 4 });
            listaDePob.Add(new Poblaciones() { poblacion = "Jutiapa", poblacionDos = "Izabal", temperatura = 13, temperaturaDos = 29, diferenciaDeTemperatura = 16});
            listaDePob.Add(new Poblaciones() { poblacion = "China", poblacionDos = "Coban", temperatura = 25, temperaturaDos = 39, diferenciaDeTemperatura = 14 });
            listaDePob.Add(new Poblaciones() { poblacion = "Zacapa", poblacionDos = "Espania", temperatura = 43, temperaturaDos = 49, diferenciaDeTemperatura = 6 });
            ListaDePoblaciones.ItemsSource = listaDePob;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ListaDePoblaciones.SelectedItem != null)
            {
                foreach (Poblaciones poblacion in ListaDePoblaciones.SelectedItems)
                {
                    MessageBox.Show(poblacion.poblacion + " " +
                        poblacion.temperatura + " ^C " +
                        poblacion.poblacionDos + " " +
                        poblacion.temperaturaDos + " ^C ");
                }
            }
            else
            {
                MessageBox.Show("selecciona un elemento");
            }
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            foreach (Poblaciones poblacion in ListaDePoblaciones.SelectedItems)
            {
                MessageBox.Show(poblacion.poblacion + " " +
                    poblacion.temperatura + " ^C " +
                    poblacion.poblacionDos + " " +
                    poblacion.temperaturaDos + " ^C ");
            }
        }
    }
    public class Poblaciones
    {
        public string poblacion { get; set; }
        public int temperatura { get; set; }
        public string poblacionDos { get; set; }
        public int temperaturaDos { get; set; }
        public int diferenciaDeTemperatura { get; set; }
    }
}
