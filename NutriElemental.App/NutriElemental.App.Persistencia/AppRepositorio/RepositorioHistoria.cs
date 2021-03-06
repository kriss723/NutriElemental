using Microsoft.EntityFrameworkCore;
using NutriElemental.App.Dominio;
using NutriElemental.App.Persistencia;
using System.Collections.Generic;
using System.Linq;

namespace Nutrielemental.App.Persistencia
{
    public class RepositorioHistoria : IRepositorioHistoria
    {
        private readonly AppContext _appContext = new AppContext();

        //public List<AntecedenteFamiliar> AntecedentesFamiliares {get;set;}
        //public List<AntecedentePersonal> AntecedentesPersonales {get;set;}

        //public List<AntecedenteFamiliar> lista {get;set;}

        Historia IRepositorioHistoria.AddHistoria(Historia historia)
        {
            var HistoriaAdicionada = _appContext.Historias.Add(historia);
            _appContext.SaveChanges();
            return HistoriaAdicionada.Entity;

        }

        void IRepositorioHistoria.DeleteHistoria(int IdHistoria)
        {

            var HistoriaEncontrada = _appContext.Historias.Find(IdHistoria);
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
            return _appContext.Historias.Find(IdHistoria);
        }

        Historia IRepositorioHistoria.UpdateHistoria(Historia historia)
        {
            var HistoriaEncontrada = _appContext.Historias.Find(historia.Id);
            if (HistoriaEncontrada != null)
            {
                HistoriaEncontrada.Diagnostico = historia.Diagnostico;
                HistoriaEncontrada.Paciente = historia.Paciente;
                HistoriaEncontrada.AntecedentesFamiliares = historia.AntecedentesFamiliares;
                HistoriaEncontrada.AntecedentesPersonales = historia.AntecedentesPersonales;
                HistoriaEncontrada.SugerenciaNutricional = historia.SugerenciaNutricional;

                _appContext.SaveChanges();

            }

            return HistoriaEncontrada;

        }

        /*List<AntecedenteFamiliar> IRepositorioHistoria.GetAllAntecedentesFamiliares(int IdHistoria)
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
                                .Select(x => x.Nombre_Antecedente);

            
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
        }*/

    }
}