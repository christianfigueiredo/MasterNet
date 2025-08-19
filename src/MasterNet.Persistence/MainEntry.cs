
using MasterNet.Domain;
using MasterNet.Persistence;
using Microsoft.EntityFrameworkCore;

//criar um sessao de entityframework
using var context = new MasterNetDbContext();

var cursos = await context.Cursos!.ToListAsync();
var instrutores = await context.Instrutores!.ToListAsync();

var cursoNovo = new Curso()
{
    Id = Guid.NewGuid(),
    Titulo = "Programando em C#",
    Descricao = "Curso de C#",
    DataPublicacao = DateTime.UtcNow
};

context.Add(cursoNovo);
await context.SaveChangesAsync();

var instrutorNovo = new Instrutor()
{
    Id = Guid.NewGuid(),
    Nome = "Joao",
    Sobrenome = "Silva",
    GrauAcademico = "Mestre"
};

context.Add(instrutorNovo);
await context.SaveChangesAsync();

foreach (var curso in cursos)
{
    Console.WriteLine($"{curso.Titulo} : {curso.Descricao}");

}

foreach (var Instrutor in instrutores)
{
    Console.WriteLine($"{Instrutor.Id} : {Instrutor.Nome}");
}


