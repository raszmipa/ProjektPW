namespace Interfaces
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        IProducer Producer { get; set; }
        int ReleaseYear { get; set; }
        int MinPlayers { get; set; }
        int MaxPlayers { get; set; }
        GameMechanic Mechanic { get; set; }
    }
}