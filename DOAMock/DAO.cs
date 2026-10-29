using System.Collections.Generic;
using DAOMock.BO;
using Interfaces;

namespace DAOMock
{
    public class DAO : IDAO
    {
        private List<IProducer> producers;
        private List<IProduct> products;

        public DAO()
        {
            IProducer p1 = new Producer { Id = 1, Name = "FryxGames", Country = "Szwecja" };
            IProducer p2 = new Producer { Id = 2, Name = "Feuerland Spiele", Country = "Niemcy" };
            IProducer p3 = new Producer { Id = 3, Name = "Dire Wolf", Country = "USA" };

            producers = new List<IProducer> { p1, p2, p3 };

            products = new List<IProduct>
            {
                new Product
                {
                    Id = 1,
                    Name = "Terraformacja Marsa",
                    Producer = p1,
                    ReleaseYear = 2016,
                    MinPlayers = 1,
                    MaxPlayers = 5,
                    Mechanic = GameMechanic.EngineBuilding
                },
                new Product
                {
                    Id = 2,
                    Name = "Ark Nova",
                    Producer = p2,
                    ReleaseYear = 2021,
                    MinPlayers = 1,
                    MaxPlayers = 4,
                    Mechanic = GameMechanic.TableauBuilding
                },
                new Product
                {
                    Id = 3,
                    Name = "Diuna: Imperium",
                    Producer = p3,
                    ReleaseYear = 2020,
                    MinPlayers = 1,
                    MaxPlayers = 4,
                    Mechanic = GameMechanic.DeckBuilding
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