using System.Collections.Generic;
using NutriElemental.App.Dominio;

namespace NutriElemental.App.Persistencia
{
    public interface IRepositorioSugerenciaNutricional
    {
        IEnumerable<SugerenciaNutricional> GetAllSugerencias();
        SugerenciaNutricional AddSugerencia (SugerenciaNutricional sugerencia);
        SugerenciaNutricional UpdateSugerencia (SugerenciaNutricional sugerencia);
        void DeleteSugerencia (int idSugerencia);
        SugerenciaNutricional GetSugerencia(int idSugerencia);
    }
}