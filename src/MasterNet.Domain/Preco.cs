namespace MasterNet.Domain
{
    public class Preco : BaseEntity
    {
        public string? Nome { get; set; }
        public decimal PrecoAtual { get; set; }
        public decimal PrecoPromocional { get; set; }
        public ICollection<CursoPreco>? CursosPrecos { get; set; }
        public ICollection<Curso>? Cursos { get; set; }

    }
}