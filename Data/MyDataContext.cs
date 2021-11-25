using Microsoft.EntityFrameworkCore;
using EFCoreCrud.Models;

namespace EFCoreCrud.Data
{
    //Contexto de dado do banco de dados
    public class MyDataContext : DbContext
    {
       

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseInMemoryDatabase(databaseName: "banco");
            options.LogTo(Console.WriteLine); //mostrando sqls sendo executados
 }

        public DbSet<Evento> Eventos { get; set; }  
    }
}
