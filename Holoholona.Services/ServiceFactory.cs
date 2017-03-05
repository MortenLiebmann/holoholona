using Holoholona.Services.Animals;

namespace Holoholona.Services
{
    public static class ServiceFactory
    {
        private static bool Debug;

        static ServiceFactory()
        {
            Debug = true;
        }

        public static IAnimalService AnimalService {
            get
            {
                if (Debug)
                    return new AnimalMockService();
                return new AnimalProdService();
            }
        }
    }
}
