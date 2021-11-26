using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace musikVS.dto
{
    //Para registrar los cambios usaremos INotifyPropertyChanged en cada uno de los elementos de la clase

    //Para las modificaciones usaremos la interfaz IClonable el cual clonará temporalmente un objeto para que la logica de negocio al
    //modificar una cancion sea la correcta

    //Para validar los campos usamos la interfaz IDataErrorInfo
    public class Cancion : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        private String titulo;
        public String Titulo
        {
            get { return titulo; }
            set { titulo = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Titulo"));
            }
        }
        private String autor;
        public String Autor
        {
            get { return autor; }
            set
            {
                autor = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Autor"));
            }
        }

        private DateTime fechaEntrada;
        public DateTime FechaEntrada
        {
            get { return fechaEntrada; }
            set 
            { 
                fechaEntrada = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("FechaEntrada"));
            }

        }



        public Cancion(String titulo, String autor, DateTime fechaEntrada)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.fechaEntrada=fechaEntrada;
        }
        public Cancion()
        {
            this.fechaEntrada = DateTime.Now;
        }

        //Evento para registrar los cambios de las propiedades de los elementos de la clase
        public event PropertyChangedEventHandler PropertyChanged;
        //Metodo de clonado
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public string Error
        {
            get { return ""; }
        }

        public string this[string columnName]
        {
            get
            {
                string result = "";
                if(columnName == "Titulo")
                {
                    if (string.IsNullOrEmpty(titulo))
                    {
                        result = "Debe introducir el titulo";
                    }
                }
                if(columnName == "Autor")
                {
                    if (string.IsNullOrEmpty(autor))
                    {
                        result = "Debe introducir el autor";
                    }
                }
                return result;
            }
        }
    }
}
