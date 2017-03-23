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
using System.IO;

namespace visorImagenes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string dirImagenes = @"C:\pruebas";

        public MainWindow()
        {
            InitializeComponent();
            LeerImagenes(dirImagenes);
            img_Contenedor.Source = listaImagenes[posicionImagen];
        }

        List<BitmapImage> listaImagenes;
        int posicionImagen;

        private void LeerImagenes(string directorio)
        {
            posicionImagen = 0;
            listaImagenes = new List<BitmapImage>();
            string[] listaTodosFicheros = Directory.GetFiles(directorio);

            foreach (string item in listaTodosFicheros)
            {
                if (System.IO.Path.GetExtension(item) == ".jpg")
                {
                    BitmapImage img = new BitmapImage(new Uri(item));
                    listaImagenes.Add(img);
                }
            }
        }

        private void btAvIzq_Click(object sender, RoutedEventArgs e)
        {

            btn_AvIzq.IsEnabled = true;
            posicionImagen--;
            img_Contenedor.Source = listaImagenes[posicionImagen];
            btn_AvDer.IsEnabled = true;

            if (posicionImagen == 0)
                btn_AvIzq.IsEnabled = false;
        }

        private void btAvDer_Click(object sender, RoutedEventArgs e)
        {
            btn_AvDer.IsEnabled = true;
            posicionImagen++;
            img_Contenedor.Source = listaImagenes[posicionImagen];
            btn_AvIzq.IsEnabled = true;

            if (posicionImagen == listaImagenes.Count - 1)
                btn_AvDer.IsEnabled = false;
        }
    }
}
