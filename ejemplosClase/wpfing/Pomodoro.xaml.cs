using System;
using System.Windows;
using System.Windows.Threading;
using System.Diagnostics;

namespace Pomodoro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer temporizador;
        Stopwatch cronometro;

        TimeSpan tiempoActual;

        bool pausado;

        public MainWindow()
        {
            InitializeComponent();
            temporizador = new DispatcherTimer();
            cronometro = new Stopwatch();
        }

        private void btn_IniciarPausar_Click(object sender, RoutedEventArgs e)
        {
            temporizador.Tick += Temporizador_Tick;

            temporizador.Start();
            if (pausado)
                cronometro.Start();
            else
                cronometro.Restart();

            // Cambiando el mensaje
            lbl_Momentum.Content = "Momento de trabajar";

            // (Des)activando botones
            btn_Iniciar.IsEnabled = false;
            btn_Detener.IsEnabled = true;
            btn_Pausar.IsEnabled = true;
        }

        private void btn_Detener_Click(object sender, RoutedEventArgs e)
        {
            cronometro.Reset();
            DetenerRelojes();

            // Cambiando mensajes
            lbl_Momentum.Content = "Detenido";
            lbl_ContadorTiempo.Content = "00:00";

            // (Des)activando botones
            btn_Detener.IsEnabled = false;
            btn_Iniciar.IsEnabled = true;
        }

        private void btn_Pausar_Click(object sender, RoutedEventArgs e)
        {
            // Activando botones
            btn_Detener.IsEnabled = true;
            btn_Iniciar.IsEnabled = true;

            btn_Pausar.IsEnabled = false;

            DetenerRelojes();

            pausado = true;
        }

        // Eventos

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            if (cronometro.IsRunning)
            {
                tiempoActual = cronometro.Elapsed;
                lbl_ContadorTiempo.Content = String.Format("{0:00}:{1:00}",
                    tiempoActual.Minutes, tiempoActual.Seconds);
            }
        }

        // Otros métodos

        private void DetenerRelojes()
        {
            temporizador.Stop();
            cronometro.Stop();
        }
    }
}
