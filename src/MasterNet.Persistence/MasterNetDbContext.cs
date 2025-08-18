using MasterNet.Domain;
using Microsoft.EntityFrameworkCore;

namespace MasterNet.Persistence
{
    public class MasterNetDbContext : DbContext
    {

        public MasterNetDbContext(DbContextOptions<MasterNetDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=masternet.db")
            .LogTo(Console.WriteLine,
            new [] {DbLoggerCategory.Database.Command.Name},
            Microsoft.Extensions.Logging.LogLevel.Information
            ).EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Curso>().ToTable("cursos");
            modelBuilder.Entity<CursoPreco>().ToTable("curso_precos");
            modelBuilder.Entity<Preco>().ToTable("precos");
            modelBuilder.Entity<Instrutor>().ToTable("instrutores");
            modelBuilder.Entity<Foto>().ToTable("imagens");
            modelBuilder.Entity<CursoInstrutor>().ToTable("curso_instrutores");
            modelBuilder.Entity<Qualificacao>().ToTable("qualificacoes");

            modelBuilder.Entity<Preco>().Property(p => p.PrecoAtual).HasPrecision(10, 2);
            modelBuilder.Entity<Preco>().Property(p => p.PrecoPromocional).HasPrecision(10, 2);
            modelBuilder.Entity<Preco>().Property(p => p.Nome).HasColumnType("VARCHAR").HasMaxLength(250);
            
        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<CursoPreco> CursoPrecos { get; set; }
        public DbSet<Preco> Precos { get; set; }
        public DbSet<Instrutor> Instrutores { get; set; }
        public DbSet<Foto> Fotos { get; set; }
        public DbSet<CursoInstrutor> CursoInstrutores { get; set; }
        public DbSet<Qualificacao> Qualificacoes { get; set; }

    }
}