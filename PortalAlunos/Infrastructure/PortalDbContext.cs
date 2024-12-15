using Microsoft.EntityFrameworkCore;

namespace PortalAlunos.Infrastructure
{
    public class PortalDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=portal_do_aluno;User Id=postgres;Password=123;");
        }
    }
}
