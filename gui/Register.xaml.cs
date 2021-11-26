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

    public partial class Register : Window
    {
        //BD
        private UserList bd = MainWindow.bdConnect();
        public Register()
        {
            InitializeComponent();
        }
        //Boton que crea un usuario y lo añade a la "BD"
        private void ButtonRegistrarse(object sender, RoutedEventArgs e)
        {
            String Nombre = textboxNombre.Text;
            String Apellidos = textboxApellidos.Text;
            String Password = passwordboxContrasenna.Password;
            String RepeatPassword = passwordRContrasenna.Password;
            String Username = textboxUsername.Text;
            String Email = textboxEMAIL.Text;
            Usuarios user = new Usuarios(Nombre, Apellidos, Username, Password, Email);
            bd.guardarUser(user);
    
            //Validación para que las dos passwords sean iguales
            if (Password == RepeatPassword && Password != "")
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta, porfavor intentelo de nuevo");
            }

        }
        //Boton que lleva directamente al login
        private void ButtonLogin(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
