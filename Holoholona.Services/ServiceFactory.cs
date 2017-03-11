using Holoholona.Services.Animals;
using Holoholona.Services.Players;

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

        public static IPlayerService PlayerService {
            get
            {
                if (Debug)
                    return new PlayerMockService();
                return new PlayerProdService();
            }
        }
    }
}
