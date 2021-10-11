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
            //AddPaciente();
                
                
            //Console.WriteLine("Hello World!");
        }
        /*
        private static void AddPaciente(){
            var paciente = new Paciente{
                Cedula = "123456789",
                Nombre = "Andrea",
                Apellido = "Gomez Perez",
                Direccion = "cra 24 #22-258",
                Celular = "3259869741",
                Email = "andreagomez23@gmail.com",
                Password = "andreagomez",
                Genero = Genero.Femenino,
                Latitud = -35,
                Longitud = 12,
                Ciudad = "Medellin",
                FechaNacimiento = new DateTime(1995, 10, 05)

            };
            _repoPaciente.AddPaciente(paciente);
        }*/
    }
}
