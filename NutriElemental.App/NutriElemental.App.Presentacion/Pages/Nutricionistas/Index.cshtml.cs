using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NutriElemental.App.Dominio;
using NutriElemental.App.Persistencia;

namespace HospiEnCasa.App.Presentacion.Pages.Nutricionistas
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioNutricionistas _repoNutricionista;
        public IEnumerable<Nutricionista> Nutricionista{get;set;}
        public IndexModel(IRepositorioNutricionistas _repoNutricionista)
        {
            this._repoNutricionista = _repoNutricionista;
        }
        public void OnGet()
        {
            Nutricionista = _repoNutricionista.GetAllNutricionista();
        }
    }
}
