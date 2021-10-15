using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NutriElemental.App.Dominio;
using NutriElemental.App.Persistencia;

namespace NutriElemental.App.Presentacion.Pages.Nutricionistas
{
    public class ActualizarModel : PageModel
    {
        private readonly IRepositorioNutricionista _repoNutricionista;
        public Nutricionista Nutricionista{get;set;}
        public ActualizarModel(IRepositorioNutricionista _repoNutricionista)
        {
            this._repoNutricionista = _repoNutricionista;
        }
        public IActionResult OnGet(int id)
        {
            Nutricionista = _repoNutricionista.GetNutricionista(id);
            if(Nutricionista == null)
            {
                return NotFound();
            }else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Nutricionista nutricionista)
        {
            _repoNutricionista.UpdateNutricionista(nutricionista);
            return RedirectToPage("Index");
        }
    }
}
