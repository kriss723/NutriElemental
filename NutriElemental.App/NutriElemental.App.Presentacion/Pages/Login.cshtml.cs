using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NutriElemental.App.Persistencia;
using NutriElemental.App.Dominio;

namespace NutriElemental.App.Presentacion.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;

        public Persona usuario {get;set;}
        public string EmailUsuario {get;set;}

        public string PasswordUsuario {get;set;}

        public LoginModel(IRepositorioPaciente _repoPaciente)
        {
            this._repoPaciente = _repoPaciente;
        }

        public void OnGet()
        {
        }
        
        public IActionResult OnPost(string EmailUsuario, string PasswordUsuario)
        {
            usuario = _repoPaciente.LoginPersona(EmailUsuario,PasswordUsuario);

            if(usuario == null){
                return RedirectToPage("Login");
            }

            if(usuario.Discriminator == "Paciente"){
                return RedirectToPage("./Pacientes/Index");
            }else if(usuario.Discriminator == "Coach"){
                return RedirectToPage("./Coachs/Index");
            }else if(usuario.Discriminator == "Nutricionista"){
                return RedirectToPage("./Nutricionistas/Index");
            }else{
                return RedirectToPage("Login");
            }
            
        }
    }
}
