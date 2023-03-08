using ASP.NET.NovaPasta;
using Microsoft.EntityFrameworkCore; //biblioteca

namespace ASP.NET.Data
{
    public class SistemaDB : DbContext
    {
        public SistemaDB(DbContextOptions<SistemaDB> options)
            : base(options)
        {
        }
        //trabalhando com ORM: facilita com o banco de dados
        //fazer toda a estrutura de entidade pra dentro do código
        public DbSet<EquipeModel> Equipes { get; set; }
        public DbSet<FuncionarioModel> Funcionarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EquipeModel>()
                .HasData(
                    new EquipeModel { Id = 1, Nome = "contador", setor = "financeiro" });
            
        }
    }
}
