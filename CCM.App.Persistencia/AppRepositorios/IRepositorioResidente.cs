using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CCM.App.Dominio;

namespace CCM.App.Persistencia
{
    public interface IRepositorioResidente
    {
        Residente AddResidente(Residente residente);
        Residente UpdateResidente(Residente residente);
        Residente GetResidente(int idResidente);
        IEnumerable<Residente> GetAllResidentes();
        void DeleteResidente(int idResidente);
    }
}