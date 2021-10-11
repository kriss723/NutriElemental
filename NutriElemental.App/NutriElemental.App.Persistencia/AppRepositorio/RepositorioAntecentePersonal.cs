using System.Collections.Generic;
using System.Linq;
using NutriElemental.App.Dominio;

namespace NutriElemental.App.Persistencia
{
    public class RepositorioAntecedentePersonal : IRepositorioAntecedentePersonal
    {
        private readonly AppContext _appContext = new AppContext();
        IEnumerable<AntecedentePersonal> IRepositorioAntecedentePersonal.GetAllAntecedentes()
        {
            return _appContext.AntecedentesPersonales;
        }

        AntecedentePersonal IRepositorioAntecedentePersonal.AddAntecente(AntecedentePersonal antecedentePersonal)
        {
            var newAntecedente = _appContext.AntecedentesPersonales.Add(antecedentePersonal);
            _appContext.SaveChanges();
            return newAntecedente.Entity;
        }

        void IRepositorioAntecedentePersonal.DelAntecente(int idAntecedente)
        {
            var delAntecedente = _appContext.AntecedentesPersonales.Find(idAntecedente);
            if(delAntecedente != null)
            {
                _appContext.AntecedentesPersonales.Remove(delAntecedente);
                _appContext.SaveChanges();
            }
        }

        AntecedentePersonal IRepositorioAntecedentePersonal.GetAntecedente(int idAntecedente)
        {
            return _appContext.AntecedentesPersonales.Find(idAntecedente);
        }

        AntecedentePersonal IRepositorioAntecedentePersonal.UpdAntecente(AntecedentePersonal antecedentePersonal)
        {
            var updAntecente = _appContext.AntecedentesPersonales.Find(antecedentePersonal.Id);
            if(updAntecente != null)
            {
                updAntecente.Nombre_Antecedente = antecedentePersonal.Nombre_Antecedente;
                updAntecente.Descripcion = antecedentePersonal.Descripcion;

                _appContext.SaveChanges();
            }
            return updAntecente;
        }
    }
}