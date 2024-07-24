using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Databinding20367749
{
    public class Alumno : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string nombre = string.Empty;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (nombre != value)
                {
                    nombre = value;
                    OnPropertyChanged(nameof(Nombre));
                    OnPropertyChanged(nameof(MostrarNombre));
                }
            }
        }

        public string MostrarNombre => $"Nombre ingresado: {Nombre}";

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
