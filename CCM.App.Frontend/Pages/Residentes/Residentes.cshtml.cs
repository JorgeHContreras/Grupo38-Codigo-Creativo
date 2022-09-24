using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CCM.App.Dominio;
using CCM.App.Persistencia;
using CCM.App.Persistencia;

namespace CCM.App.Frontend.Pages
{
    public class ResidentesModel : PageModel
    {
        private readonly IRepositorioResidente repositorioResidente;
        public IEnumerable<Residente> residentes{get;set;}

        public ResidentesModel()
        {
            this.repositorioResidente = new RepositorioResidente(new Persistencia.AppContext());
        }

        public void OnGet(string filtroBusqueda)
        {
            residentes=repositorioResidente.GetResidentesPorFiltro(filtroBusqueda);
            //residentes = repositorioResidente.GetAllResidentes();
            //listaResidentes = new List<string>();
            //listaResidentes.AddRange(residentes);
        }
    }
}
