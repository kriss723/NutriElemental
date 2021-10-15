using System.Collections.Generic;
using NutriElemental.App.Dominio;

namespace NutriElemental.App.Persistencia
{
    public interface IRepositorioCoach
    {
        IEnumerable<Coach> GetAllCoach(); 
        Coach AddCoach (Coach coach);
        Coach UpdateCoach (Coach coach);
        void DeleteCoach (int idCoach);
        Coach GetCoach (int idCoach); 
    }
}