using System;
using System.Collections.Generic;
using NutriElemental.App.Dominio;
using NutriElemental.App.Persistencia;

namespace NutriElemental.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            AddPaciente();
                
                
            //Console.WriteLine("Hello World!");
        }

        private static void AddPaciente(){
            var paciente = new Paciente{
                Cedula = "1000298112",
                Nombre = "Jesus",
                Apellido = "Jaramillo",
                Direccion = "cra 23 #24-43"
            };
            _repoPaciente.AddPaciente(paciente);
        }
    }
}
