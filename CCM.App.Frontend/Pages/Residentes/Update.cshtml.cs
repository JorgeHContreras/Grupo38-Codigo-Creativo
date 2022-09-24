
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CCM.App.Dominio;
using CCM.App.Persistencia;

namespace CCM.App.Frontend.Pages
{
    public class UpdateModel : PageModel
    {
        private readonly IRepositorioResidente repositorioResidente;

        [BindProperty]
        public Residente residente { get; set; }

        public UpdateModel()
        {
            this.repositorioResidente = new RepositorioResidente(new Persistencia.AppContext());
        }

        public IActionResult OnGet(int? residenteId)
        {
            if (residenteId.HasValue)
            {
                residente = repositorioResidente.GetResidente(residenteId.Value);
            }
            else
            {
                residente = new Residente();
            }
            if (residente == null)
            {
                return RedirectToPage("../Error");
            }
            else
                return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (residente.id > 0)
            {
                residente = repositorioResidente.UpdateResidente(residente);
            }
            else
            {
                repositorioResidente.AddResidente(residente);
            }
            return Page();
        }
    }
}
