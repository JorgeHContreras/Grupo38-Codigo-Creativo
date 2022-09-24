using System;

namespace CCM.App.Dominio
{

    public class Usuario
    {
        public int id{get;set;}
        public UsuarioTipo tipoUsuario {get;set;}
        public string NombreUsuario {get;set;}
        public string Contraseña {get;set;}

    }

}