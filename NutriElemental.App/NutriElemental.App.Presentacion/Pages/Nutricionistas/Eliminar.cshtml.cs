using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NutriElemental.App.Persistencia;
using NutriElemental.App.Dominio;

namespace NutriElemental.App.Presentacion.Pages.Nutricionistas
{
    public class EliminarModel : PageModel
    {
        private readonly IRepositorioNutricionista _repoNutricionista;
        public Nutricionista Nutricionista{set;get;}
        public EliminarModel(IRepositorioNutricionista _repoNutricionista)
        {
            this._repoNutricionista = _repoNutricionista;
        }
        public IActionResult OnGet(int id)
        {
            Nutricionista = _repoNutricionista.GetNutricionista(id);
            if(Nutricionista == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost(int id)
        {
            _repoNutricionista.DeleteNutricionista(id);
            return RedirectToPage("Index");
        }
    }
}
