using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class AplicationContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Enfermera> Enfermeras { get; set; }
        public DbSet<FamiliarDesignado> Familiar { get; set; }
        public DbSet<Historia> Historias { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<SignoVital> Signos { get; set; }
        public DbSet<SugerenciaCuidado> Sugerencias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Server=localhost;Database=HospiEnCasaData;User Id=sa;Password=Se13052018;");
            }
        }
    }
}