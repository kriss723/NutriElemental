using System.Collections.Generic;
using NutriElemental.App.Dominio;

namespace NutriElemental.App.Persistencia
{
    public interface IRepositorioRegistroNutricional
    {
        IEnumerable<RegistroNutricional> GetAllRegistro();
        RegistroNutricional AddRegistro(RegistroNutricional registroNutricional);
        RegistroNutricional UpdRegistro(RegistroNutricional registroNutricional);
        void DelRegistro(int idResgistro);
        RegistroNutricional GetRegistro(int idRegistro);
    }
}