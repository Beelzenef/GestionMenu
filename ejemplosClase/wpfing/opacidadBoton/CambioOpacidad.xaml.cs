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

namespace CambioOpacidad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            recOcultando.Opacity = sld_CambiarOpacidad.Value;
            this.Title = sld_CambiarOpacidad.Value.ToString();
        }

        private void sld_CambiarOpacidad_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            recOcultando.Opacity = sld_CambiarOpacidad.Value / 100;
            this.Title = sld_CambiarOpacidad.Value.ToString("000");
        }
    }
}
