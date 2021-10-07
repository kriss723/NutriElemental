using NutriElemental.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Nutrielemental.App.Persistencia
{
    public class RepositorioHistoria
    {
        private readonly NutriElemental.App.Persistencia.AppContext _appContext = new NutriElemental.App.Persistencia.AppContext();

        public IEnumerable<AntecedenteFamiliar> AntecedentesFamiliares {get;set;}
        public IEnumerable<AntecedentePersonal> AntecedentesPersonales {get;set;}

        Historia IRepositorioHistoria.AddHistoria(Historia historia)
        {
            var HistoriaAdicionada = _appContext.Historias.Add(historia);
            _appContext.SaveChanges();
            return HistoriaAdicionada.Entity;

        }

        void IRepositorioHistoria.DeleteHistoria(int IdHistoria)
        {

            var HistoriaEncontrada = _appContext.Historias.FirstOrDefault(h => h.Id == IdHistoria);
            if (HistoriaEncontrada == null)
                return;
            _appContext.Historias.Remove(HistoriaEncontrada);
            _appContext.SaveChanges();

        }

        IEnumerable<Historia> IRepositorioHistoria.GetAllHistorias()
        {
            return _appContext.Historias;
        }


        Historia IRepositorioHistoria.GetHistoria(int IdHistoria)
        {
            return _appContext.Historias.FirstOrDefault(h => h.Id == IdHistoria);
        }

        Historia IRepositorioHistoria.UpdateHistoria(Historia historia)
        {
            var HistoriaEncontrada = _appContext.Pacientes.FirstOrDefault(p => p.Id == historia.Id);
            if (HistoriaEncontrada != null)
            {
                //propiedades de la historia


                _appContext.SaveChanges();

            }

            return HistoriaEncontrada;

        }

        IEnumerable<AntecedenteFamiliar> IRepositorioHistoria.GetAllAntecedentesFamiliares(int IdHistoria)
        {
            //crear metodo para guardar los antecedenes en esta lista where 
        }


        IEnumerable<AntecedentePersonal> IRepositorioHistoria.GetAllAntecedentesPersonales(int IdHistoria)
        {
            //crear metodo para guardar los antecedenes en esta lista where 
        }

    }
}