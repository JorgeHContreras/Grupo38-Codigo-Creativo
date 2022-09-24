using System;
using System.Collections.Generic;
using CCM.App.Dominio;
using CCM.App.Persistencia;

namespace CCM.App.Consola
{
    class program
    {
        private static IRepositorioResidente _repositorioResidente = new RepositorioResidente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            AddResidente();
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
    }
}
