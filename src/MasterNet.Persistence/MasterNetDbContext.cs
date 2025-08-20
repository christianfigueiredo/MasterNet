using Bogus;
using MasterNet.Domain;
using MasterNet.Persistence.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MasterNet.Persistence
{
    public class MasterNetDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Curso> Cursos { get; set; }
        //public DbSet<CursoPreco> CursoPrecos { get; set; }
        public DbSet<Preco> Precos { get; set; }
        public DbSet<Instrutor> Instrutores { get; set; }
        public DbSet<Foto> Fotos { get; set; }
        //public DbSet<CursoInstrutor> CursoInstrutores { get; set; }
        public DbSet<Qualificacao> Qualificacoes { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }
        
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=masternet.db")
            .LogTo(Console.WriteLine,
            new[] { DbLoggerCategory.Database.Command.Name },
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

            modelBuilder.Entity<Curso>()
            .HasMany(m => m.Fotos)
            .WithOne(m => m.Curso)
            .HasForeignKey(p => p.CursoId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Curso>()
            .HasMany(m => m.Qualificacao)
            .WithOne(m => m.Curso)
            .HasForeignKey(p => p.CursoId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Curso>()
            .HasMany(m => m.Precos)
            .WithMany(m => m.Cursos)
            .UsingEntity<CursoPreco>(
                j => j.HasOne(p => p.Preco).WithMany(p => p.CursosPrecos)
                .HasForeignKey(p => p.PrecoId),
                j => j.HasOne(p => p.Curso).WithMany(p => p.CursosPrecos)
                .HasForeignKey(p => p.CursoId),
                j =>
                {
                    j.HasKey(t => new { t.CursoId, t.PrecoId });
                }
                );

            modelBuilder.Entity<Curso>()
            .HasMany(m => m.Instrutores)
            .WithMany(m => m.Cursos)
            .UsingEntity<CursoInstrutor>(
                j => j.HasOne(p => p.Instrutor).WithMany(p => p.CursosInstrutores)
                .HasForeignKey(p => p.IntrutorId),
                j => j.HasOne(p => p.Curso).WithMany(p => p.CursosInstrutores)
                .HasForeignKey(p => p.CursoId),
                j =>
                {
                    j.HasKey(t => new { t.CursoId, t.IntrutorId });
                }
                );

            modelBuilder.Entity<Curso>().HasData(DataMaster().Item1);
            modelBuilder.Entity<Instrutor>().HasData(DataMaster().Item2);
            modelBuilder.Entity<Preco>().HasData(DataMaster().Item3);

            CarregarDataSeguridade(modelBuilder);
            

        }

        private void CarregarDataSeguridade(ModelBuilder modelBuilder)
        {
            var adminId = Guid.NewGuid().ToString();
            var clientId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = adminId,
                    Name = "admin",
                    
                }
            );
        }

        public Tuple<Curso[], Instrutor[], Preco[]> DataMaster()
        {
            var cursos = new List<Curso>();
            var faker = new Faker();

            for (var i = 1; i < 10; i++)
            {
                var cursoId = Guid.NewGuid();
                cursos.Add(
                    new Curso
                    {
                        Id = cursoId,
                        Descricao = faker.Commerce.ProductDescription(),
                        Titulo = faker.Commerce.ProductName(),
                        DataPublicacao = DateTime.UtcNow
                    }
                );
            }

            var precoId = Guid.NewGuid();
            var preco = new Preco
            {
                Id = precoId,
                PrecoAtual = 10.0m,
                PrecoPromocional = 8.0m,
                Nome = "Preco Padrao"
            };

            var precos = new List<Preco>
            {
                preco
            };


            var fakeInstrutor = new Faker<Instrutor>()
                .RuleFor(p => p.Id, _ => Guid.NewGuid())
                .RuleFor(p => p.Nome, f => f.Name.FullName())
                .RuleFor(p => p.Sobrenome, f => f.Name.LastName())
                .RuleFor(p => p.GrauAcademico, f => f.Name.JobTitle());

            var instrutores = fakeInstrutor.Generate(10);


            return Tuple.Create(cursos.ToArray(), instrutores.ToArray(), precos.ToArray());
        }
        
    }
}