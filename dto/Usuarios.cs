using System;
using System.Collections.Generic;
using System.Text;

namespace musikVS.dto
{
    public class Usuarios
    {
        //get y set básicos{
        public String nombre{ get; set; } 
        private String apellidos{ get; set; }
        public String username{ get; set; }
        public String password { get; set; }
        private String email { get; set; }
        //}

        //get y set personalizados{
        private String fechNacimiento
        {
            get => fechNacimiento;
            set => fechNacimiento = value;
        }
        //}
        //Constructor vacio
        public Usuarios()
        {
        }
        //Constructor con datos
        public Usuarios(string nombre, string apellidos, string username, string password, string email)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.username = username;
            this.password = password;
            this.email = email;
            
        }

        public Usuarios(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public override bool Equals(object obj)
        {
            return obj is Usuarios usuarios &&
                   username == usuarios.username &&
                   password == usuarios.password;
        }


    } 
}
    
