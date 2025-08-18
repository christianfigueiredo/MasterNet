namespace MasterNet.Domain
{
    public class Curso : BaseEntity
    {
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime? DataPublicacao { get; set; }        
        public ICollection<Qualificacao>? Qualificacao { get; set; }
        public ICollection<Preco>? Precos { get; set; }
        public ICollection<CursoInstrutor>? CursosInstrutores { get; set; }
        public ICollection<CursoPreco>? CursosPrecos { get; set; }
        public ICollection<Instrutor>? Instrutores { get; set; }
        public ICollection<Foto>? Fotos { get; set; }


    }
}