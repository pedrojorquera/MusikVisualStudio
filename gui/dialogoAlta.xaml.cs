using musikVS.dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace musikVS.gui
{

    public partial class dialogoAlta : Window
    {
        //Pasamos los objetos
        private listaCanciones listaCancion;
        public Cancion cancion;
        private int posicion;
        private Boolean modificar;
        private int errores;
        public dialogoAlta(listaCanciones listaCancion)
        {
            InitializeComponent();
            //Expecificamos de donde vienen los datos
            this.listaCancion = listaCancion;
            cancion = new Cancion();
            this.DataContext = cancion;
            modificar = false;
           
        }

        public dialogoAlta(listaCanciones listaCancion, Cancion cancionModificar, int posicion)
        {
            InitializeComponent();
            //para modificar una cancion
            this.listaCancion = listaCancion;
            this.cancion = cancionModificar;
            this.posicion = posicion; 
            this.DataContext = cancion;
            modificar = true;
        }

        //Botón de cancelar
        private void bttCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Boton de aceptar que pasa los datos
        private void bttAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (modificar)
            {
                listaCancion.modificarCancion(cancion, posicion);
            }
            else
            {
                listaCancion.annadirCancion(cancion);
            }
               
            this.Close();
        }
        //Metodo que valida el numero de errores y activa o desactiva el boton de aceptar en el dialogo
        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
            {
                errores++;
            }
            else
            {
                errores--;
            }
            if (errores == 0)
            {
                bttAceptar.IsEnabled = true;
            }
            else
            {
                bttAceptar.IsEnabled = false;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
