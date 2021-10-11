using System.Collections.Generic;
using NutriElemental.App.Dominio;

namespace NutriElemental.App.Persistencia
{
    public interface IRepositorioNutricionista
    {
        IEnumerable<Nutricionista> GetAllNutricionista(); 
        Nutricionista AddNutricionista (Nutricionista nutricionista);
        Nutricionista UpdateNutricionista (Nutricionista nutricionista);
        void DeleteNutricionista (string IdNutricionista);
        Nutricionista GetNutricionista (string cedulaNutricionista); 
        
    }
}