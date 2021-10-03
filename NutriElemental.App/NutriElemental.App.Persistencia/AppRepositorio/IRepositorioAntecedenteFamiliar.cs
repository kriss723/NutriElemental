using System.Collections.Generic;
using NutriElemental.App.Dominio;

namespace NutriElemental.App.Persistencia
{
    public interface IRepositorioAntecedenteFamiliar
    {
        IEnumerable<AntecedenteFamiliar> GetAllAntecedentes(); 
        AntecedenteFamiliar AddAntecedente(AntecedenteFamiliar antecedente);
        AntecedenteFamiliar UpdateAntecedente(AntecedenteFamiliar antecedente);
        void DeleteAntecedente (int idAntecedente);
        AntecedenteFamiliar GetAntecedente (int idAntecedente); 
    }
}