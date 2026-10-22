using System;
using Interfaces;

namespace ProjektPW
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Odpowiedź na Zadanie 8: Dzięki interfejsom podmiana bazy danych z DAOMock na DAOMock2
            // wymaga zmiany wyłącznie w JEDNYM miejscu (w poniższej linijce przy tworzeniu obiektu):
            IDAO dao = new DAOMock.DAO();
            // IDAO dao = new DAOMock2.DAO();

            Console.WriteLine("DOSTĘPNE MECHANIKI GIER");
            foreach (string mechanicName in Enum.GetNames(typeof(GameMechanic)))
            {
                Console.WriteLine($"- {mechanicName}");
            }

            Console.WriteLine("\nPRODUCENCI");
            foreach (IProducer producer in dao.GetAllProducers())
            {
                Console.WriteLine(producer);
            }

            Console.WriteLine("\nGRY PLANSZOWE");
            foreach (IProduct product in dao.GetAllProducts())
            {
                Console.WriteLine(product);
            }
        }
    }
}