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

    public partial class MenuPrincipal : Window
    {
        //BD
        private UserList bd;
        public MenuPrincipal()
        {
            InitializeComponent();
            bd = MainWindow.bdConnect();
            userOptions.Header = bd.user.username;
            
        }

      //Abrir UserConfiguracion
        private void clickOnVerPerfil(object sender, RoutedEventArgs e)
        {
            UserConfiguracion userWindow = new UserConfiguracion();
            userWindow.Show();
            this.Close();
        }
        //Para volver a login
        private void clickOnCerrarSesion(object sender,RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
        //He añadido esté botón para hacer los demas apartados del proyecto, he hecho esto porque no sabia como integrar bien las funcionalidades
        //pedidas en los otros apartados para este proyecto.
        private void otrasFuncionalidades_Click(object sender, RoutedEventArgs e)
        {
            altas alta = new altas();
            alta.Show();
            this.Close();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
