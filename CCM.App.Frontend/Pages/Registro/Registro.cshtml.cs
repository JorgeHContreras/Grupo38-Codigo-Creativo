using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CCM.App.Dominio;
using CCM.App.Persistencia;

namespace CCMWeb.App.Frontend.Pages
{
    public class RegistroModel : PageModel
    {
        
        private readonly IRepositorioRegistro _repositorio;
        public IEnumerable<Registro> _lista{get;set;}

        public RegistroModel()
        {
            this._repositorio = new RepositorioRegistro(new CCM.App.Persistencia.AppContext());
        }

        public void OnGet()
        {
            //residentes=repositorioResidente.GetResidentesPorFiltro(filtroBusqueda);
            _lista = _repositorio.GetAll();
            //listaResidentes = new List<string>();
            //listaResidentes.AddRange(residentes);
        }
    }
}
