using System.Collections.Generic;
using System.Linq;
using NutriElemental.App.Dominio;

namespace NutriElemental.App.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext = new AppContext();

        /*public RepositorioPaciente(AppContext _appContext)
        {
            this._appContext = _appContext;
        }*/

        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
            var newPaciente = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return newPaciente.Entity;
        }

        void IRepositorioPaciente.DeletePaciente(string cedulaPaciente)
        {
            var DelPaciente = _appContext.Pacientes.Find(cedulaPaciente);
            if(DelPaciente == null)
                return;
            _appContext.Pacientes.Remove(DelPaciente);
            _appContext.SaveChanges();
        }

        Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        {
            var UpdPaciente = _appContext.Pacientes.Find(paciente.Id);
            if(UpdPaciente != null)
            {
                UpdPaciente.Cedula = paciente.Cedula; 
                UpdPaciente.Nombre = paciente.Nombre;
                UpdPaciente.Apellido = paciente.Apellido;
                UpdPaciente.Direccion = paciente.Direccion; 
                UpdPaciente.Celular = paciente.Celular;
                //UpdPaciente.Email = paciente.Email;
                //UpdPaciente.Password = paciente.Password;
                UpdPaciente.Genero = paciente.Genero;
                UpdPaciente.Latitud = paciente.Latitud;
                UpdPaciente.Longitud = paciente.Longitud;
                UpdPaciente.Ciudad = paciente.Ciudad;
                UpdPaciente.FechaNacimiento = paciente.FechaNacimiento;
                UpdPaciente.Coach = paciente.Coach;
                UpdPaciente.Nutricionista = paciente.Nutricionista;
                UpdPaciente.RegistroNutricional = paciente.RegistroNutricional;

                _appContext.SaveChanges();
            }
            return UpdPaciente;
        }

        Paciente IRepositorioPaciente.GetPaciente(string cedulaPaciente)
        {
            return _appContext.Pacientes.Find(cedulaPaciente);
        }

        IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
        {
            return _appContext.Pacientes;
        }

        /*Nutricionista IRepositorioPaciente.AsignarMedico(string cedulaPaciente, int idNutricionista)
        {
            var ccPaciente = _appContext.Pacientes.FirstOrDefault(p => p.Cedula == cedulaPaciente);
            var idenNutricionista = _appContext.Nutricionistas.FirstOrDefault(p => p.Id == idNutricionista);
            //var Idnutri = _appContext.Pacientes.FirstOrDefault(p => p.CoachId == idenNutricionista);
            
        }*/


    }
}