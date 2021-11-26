using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using musikVS.dto;
using musikVS.gui;

namespace musikVS
{

    public partial class MainWindow : Window
    {
        //Instanciar BD
        public static UserList bd;
        public MainWindow()
        {
            InitializeComponent();
            //Inicializar BD
            bd = new UserList();
        }
       //Boton de login
        private void Button_ClickLogin(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
        //Boton de register
        private void Button_ClickRegister(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }

        //Metodo para conectar BD con el resto del proyecto
        public static UserList bdConnect()
        {
            return bd;
        }
    }
}
