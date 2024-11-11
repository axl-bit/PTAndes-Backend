namespace PruebaTecnicaAE.Models.Entities
{
    public class Aparcamiento
    {
        public Aparcamiento()
        {
            CarrosAparcamiento = new List<Carro>();
        }

        public string EspacioAId { get; set; }
        public string NroPlaca { get; set; }

        public virtual ICollection <Carro> CarrosAparcamiento { get; set; }
    }
}
