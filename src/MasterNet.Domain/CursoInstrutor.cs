namespace MasterNet.Domain
{
    public class CursoInstrutor
    {
        public Guid? IntrutorId { get; set; }
        public Instrutor? Instrutor { get; set; }
        public Guid? CursoId { get; set; }
        public Curso? Curso { get; set; }
    }
}