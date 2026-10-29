using System;
using System.Configuration;
using Interfaces;

namespace ProjektPW
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string libraryName = ConfigurationManager.AppSettings["DAOLibraryName"];
            Console.WriteLine($"=== Wczytywanie bazy z pliku: {libraryName} ===\n");

            BLC.BLC blc = BLC.BLC.GetInstance(libraryName);

            Console.WriteLine("=== DOSTĘPNE MECHANIKI GIER ===");
            foreach (string mechanicName in Enum.GetNames(typeof(GameMechanic)))
            {
                Console.WriteLine($"- {mechanicName}");
            }

            Console.WriteLine("\n=== PRODUCENCI ===");
            foreach (IProducer producer in blc.GetProducers())
            {
                Console.WriteLine(producer);
            }

            Console.WriteLine("\n=== PRODUKTY (GRY PLANSZOWE) ===");
            foreach (IProduct product in blc.GetProducts())
            {
                Console.WriteLine(product);
            }
        }
    }
}