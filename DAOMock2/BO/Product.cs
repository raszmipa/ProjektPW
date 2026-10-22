using Interfaces;

namespace DAOMock2.BO
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
            return $"Gra #{Id}: {Name} [{Mechanic}], Wydawca: {Producer.Name}, Liczba graczy: {MinPlayers}-{MaxPlayers}, Rok: {ReleaseYear}";
        }
    }
}