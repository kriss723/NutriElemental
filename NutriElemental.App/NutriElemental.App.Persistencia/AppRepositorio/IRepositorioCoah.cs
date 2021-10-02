using System.Collections.Generic;
using NutriElemental.App.Dominio;

namespace NutriElemental.App.Persistencia
{
    public interface IRepositorioCoah
    {
        IEnumerable<Coah> GetAllCoah(); 
        Paciente AddCoah (Paciente coah);
        Paciente UpdateCoah (Paciente coah);
        void DeleteCoah (string CedulaCoah);
        Coah GetCoah (string CedulaCoah); 
    }
}