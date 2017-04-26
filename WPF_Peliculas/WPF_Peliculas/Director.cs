using System;
using System.Collections.ObjectModel;

namespace WPF_Peliculas
{
    class Director : Notificador
    {
        ObservableCollection<Pelicula> listita;

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
