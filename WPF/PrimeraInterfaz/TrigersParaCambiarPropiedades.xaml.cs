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
    /// Lógica de interacción para CuartaVentana.xaml
    /// </summary>
    public partial class CuartaVentana : Window
    {
        // creacion de una propiedad en wpf
        public int MiProperty
        {
            get { return (int)GetValue(miDependencyProperty); }

            set { SetValue(miDependencyProperty, value); }
        }

        public static readonly DependencyProperty miDependencyProperty = DependencyProperty.Register("MiProperty", typeof(int), typeof(CuartaVentana), new PropertyMetadata(0));

        public CuartaVentana()
        {
            InitializeComponent();
        }
    }
}
