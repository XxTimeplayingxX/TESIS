using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DB.DATA
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options) { }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<SignosVitales> SignosVitales { get; set; }
        public DbSet<CitaMedica> CitaMedicas { get; set; }
        public DbSet<CitaMedicaDiagnostico> CitaMedicaDiagnosticos { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }
        public DbSet<DiagnosticoGeneralEnfermedades> DiagnosticoGeneralEnfermedades { get; set; }
        public DbSet<DetalleReceta> DetalleRecetas { get; set; }
        public DbSet<Receta> Recetas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CitaMedica>()
                .HasOne(cm => cm.Paciente)
                .WithMany()
                .HasForeignKey(cm => cm.PacienteID)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<CitaMedica>()
                .HasOne(cm => cm.CitaMedicaDiagnostico)
                .WithOne(cmd => cmd.CitaMedica)
                .HasForeignKey<CitaMedicaDiagnostico>(d => d.CitaMedicaID);

        }
    }
}
