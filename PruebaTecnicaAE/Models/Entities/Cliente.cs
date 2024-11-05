using System.Security.AccessControl;

namespace PruebaTecnicaAE.Models.Entities
{
    public class Cliente
    {

        public Guid Id { get; set; }
        public required string Nombres { get; set; }
        public required string Apellidos { get; set; }
        public required string DocIdentificacion { get; set; }
        public string Celular { get; set; }

    }
}
