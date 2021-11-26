using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace musikVS.dto
{
    public class listaCanciones
    {
        public ObservableCollection<Cancion> listaCancion { get; set; }

        public listaCanciones()
        {
            //Creamos una coleccion
            listaCancion = new ObservableCollection<Cancion>();
            //Cancion de prueba
            listaCancion.Add(new Cancion("Better now", "Parker", DateTime.Now));
        }
        //Metodo para añadir canciones
        public void annadirCancion(Cancion cancion)
        {
            listaCancion.Add(cancion);
        }
        //Metodo para acceder a un elemento concreto de la lista
        public void modificarCancion(Cancion cancion, int posicion)
        {
            listaCancion[posicion] = cancion;
        }
    }
}
