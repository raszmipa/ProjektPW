using System.Collections.Generic;
using DAOMock2.BO;
using Interfaces;

namespace DAOMock2
{
    public class DAO : IDAO
    {
        private IProducer[] producers;
        private IProduct[] products;

        public DAO()
        {
            IProducer p1 = new Producer { Id = 10, Name = "Rio Grande Games", Country = "USA" };
            IProducer p2 = new Producer { Id = 20, Name = "Inside Up Games", Country = "Kanada" };
            IProducer p3 = new Producer { Id = 30, Name = "Deep Water Games", Country = "USA" };

            producers = new IProducer[] { p1, p2, p3 };

            products = new IProduct[]
            {
                new Product
                {
                    Id = 101,
                    Name = "Race for the Galaxy",
                    Producer = p1,
                    ReleaseYear = 2007,
                    MinPlayers = 2,
                    MaxPlayers = 4,
                    Mechanic = GameMechanic.TableauBuilding
                },
                new Product
                {
                    Id = 102,
                    Name = "Ziemia (Earth)",
                    Producer = p2,
                    ReleaseYear = 2023,
                    MinPlayers = 1,
                    MaxPlayers = 5,
                    Mechanic = GameMechanic.EngineBuilding
                },
                new Product
                {
                    Id = 103,
                    Name = "Fantastyczne Fabryki",
                    Producer = p3,
                    ReleaseYear = 2019,
                    MinPlayers = 1,
                    MaxPlayers = 5,
                    Mechanic = GameMechanic.EngineBuilding
                }
            };
        }

        public IEnumerable<IProducer> GetAllProducers()
        {
            return producers;
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            return products;
        }
    }
}