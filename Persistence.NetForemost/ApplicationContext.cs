using Common.NetForemost;
using Microsoft.EntityFrameworkCore;

namespace Persistence.NetForemost
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
           : base(options)
        {
        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Prioridad> Prioridad { get; set; }
        public DbSet<Tareas> Tareas { get; set; }
    }
}
