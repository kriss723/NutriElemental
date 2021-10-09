using System.Collections.Generic;
using NutriElemental.App.Dominio;

namespace NutriElemental.App.Persistencia
{
    public interface IRepositorioHistoria
    {
        Historia AddHistoria(Historia historia);
        void DeleteHistoria(int IdHistoria);
        IEnumerable<Historia> GetAllHistorias();
        Historia GetHistoria(int IdHistoria);
        Historia UpdateHistoria(Historia historia);

    }
}