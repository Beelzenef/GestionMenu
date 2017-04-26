using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Peliculas
{
    public class Notificador : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string nombre)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(nombre));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }

    enum Generos
    {
        CienciaFiccion, Fantasia, Drama, CriticaSocial, Mafia, Documental
    }

    class Pelicula : Notificador
    {
        #region Campos

        string titulo;
        Generos genero;
        bool? ganadorOscar;
        double calificacion;

        Director directorPelicula;

        ObservableCollection<string> listaActores;

        #endregion

        #region Propiedades

        public string Titulo
        {
            get { return titulo; }
            set
            {
                if (titulo != value)
                {
                    titulo = value;
                    OnPropertyChanged("Titulo");
                }
            }
        }

        public Generos Genero
        {
            get { return genero; }
            set
            {
                if (genero != value)
                {
                    genero = value;
                    OnPropertyChanged("Genero");
                }
            }
        }

        public bool? GanadorOscar
        {
            get { return ganadorOscar; }
            set {
                if (ganadorOscar != value)
                {
                    ganadorOscar = value;
                    OnPropertyChanged("GanadorOscar");
                }
            }
        }

        public double Calificacion
        {
            get { return calificacion; }
            set
            {
                if (calificacion != value)
                {
                    calificacion = value;
                    OnPropertyChanged("Calificacion");
                }
            }
        }

        #region Propiedades para campos por referencia

        public Director ElDirector
        {
            get
            {
                return directorPelicula;
            }
            set
            {
                directorPelicula = value;
            }
        }

        public ObservableCollection<string> ListaActores
        {
            get
            {
                return listaActores;
            }
            set
            {
                listaActores = value;
            }
        } 

        #endregion

        #endregion

        #region Constructores

        public Pelicula() {
            listaActores = new ObservableCollection<string>();
        }

        public Pelicula(string titu, Generos gen, bool? haGanadoOscar, double calif)
        {
            
        }

        #endregion


        #region Metodos



        #endregion
    }
}
