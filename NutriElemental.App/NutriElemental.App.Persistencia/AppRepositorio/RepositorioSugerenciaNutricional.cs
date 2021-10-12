using System.Collections.Generic;
using System.Linq;
using NutriElemental.App.Dominio;

namespace NutriElemental.App.Persistencia
{
    public class RepositorioSugerenciaNutricional : IRepositorioSugerenciaNutricional
    {
        private readonly AppContext _appContext = new AppContext();
        IEnumerable<SugerenciaNutricional> IRepositorioSugerenciaNutricional.GetAllSugerencias()
        {
            return _appContext.SugerenciasNutricionales;
        }

        SugerenciaNutricional IRepositorioSugerenciaNutricional.AddSugerencia(SugerenciaNutricional sugerencia)
        {
            var newSugerencia = _appContext.SugerenciasNutricionales.Add(sugerencia);
            _appContext.SaveChanges();
            return newSugerencia.Entity;
        }

        SugerenciaNutricional IRepositorioSugerenciaNutricional.GetSugerencia(int idSugerencia)
        {
            return _appContext.SugerenciasNutricionales.Find(idSugerencia);
        }

        SugerenciaNutricional IRepositorioSugerenciaNutricional.UpdateSugerencia(SugerenciaNutricional sugerencia)
        {
            var updSugerencia = _appContext.SugerenciasNutricionales.Find(sugerencia);
            if(updSugerencia != null)
            {
                updSugerencia.FechaHora = sugerencia.FechaHora;
                updSugerencia.Nombre_Sugerencia = sugerencia.Nombre_Sugerencia;
                updSugerencia.Descripcion = sugerencia.Descripcion;

                _appContext.SaveChanges();
            }
            return updSugerencia;
        }

        void IRepositorioSugerenciaNutricional.DeleteSugerencia(int idSugerencia)
        {
            var delResgistro = _appContext.SugerenciasNutricionales.Find(idSugerencia);
            if(delResgistro != null)
            {
                _appContext.SugerenciasNutricionales.Remove(delResgistro);
                _appContext.SaveChanges();
            }
        }
    }
}