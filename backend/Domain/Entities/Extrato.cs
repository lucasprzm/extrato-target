using Domain.Enums;

namespace Domain.Entities
{
    public class Extrato
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public bool Avulso { get; set; }
        public Status Status { get; set; }
    }
}
