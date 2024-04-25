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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ComboBoxYCheckBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Capitales> listaDeCapitales = new List<Capitales>();
            listaDeCapitales.Add(new Capitales() { NombreCapital = "Guatemala"});
            listaDeCapitales.Add(new Capitales() { NombreCapital = "Madrid"});
            listaDeCapitales.Add(new Capitales() { NombreCapital = "Ciudad de Mexico"});
            listaDeCapitales.Add(new Capitales() { NombreCapital = "Bogota"});
            listaDeCapitales.Add(new Capitales() { NombreCapital = "Estados Unidos"});
            Capitales.ItemsSource = listaDeCapitales;
        }

        private void TodasLasCapitales_Checked(object sender, RoutedEventArgs e)
        {
            if(TodasLasCapitales.IsChecked == true)
            {
                Guatemala.IsChecked = true;
                Madrid.IsChecked = true;
                CiudadDeMexico.IsChecked = true;
                Bogota.IsChecked = true;
                EstadosUnidos.IsChecked = true;
            }
            else
            {
                Guatemala.IsChecked = false;
                Madrid.IsChecked = false;
                CiudadDeMexico.IsChecked = false;
                Bogota.IsChecked = false;
                EstadosUnidos.IsChecked = false;
            }

        }

        private void TodasLasCapitales_Unchecked(object sender, RoutedEventArgs e)
        {
            Guatemala.IsChecked = false;
            Madrid.IsChecked = false;
            CiudadDeMexico.IsChecked = false;
            Bogota.IsChecked = false;
            EstadosUnidos.IsChecked = false;

        }

        private void individualCheckeado(object sender, RoutedEventArgs e)
        {
            if(Guatemala.IsChecked == true && Madrid.IsChecked == true && CiudadDeMexico.IsChecked == true && Bogota.IsChecked == true && EstadosUnidos.IsChecked == true)
            {
                TodasLasCapitales.IsChecked = true;
            }
            else
            {
                TodasLasCapitales.IsChecked = null;
            }
        }

        private void IndividualNoCheckeado(object sender, RoutedEventArgs e)
        {
            if (Guatemala.IsChecked == false && Madrid.IsChecked == false && CiudadDeMexico.IsChecked == false && Bogota.IsChecked == false && EstadosUnidos.IsChecked == false)
            {
                TodasLasCapitales.IsChecked = false;
            }
            else
            {
                TodasLasCapitales.IsChecked = null;
            }
        }
    }

    public class Capitales
    {
        public string NombreCapital { get; set; }
    }
}
