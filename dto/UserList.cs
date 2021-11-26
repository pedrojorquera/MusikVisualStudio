using System;
using System.Collections.Generic;
using System.Text;

namespace musikVS.dto
{
    public class UserList
    {
        public List<Usuarios> listaUsuarios;
        public Usuarios user { get; set; }

        public UserList()
        {
            this.listaUsuarios = new List<Usuarios>();
            userprueba();
        }
        //Para guardar usuarios
        public void guardarUser(Usuarios user)
        {
            listaUsuarios.Add(user);
        }
        //Mismo metodo sobrecargado
        public Usuarios buscarUser(string username)
        {
            return listaUsuarios.Find(u => u.username == username);
        }
        public Usuarios buscarUser(Usuarios usuario)
        {
            return listaUsuarios.Find(u => u.username == usuario.username);
        }
        //Uso este metodo para crear un usuario de prueba y hacer pruebas o acceder rapido a las ventanas que quiero, saltandome el login
        private void userprueba()
        {
            listaUsuarios.Add(new Usuarios("pepe", "pepe"));
        }

    }
}
