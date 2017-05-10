using System.Collections.ObjectModel;
using System.ComponentModel;

namespace AppWPF_ListView
{
    public class Persona : INotifyPropertyChanged
    {
        string nombre;
        string personaje;
        int nivel;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
                OnPropertyChanged("Nombre");
            }
        }

        public string Personaje
        {
            get { return personaje; }
            set
            {
                personaje = value;
                OnPropertyChanged("Personaje");
            }
        }

        public int Nivel
        {
            get { return nivel; }
            set
            {
                nivel = value;
                OnPropertyChanged("Nivel");
            }
        }

        public Persona(string n, string p, int l)
        {
            Nivel = l;
            Nombre = n;
            Personaje = p;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string nombre)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(nombre));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }

    public class ListaPersonas : ObservableCollection<Persona>
    {
        ObservableCollection<Persona> listaPersonas = new ObservableCollection<Persona>();

        public ListaPersonas() : base()
        {
            Add(new Persona("Elena", "Ethan Thross", 20));
            Add(new Persona("Irene", "Catherin Thross", 20));
            Add(new Persona("Jaime", "Lord Gideon", 20));
        }

    }
}
