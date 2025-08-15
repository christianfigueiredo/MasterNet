namespace MasterNet.Domain
{
    public class CursoPreco
    {
        public Guid? PrecoId { get; set; }
        public Preco? Preco { get; set; }
        public Guid? CursoId { get; set; }
        public Curso? Curso { get; set; }
    }
}