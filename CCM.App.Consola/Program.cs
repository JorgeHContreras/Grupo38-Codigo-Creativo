using System;
using System.Collections.Generic;
using CCM.App.Dominio;
using CCM.App.Persistencia;

namespace CCM.App.Consola
{
    class program
    {
        private static IRepositorioResidente _repositorioResidente = new RepositorioResidente(new Persistencia.AppContext());
        private static IRepositorioRegistro _repositorioRegistro = new RepositorioRegistro(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //AddResidente();
            AddRegistro();
        }


        private static void AddResidente()
        {
            var residente = new Residente
            {
                nombre = "Jorge",
                apellido = "Contreras",
                cedula = 1070955998,
                apartamento = "101"
            };
            _repositorioResidente.AddResidente(residente);
        }
        private static void AddRegistro()
        {
            var registro = new Registro
            {
                nombre = "Albert",
                apellido = "Wesker",
                cedula = 2000200200,
                apartamento = "101",
                asunto = "Molestar",
                fechaDeEntrada = DateTime.Now,
                fechaDeSalida = DateTime.Now
            };
            _repositorioRegistro.Add(registro);
        }
    }
}
