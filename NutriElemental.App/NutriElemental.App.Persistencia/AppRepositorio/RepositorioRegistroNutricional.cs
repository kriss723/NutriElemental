using System.Collections.Generic;
using NutriElemental.App.Dominio;
using System.Linq;

namespace NutriElemental.App.Persistencia
{
    public class RepositorioRegistroNutricional : IRepositorioRegistroNutricional
    {
        private readonly AppContext _appContext = new AppContext();
        IEnumerable<RegistroNutricional> IRepositorioRegistroNutricional.GetAllRegistro()
        {
            return _appContext.RegistroNutricionales;
        }

        RegistroNutricional IRepositorioRegistroNutricional.GetRegistro(int idRegistro)
        {
            return _appContext.RegistroNutricionales.Find(idRegistro);
        }

        RegistroNutricional IRepositorioRegistroNutricional.AddRegistro(RegistroNutricional registroNutricional)
        {
            var newRegistro = _appContext.RegistroNutricionales.Add(registroNutricional);
            _appContext.SaveChanges();
            return newRegistro.Entity;
            
        }

        void IRepositorioRegistroNutricional.DelRegistro(int idResgistro)
        {
            var delRegistro = _appContext.RegistroNutricionales.Find(idResgistro);
            if(delRegistro != null)
            {
                _appContext.RegistroNutricionales.Remove(delRegistro);
                _appContext.SaveChanges();
            }
        }

        RegistroNutricional IRepositorioRegistroNutricional.UpdRegistro(RegistroNutricional registroNutricional)
        {
            var updRegistro = _appContext.RegistroNutricionales.Find(registroNutricional);
            if(updRegistro != null)
            {
                updRegistro.Cantidad = registroNutricional.Cantidad;
                updRegistro.Tipo = registroNutricional.Tipo;
                updRegistro.Hora_Registro = registroNutricional.Hora_Registro;
                updRegistro.lugar = registroNutricional.lugar;
                updRegistro.Actividad = registroNutricional.Actividad;
                updRegistro.Estado_Animo = registroNutricional.Estado_Animo;

                _appContext.SaveChanges();
            }
            return updRegistro;
        }
    }
}