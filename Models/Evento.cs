
namespace EFCoreCrud.Models
{
    public class Evento
    {
        public Guid Id { get; set; }

        public string Titulo { get; set; }

        public DateTime Data { get; set; } = DateTime.Now;

        public bool Concluido { get; set; }
    }
}
