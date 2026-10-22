using Interfaces;

namespace DAOMock.BO
{
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IProducer Producer { get; set; }
        public int ReleaseYear { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public GameMechanic Mechanic { get; set; }

        public override string ToString()
        {
            return $"[{Id}] \"{Name}\" ({ReleaseYear}) | Wydawca: {Producer.Name} | Gracze: {MinPlayers}-{MaxPlayers} | Mechanika: {Mechanic}";
        }
    }
}