using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NutriElemental.App.Dominio;
using NutriElemental.App.Persistencia;

namespace HospiEnCasa.App.Presentacion.Pages.Coachs
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioCoach _repoCoach;
        public IEnumerable<Coach> Coach{get;set;}
        public IndexModel(IRepositorioCoach _repoCoach)
        {
            this._repoCoach = _repoCoach;
        }
        public void OnGet()
        {
            Coach = _repoCoach.GetAllCoach();
        }
    }
}
