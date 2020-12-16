using Burgerownia.API.Repositories;
using System.Collections.Generic;

namespace ObiektDwa
{
    public class BurgerService : IServiceable
    {
        private BurgerRepository BurgerRepository { get; }
        public BurgerService()
        {
            BurgerRepository = new BurgerRepository();
        }


        public Item[] Items { get => BurgerRepository.GetAll().ToArray(); }
        public int ItemsCount { get => Items.Length; }

        public Item GetItemById(int burgerNumber)
        {
            return Items[burgerNumber];
        }
    }
}
