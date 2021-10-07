using Microsoft.EntityFrameworkCore;
using NutriElemental.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Nutrielemental.App.Persistencia
{
    public class RepositorioHistoria: IRepositorioHistoria
    {
        private readonly NutriElemental.App.Persistencia.AppContext _appContext = new NutriElemental.App.Persistencia.AppContext();

        public List<AntecedenteFamiliar> AntecedentesFamiliares {get;set;}
        public List<AntecedentePersonal> AntecedentesPersonales {get;set;}

        public List<AntecedenteFamiliar> lista {get;set;}

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
            var HistoriaEncontrada = _appContext.Historias.FirstOrDefault(p => p.Id == historia.Id);
            if (HistoriaEncontrada != null)
            {
                //propiedades de la historia


                _appContext.SaveChanges();

            }

            return HistoriaEncontrada;

        }

        List<AntecedenteFamiliar> IRepositorioHistoria.GetAllAntecedentesFamiliares(int IdHistoria)
        {
            //crear metodo para guardar los antecedenes en esta lista where 
            
            foreach (var Antecedente in _appContext.AntecedentesFamiliares)
            {
                var AntecedenteEncontrado = _appContext.AntecedentesFamiliares.FirstOrDefault(a => a.HistoriaId == IdHistoria);

                AntecedentesFamiliares.Add(AntecedenteEncontrado);

            }

            return AntecedentesFamiliares;

            /*
            var Antecedentes =  _appContext.AntecedentesFamiliares
                                .Include("AntecedetesFamiliares")
                                .Where(x => x.HistoriaId == IdHistoria)
                                .Select(x => x.Nombre_Antecedente);*/

            
        }


        List<AntecedentePersonal> IRepositorioHistoria.GetAllAntecedentesPersonales(int IdHistoria)
        {
            //crear metodo para guardar los antecedenes en esta lista where 
            foreach (var Antecedente in _appContext.AntecedentesPersonales)
            {
                var AntecedenteEncontrado = _appContext.AntecedentesPersonales.FirstOrDefault(a => a.HistoriaId == IdHistoria);

                AntecedentesPersonales.Add(AntecedenteEncontrado);

            }

            return AntecedentesPersonales;
        }

    }
}