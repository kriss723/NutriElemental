using NutriElemental.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace NutriElemental.App.Persistencia
{
    public class RepositorioAntecedenteFamiliar : IRepositorioAntecedenteFamiliar
    {
        private readonly AppContext _appContext = new AppContext();

        IEnumerable<AntecedenteFamiliar> IRepositorioAntecedenteFamiliar.GetAllAntecedentes()
        {
            return _appContext.AntecedentesFamiliares;
        }

        AntecedenteFamiliar IRepositorioAntecedenteFamiliar.AddAntecedente(AntecedenteFamiliar antecedenteFamiliar)
        {
            var newAntecedente = _appContext.AntecedentesFamiliares.Add(antecedenteFamiliar);
            _appContext.SaveChanges();
            return newAntecedente.Entity;
        }

        void IRepositorioAntecedenteFamiliar.DeleteAntecedente(int idAntecedente)
        {
            var delAntecente = _appContext.AntecedentesFamiliares.Find(idAntecedente);
            if(delAntecente != null){
                _appContext.AntecedentesFamiliares.Remove(delAntecente);
                _appContext.SaveChanges();
            }
        }

        AntecedenteFamiliar IRepositorioAntecedenteFamiliar.GetAntecedente(int idAntecedente)
        {
            return _appContext.AntecedentesFamiliares.Find(idAntecedente);
        }

        AntecedenteFamiliar IRepositorioAntecedenteFamiliar.UpdateAntecedente(AntecedenteFamiliar antecedente)
        {
            var updAntecente = _appContext.AntecedentesFamiliares.Find(antecedente.Id);
            if(updAntecente != null){
                updAntecente.Nombre_Antecedente = antecedente.Nombre_Antecedente;
                updAntecente.Descripcion = antecedente.Descripcion;
                _appContext.SaveChanges();
            }
            return updAntecente;
        }

        
    }
}