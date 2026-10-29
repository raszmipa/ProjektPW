using System;
using System.Collections.Generic;
using System.Reflection;
using Interfaces;

namespace BLC
{
    public sealed class BLC
    {
        private static BLC instance;
        private IDAO dao;

        private BLC(string libraryPath)
        {
            Assembly assembly = Assembly.UnsafeLoadFrom(libraryPath);
            Type daoType = null;

            foreach (Type type in assembly.GetTypes())
            {
                if (type.IsAssignableTo(typeof(IDAO)) && !type.IsInterface)
                {
                    daoType = type;
                    break;
                }
            }

            if (daoType == null)
            {
                throw new InvalidOperationException("Nie znaleziono klasy implementującej IDAO w podanej bibliotece.");
            }

            dao = (IDAO)Activator.CreateInstance(daoType);
        }

        public static BLC GetInstance(string libraryPath)
        {
            if (instance == null)
            {
                instance = new BLC(libraryPath);
            }
            return instance;
        }

        public IEnumerable<IProducer> GetProducers()
        {
            return dao.GetAllProducers();
        }

        public IEnumerable<IProduct> GetProducts()
        {
            return dao.GetAllProducts();
        }
    }
}