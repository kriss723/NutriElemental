using NutriElemental.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace NutriElemental.App.Persistencia
{
    public class RepositorioCoach : IRepositorioCoach
    {
        private readonly NutriElemental.App.Persistencia.AppContext _appContext = new NutriElemental.App.Persistencia.AppContext();

        public IEnumerable<Coach> GetAllCoach() {
             return _appContext.Coachs;
        }
        
        public Coach AddCoach (Coach coach) {
            var newCoach = _appContext.Coachs.Add(coach);
            _appContext.SaveChanges();
            return newCoach.Entity;
        }

        public Coach UpdateCoach (Coach coach){
            var currentCoach = _appContext.Coachs.FirstOrDefault(c => c.Id == coach.Id);
            if (currentCoach != null)
            {
                currentCoach.TarjetaProfesional = coach.TarjetaProfesional;
                currentCoach.HorasLaborales = coach.HorasLaborales;
                _appContext.SaveChanges();
            }
            return currentCoach;
        }

        public void DeleteCoach (string CedulaCoach){
            var coachFound = _appContext.Coachs.FirstOrDefault(c => c.Cedula == CedulaCoach);
            if (coachFound == null)
                return;
            _appContext.Coachs.Remove(coachFound);
            _appContext.SaveChanges();
        }

        public Coach GetCoach (string CedulaCoach){
            return _appContext.Coachs.FirstOrDefault(c => c.Cedula == CedulaCoach);
        }

    }
}