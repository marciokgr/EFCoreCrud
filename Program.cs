using EFCoreCrud.Data;
using Microsoft.EntityFrameworkCore;
using EFCoreCrud.Models;

using (var context = new MyDataContext())
{
    //Adicionando evento..
    var evento = new Evento 
    { 
        Titulo = "Teste",
        Data = DateTime.Now,
    };
    context.Eventos.Add(evento);

    var eventoConcluido = new Evento
    {
        Titulo = "Teste concluido",
        Data = DateTime.Now,
        Concluido = true
    };
    context.Eventos.Add(eventoConcluido);

    context.SaveChanges(); //persistindo no banco

    var eventos = context.Eventos
        .AsNoTracking() //somente leitura, não será utilizado para update e etc..
        .Where(x => x.Concluido == true)
        .Select(x => new
        {
            Id = x.Id,
            Titulo = x.Titulo,            
        })
        .ToList();

    foreach(var item in eventos)
    {
        Console.WriteLine(item.Titulo);
    }
}
