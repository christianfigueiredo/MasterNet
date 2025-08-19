
using MasterNet.Domain;
using MasterNet.Persistence;
using Microsoft.EntityFrameworkCore;

//criar um sessao de entityframework
using var context = new MasterNetDbContext();

var cursos = await context.Cursos!.ToListAsync();
var instrutores = await context.Instrutores!.ToListAsync();



foreach (var curso in cursos)
{
    Console.WriteLine($"{curso.Titulo} : {curso.Descricao}");

}

foreach (var Instrutor in instrutores)
{
    Console.WriteLine($"{Instrutor.Id} : {Instrutor.Nome} : {Instrutor.GrauAcademico}");
}


