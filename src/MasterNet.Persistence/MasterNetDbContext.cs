using MasterNet.Domain;
using Microsoft.EntityFrameworkCore;

namespace MasterNet.Persistence
{
    public class MasterNetDbContext : DbContext
    {
        public MasterNetDbContext(DbContextOptions<MasterNetDbContext> options) : base(options) { }
       

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<CursoPreco> CursoPrecos { get; set; }
        public DbSet<Preco> Precos { get; set; }
        public DbSet<Instrutor> Instrutores { get; set; }
        public DbSet<Foto> Fotos { get; set; }
        public DbSet<CursoInstrutor> CursoInstrutores { get; set; }
        public DbSet<Qualificacao> Qualificacoes { get; set; }

    }
}