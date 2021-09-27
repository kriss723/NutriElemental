using System;

namespace NutriElemental.App.Dominio
{
    public class RegistroNutricional
    {
        public int Id {get;set;}
        public string Cantidad {get;set;}
        public string Tipo {get;set;}

        public DateTime Hora_Registro{get;set;}
        public string lugar {get;set;}
        public string Actividad {get;set;}
        public string Estado_Animo {get;set;}

    }
}