using System;
using System.Collections.Generic;
using System.Linq;
using NutriElemental.App.Persistencia;
using NutriElemental.App.Dominio;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NutriElemental.App.Presentacion.Pages.Nutricionistas
{
    public class CrearModel : PageModel
    {
        private readonly IRepositorioNutricionista _repoNutricionista;
        public Nutricionista Nutricionista{get;set;}
        public CrearModel(IRepositorioNutricionista _repoNutricionista)
        {
            this._repoNutricionista = _repoNutricionista;
        }
        public void OnGet()
        {
            Nutricionista = new Nutricionista();
        }

        public IActionResult OnPost(Nutricionista nutricionista)
        {
            _repoNutricionista.AddNutricionista(nutricionista);
            return RedirectToPage("Index");
        }
    }
}
