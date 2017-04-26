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

namespace WPF_Peliculas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_CambiarTitulo_Click(object sender, RoutedEventArgs e)
        {
            Pelicula refAPelicula = Resources["unaPelicula"] as Pelicula;

            if (refAPelicula == null)
                return;

            refAPelicula.Titulo = "Duck you!";
        }

        private void btn_AumentarCalificacion_Click(object sender, RoutedEventArgs e)
        {
            Pelicula refAPelicula = Resources["unaPelicula"] as Pelicula;

            if (refAPelicula == null)
                return;

            refAPelicula.Calificacion = refAPelicula.Calificacion + 1;
        }
    }
}
