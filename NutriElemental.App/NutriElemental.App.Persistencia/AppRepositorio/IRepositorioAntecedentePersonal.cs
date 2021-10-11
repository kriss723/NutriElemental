using System.Collections.Generic;
using NutriElemental.App.Dominio;

namespace NutriElemental.App.Persistencia
{
    public interface IRepositorioAntecedentePersonal
    {
        IEnumerable<AntecedentePersonal> GetAllAntecedentes();
        AntecedentePersonal AddAntecente(AntecedentePersonal antecedentePersonal);
        AntecedentePersonal UpdAntecente(AntecedentePersonal antecedentePersonal);
        void DelAntecente(int idAntecedente);
        AntecedentePersonal GetAntecedente(int idAntecedente);

    }
}