using System.Collections.Generic;
using System.Linq;
using NutriElemental.App.Dominio;

namespace NutriElemental.App.Persistencia
{
    public class RepositorioNutricionista : IRepositorioNutricionista
    {
        private readonly AppContext _appContext = new AppContext();

        IEnumerable<Nutricionista> IRepositorioNutricionista.GetAllNutricionista()
        {
            return _appContext.Nutricionistas;
        }

        Nutricionista IRepositorioNutricionista.GetNutricionista(string cedulaNutricionista)
        {
            return _appContext.Nutricionistas.Find(cedulaNutricionista);
        }

        Nutricionista IRepositorioNutricionista.AddNutricionista(Nutricionista nutricionista)
        {
            var newNutricionista = _appContext.Nutricionistas.Add(nutricionista);
            _appContext.SaveChanges();
            return newNutricionista.Entity;

        }

        void IRepositorioNutricionista.DeleteNutricionista(string IdNutricionista)
        {
            var DelNutrionista = _appContext.Nutricionistas.Find(IdNutricionista);
            if(DelNutrionista != null)
            {
                _appContext.Nutricionistas.Remove(DelNutrionista);
                _appContext.SaveChanges();
            }
        }

        Nutricionista IRepositorioNutricionista.UpdateNutricionista(Nutricionista nutricionista)
        {
            var UpdNutricionista = _appContext.Nutricionistas.Find(nutricionista.Id);
            if(UpdNutricionista != null)
            {
                UpdNutricionista.Nombre = nutricionista.Nombre;
                UpdNutricionista.Apellido = nutricionista.Apellido;
                UpdNutricionista.Direccion = nutricionista.Direccion;
                UpdNutricionista.Celular = nutricionista.Celular;
                UpdNutricionista.Email = nutricionista.Email;
                UpdNutricionista.Genero = nutricionista.Genero;
                UpdNutricionista.Especialidad = nutricionista.Especialidad;
                UpdNutricionista.RegistroRethus = nutricionista.RegistroRethus;
                
                _appContext.SaveChanges();
            }
            return UpdNutricionista;
        }
    }
}