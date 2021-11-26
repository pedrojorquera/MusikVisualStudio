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
    
    public partial class altas : Window
    {
        private listaCanciones listaCancion;
        public altas()
        {
            InitializeComponent();
            //Indicamos de donde sacaremos los datos
            listaCancion = new listaCanciones();
            DataGridcanciones.DataContext = listaCancion;
        }
        //Al hacer click en el MenuItem se abrira dialogoAlta
       private void NuevoMenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            dialogoAlta dialogo = new dialogoAlta(listaCancion);
            dialogo.Show();
        }
        //Cuando el usuario seleccione una cancion y de a modificar, se recoge la cancion seleccionada y se le pasa al dialogo para asi modificarlo
        private void bttModificar_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridcanciones.SelectedIndex != -1)
            {
                Cancion cancion = (Cancion)DataGridcanciones.SelectedItem;
                dialogoAlta dialogo = new dialogoAlta(listaCancion, (Cancion)cancion.Clone(), DataGridcanciones.SelectedIndex);
                dialogo.Show();
            }
           
        }
    }
}
