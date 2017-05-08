using System;
using System.Collections.ObjectModel;

namespace WPF_Peliculas
{
    public class Director : Notificador
    {
        ObservableCollection<Pelicula> listita = new ObservableCollection<Pelicula>();

        public string Nombre
        {
            get;
            set;
        }

        public string Nacionalidad
        {
            get;
            set;
        }

        public ObservableCollection<Pelicula> Filmes
        {
            get { return listita; }
            set { listita = value; }
        }

        #region Constructores

        public Director()
        {
        }

        #endregion
    }
}
