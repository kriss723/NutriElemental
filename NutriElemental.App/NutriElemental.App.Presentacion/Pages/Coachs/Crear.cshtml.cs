using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NutriElemental.App.Dominio;
using NutriElemental.App.Persistencia;

namespace NutriElemental.App.Presentacion.Pages.Coachs
{
    public class CrearModel : PageModel
    {
        private readonly IRepositorioCoach _repoCoach;
        public Coach Coach{get;set;}
        public CrearModel(IRepositorioCoach _repoCoach)
        {
            this._repoCoach = _repoCoach;
        }
        public void OnGet()
        {
            Coach = new Coach();
        }

        public IActionResult OnPost(Coach coach)
        {
            _repoCoach.AddCoach(coach);
            return RedirectToPage("Index");
        }
    }
}
