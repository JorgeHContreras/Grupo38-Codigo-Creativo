using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCM.App.Dominio;

namespace CCM.App.Persistencia
{
    public interface IRepositorioRegistro
    {
        IEnumerable<Registro> GetAll();
        Registro Add(Registro data);
        //Registro Update(Registro value);
        //void Delete(int id);
        //Registro Get(int id);
        //IEnumerable<Residente> GetPorFiltro(string filtro);
    }
}