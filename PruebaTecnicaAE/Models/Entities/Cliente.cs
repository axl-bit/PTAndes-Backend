using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;

namespace PruebaTecnicaAE.Models.Entities
{
    public class Cliente
    {
        public Cliente() 
        {
            
        }

        public string ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DocIdentificacion { get; set; }
        public string CarroIdCliente   { get; set; }

        public virtual Carro CarrosDeCliente { get; set; }

    }
}
