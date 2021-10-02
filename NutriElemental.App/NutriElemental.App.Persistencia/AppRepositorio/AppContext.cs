using Microsoft.EntityFrameworkCore;
using NutriElemental.App.Dominio;

//Nombre del espacio de trabajo
namespace NutriElemental.App.Persistencia
{
    public class AppContext:DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Paciente> Pacientes {get;set;}
        public DbSet<Coah> Coahs {get;set;}
        public DbSet<Nutricionista> Nutricionistas {get;set;}
        public DbSet<Historia> Historias {get;set;}
        public DbSet<RegistroNutricional> RegistroNutricionales {get;set;}
        public DbSet<SugerenciaNutricional> SugerenciasNutricionales {get;set;} 
        public DbSet<Antecedente> Antecedentes {get;set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = NutriAppDB");
            }
        }

    }

    
}
