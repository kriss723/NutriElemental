using System;

namespace NutriElemental.App.Dominio
{
    public class Persona
    {   
        public int Id {get;set;}
        public string Cedula {get; set;}
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public string Direccion {get; set;}
        public string Celular {get;set;}
        public string Email {get;set;}
        public Genero Genero {get;set;}
    }
}