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

    public partial class Login : Window
    {
        //BD
        private UserList bd = MainWindow.bdConnect();
        public Login()
        {
            InitializeComponent();
        }
        //Boton para ir al Register
        private void ButtonRegister(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }
        //Boton que verifica que los datos son correctos y entra al MenuPrincipal mandando el usuario a este para registrar su nombre y que así aparezca
        //arriba a la derecha
        private void ButtonEntrar(object sender, RoutedEventArgs e)
        {

            string username = usernameTextBox.Text;
            string password = PassPasswordBox.Password;
            Usuarios userFound = bd.buscarUser(username);
            //Console.WriteLine("Username: " + userFound.username);

            if (userFound.username == username && userFound.password == password)
            {
                bd.user = userFound;
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show();
                this.Close();
            }
            //Si los datos son incorrectos se abrirá una ventana indicandolo
            else
            {
                MessageBox.Show("Username o Contraseña incorrecta, porfavor intentelo de nuevo");
            }

        }
    }
}
