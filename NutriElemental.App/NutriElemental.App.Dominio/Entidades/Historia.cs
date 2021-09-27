using System;
using System.Collections.Generic;

namespace NutriElemental.App.Dominio
{
    public class Historia
    {
        public int Id {get;set;}
        public Paciente Paciente {get;set;}
        public string Diagnostico {get;set;}
        public List<string> AntecedentesFamiliares {get;set;}

        public List<string> AntecedentesPersonales {get; set;}
        public List<SugerenciaNutricional> SugerenciaNutricional { get; set; }
    }
}