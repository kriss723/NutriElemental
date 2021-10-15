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
    public class ActualizarModel : PageModel
    {
        private readonly IRepositorioCoach _repoCoach;
        public Coach Coach {get;set;}
        public ActualizarModel(IRepositorioCoach _repoCoach)
        {
            this._repoCoach = _repoCoach;
        }

        public IActionResult OnGet(int id)
        {
            Coach = _repoCoach.GetCoach(id);
            if(Coach == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost(Coach coach)
        {
            _repoCoach.UpdateCoach(coach);
            return RedirectToPage("Index");
        }
    }
}
