using System.Collections.Generic;
using NutriElemental.App.Dominio;

namespace NutriElemental.App.Persistencia
{
    public interface IRepositorioCoach
    {
        IEnumerable<Coach> GetAllCoach(); 
        Paciente AddCoach (Paciente coach);
        Paciente UpdateCoach (Paciente coach);
        void DeleteCoach (string CedulaCoach);
        Coach GetCoach (string CedulaCoach); 
    }
}