using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCM.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace CCM.App.Persistencia
{
    public class RepositorioRegistro : IRepositorioRegistro
    {
        private readonly AppContext _appContext;
        public RepositorioRegistro(AppContext appContext)
        {
            _appContext = appContext;
        }

        public IEnumerable<Registro> GetAll()
        {
            return _appContext.registros;
        }

        public Registro Add(Registro data)
        {
            //residente.id = _appContext.residentes.Max(r => r.id) +1;
            //var residenteAdicionado = _appContext.residentes.Add(residente);
            //_appContext.SaveChanges();
            //return residenteAdicionado.Entity;
            _appContext.registros.Add(data);
            _appContext.SaveChanges();
            return data;
        }
    }
}