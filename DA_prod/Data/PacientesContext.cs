using DA_prod.Models;
using Microsoft.EntityFrameworkCore;


namespace DA_prod.Data
{
    public class PacientesContext : DbContext
    {
        public PacientesContext(DbContextOptions<PacientesContext> options) : base(options) { }

        public DbSet<Pacientes> paciente { get; set; }

        public DbSet<Servidores> servidor { get; set; }

        public DbSet<Egresado> Egresado { get; set; }
    }
}
