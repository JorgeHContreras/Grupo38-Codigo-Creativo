using System;
using System.Collections.Generic;
using CCM.App.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CCM.App.Persistencia
{
    
    public class RepositorioResidente : IRepositorioResidente
    {
        private readonly AppContext _appContext;
        public RepositorioResidente(AppContext appContext)
        {
            _appContext = appContext;
        }

        
        public Residente AddResidente(Residente residente)
        {
            var residenteAdicionado = _appContext.residentes.Add(residente);
            _appContext.SaveChanges();
            return residenteAdicionado.Entity;
        }
        public Residente UpdateResidente(Residente residente)
        {
            var residenteEncontrado = _appContext.residentes.FirstOrDefault(p => p.id == residente.id);
            if (residenteEncontrado != null)
            {
                residenteEncontrado.nombre = residente.nombre;
                residenteEncontrado.apellido = residente.apellido;
                residenteEncontrado.cedula = residente.cedula;
                residenteEncontrado.apartamento = residente.apartamento;
                _appContext.SaveChanges();
            }
            return residenteEncontrado;
        }
        public Residente GetResidente(int idResidente)
        {
            return _appContext.residentes.FirstOrDefault(p => p.id == idResidente);
        }
        public IEnumerable<Residente> GetAllResidentes()
        {
            return _appContext.residentes;
        }
        public void DeleteResidente(int idResidente)
        {
            var residenteEncontrado = _appContext.residentes.FirstOrDefault(p => p.id == idResidente);
            if (residenteEncontrado == null)
            return;
            _appContext.residentes.Remove(residenteEncontrado);
            _appContext.SaveChanges();
            
            
          
        }
    }
}