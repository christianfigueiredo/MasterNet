namespace MasterNet.Domain
{
    public class Instrutor : BaseEntity
    {
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public string? GrauAcademico { get; set; }
        public ICollection<CursoInstrutor>? CursosInstrutores { get; set; }
        public ICollection<Curso>? Cursos { get; set; }
    }
}