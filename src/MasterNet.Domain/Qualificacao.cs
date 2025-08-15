namespace MasterNet.Domain
{
    public class Qualificacao : BaseEntity
    {
        public string? Aluno { get; set; }
        public int Ponto { get; set; }
        public string? Comentario { get; set; }
        public Guid? CursoId { get; set; }
        public Curso? Curso { get; set; }        
    }
}