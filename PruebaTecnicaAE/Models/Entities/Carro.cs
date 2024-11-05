using System.Numerics;

namespace PruebaTecnicaAE.Models.Entities
{
    public class Carro
    {
        public required int Id { get; set; }
        public required string Modelo { get; set; }
        public required string Marca { get; set; }
        public required string Placa { get; set; }

    }
}
