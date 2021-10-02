using System;
using System.Collections.Generic;

namespace NutriElemental.App.Dominio
{
    public class Paciente:Persona
    {

        public float Latitud {get;set;}
        public float Longitud {get;set;}
        public string Ciudad {get;set;}
        public DateTime FechaNacimiento {get;set;}

        //Relaciones con las otras entidades
        public Coach Coach {get; set;}
        public Nutricionista Nutricionista {get; set;}
        //Historia Registro
        /// <summary>
        ///  Referencia de los registros nutricionales
        /// </summary>
        /// <value></value>
        public List<RegistroNutricional> RegistroNutricional { get; set; }

        

    }
}