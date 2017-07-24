using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;
using System.Linq;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            InicializarPeliculas();
            lsb_ListaPeliculas.ItemsSource = listaPeliculas;
        }

        ListaPeliculas listaPeliculas;
        Pelicula[] listaDeBuscadas;

        private void btn_BuscarTitulo_Click(object sender, RoutedEventArgs e)
        {
            listaDeBuscadas = listaPeliculas.Where(p => p.Titulo == txtB_ElementoBusq.Text).ToArray();
            lsb_Resultado.ItemsSource = listaDeBuscadas;
        }

        private void btn_BuscarDirector_Click(object sender, RoutedEventArgs e)
        {
            listaDeBuscadas = listaPeliculas.Where(p => p.Director == txtB_ElementoBusq.Text).ToArray();
            lsb_Resultado.ItemsSource = listaDeBuscadas;
        }

        private void btn_TitulosCon_Click(object sender, RoutedEventArgs e)
        {
            var peliculasBuscadas = from s in listaPeliculas
                                    where s.Titulo.Contains(txtB_ElementoBusq.Text)
                                    select s;

            lsb_Resultado.ItemsSource = peliculasBuscadas;
        }

        private void InicializarPeliculas()
        {
            listaPeliculas = new ListaPeliculas();

            listaPeliculas.Add(new Pelicula("La historia interminable", "LFD"));
            listaPeliculas.Add(new Pelicula("Dune", "OMG"));
            listaPeliculas.Add(new Pelicula("Un ciudadano ejemplar", "TFG"));
            listaPeliculas.Add(new Pelicula("Una película de terror", "AER"));
            listaPeliculas.Add(new Pelicula("Cuando cae la noche", "FAS"));
            listaPeliculas.Add(new Pelicula("Llega de noche", "DAS"));
            listaPeliculas.Add(new Pelicula("Oscuros pensamientos", "DFR"));
        }

        private void txtB_ElementoBusq_GotFocus(object sender, RoutedEventArgs e)
        {
            txtB_ElementoBusq.Clear();
            txtB_ElementoBusq.Foreground = Brushes.Black;
        }

        private void txtB_ElementoBusq_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtB_ElementoBusq.Text.Length == 0)
            {
                txtB_ElementoBusq.Foreground = Brushes.Gray;
                txtB_ElementoBusq.Text = "¿Qué vas a buscar?";
            }
        }
       
    }

    public class Pelicula
    {
        public string Titulo { get; set; }
        public string Director { get; set; }

        public Pelicula(string t, string d)
        {
            this.Director = d;
            this.Titulo = t;
        }

        public override string ToString()
        {
            return this.Titulo + ", de " + this.Director;
        }
    }

    public class ListaPeliculas : ObservableCollection<Pelicula>
    {

    }
}
