using NutriElemental.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace NutriElemental.App.Persistencia
{
    public class RepositorioCoach : IRepositorioCoach
    {
        private readonly AppContext _appContext = new AppContext();

        public IEnumerable<Coach> GetAllCoach() {
             return _appContext.Coachs;
        }
        
        public Coach AddCoach (Coach coach) {
            var newCoach = _appContext.Coachs.Add(coach);
            _appContext.SaveChanges();
            return newCoach.Entity;
        }

        public Coach UpdateCoach (Coach coach){
            var currentCoach = _appContext.Coachs.Find(coach.Id);
            if (currentCoach != null)
            {
                currentCoach.Nombre = coach.Nombre;
                currentCoach.Apellido = coach.Apellido;
                currentCoach.Cedula = coach.Cedula;
                currentCoach.Email = coach.Email;
                currentCoach.Celular = coach.Celular;
                currentCoach.Genero = coach.Genero;
                currentCoach.TarjetaProfesional = coach.TarjetaProfesional;
                currentCoach.HorasLaborales = coach.HorasLaborales;
                _appContext.SaveChanges();
            }
            return currentCoach;
        }

        public void DeleteCoach (int idCoach){
            var coachFound = _appContext.Coachs.Find(idCoach);
            if (coachFound == null)
                return;
            _appContext.Coachs.Remove(coachFound);
            _appContext.SaveChanges();
        }

        public Coach GetCoach (int idCoach){
            return _appContext.Coachs.Find(idCoach);
        }

    }
}