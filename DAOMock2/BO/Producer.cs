using Interfaces;

namespace DAOMock2.BO
{
    public class Producer : IProducer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Producent #{Id}: {Name} - Kraj: {Country}";
        }
    }
}