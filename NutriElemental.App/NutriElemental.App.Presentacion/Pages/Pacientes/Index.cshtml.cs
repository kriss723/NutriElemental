using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NutriElemental.App.Dominio;
using NutriElemental.App.Persistencia;

namespace HospiEnCasa.App.Presentacion.Pages.Pacientes
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        public IEnumerable<Paciente> Paciente{get;set;}
        public IndexModel(IRepositorioPaciente _repoPaciente)
        {
            this._repoPaciente = _repoPaciente;
        }
        public void OnGet()
        {
            Paciente = _repoPaciente.GetAllPacientes();
        }
    }
}
