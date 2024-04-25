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
    /// Lógica de interacción para SegundaVentana.xaml
    /// </summary>
    public partial class SegundaVentana : Window
    {
        public SegundaVentana()
        {
            InitializeComponent();
        }

        // evento click de un boton en wpf
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine("Le has dado a dale 3!");
            MessageBox.Show("Le has dado a dale 3");
        }

        // este es un ejemplo de como hacer un evento tunneling,
        // que hace que se ejecute el evento del primer evento y recae al ultimo evento
        private void PanelStack_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Le has dado al panel");
        }

        // ejemplo de los eventos bubling, de arriba hacia abajo, en este caso
        // primero se ejecutara el mensaje del boton y luego subira al stack panel
        // y ejecutara su evento click ya que el boton esta adentro del stack
        private void PanelStack_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Le has dado al panel desde el boton");
        }
    }
}
