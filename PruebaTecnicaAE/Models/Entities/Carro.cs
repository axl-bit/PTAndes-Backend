using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace PruebaTecnicaAE.Models.Entities
{
    public class Carro
    {
        public Carro() 
        { 
            ClienteCarro = new List<Cliente>();
        }

        public string CarroId { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
        public string CarroApDir { get; set; }
     
        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual Apar CarroAp { get; set; }

    }
}
