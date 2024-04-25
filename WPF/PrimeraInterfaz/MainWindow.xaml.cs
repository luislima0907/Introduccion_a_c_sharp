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

namespace PrimeraInterfaz
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // este metodo inicia la ventana del formulario
            InitializeComponent();

            // creamos un grid y lo agregamos al contenido del formulario
            Grid miGrid = new Grid();
            this.Content = miGrid;

            // agregamos el boton que creamos hacia el grid
            Button miBoton = new Button();

            miBoton.Width = 150;
            miBoton.Height = 75;
            miBoton.Background = Brushes.Blue;

            WrapPanel miWrap = new WrapPanel();

            TextBlock txtUno = new TextBlock();
            txtUno.Text = "Click";
            txtUno.Background = Brushes.Red;
            txtUno.Foreground = Brushes.Black;

            miWrap.Children.Add(txtUno);

            TextBlock txtDos = new TextBlock();
            txtDos.Text = "Enviar";

            miWrap.Children.Add(txtDos);

            miGrid.Children.Add(miBoton);

            miBoton.Content = miWrap;        
        }
    }
}
