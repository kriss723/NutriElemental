using System.Collections.Generic;
using NutriElemental.App.Dominio;

namespace NutriElemental.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes(); 
        Paciente AddPaciente (Paciente paciente);
        Paciente UpdatePaciente (Paciente paciente);
        void DeletePaciente (string cedulaPaciente);
        Paciente GetPaciente (string cedulaPaciente); 
        //Nutricionista AsignarMedico (string cedulaPaciente, int idNutricionista);
        //Coach AsignarEnfermera(string cedulaPaciente, string cedulaCoach);
    }
}