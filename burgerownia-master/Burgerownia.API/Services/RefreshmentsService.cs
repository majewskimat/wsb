using System.Collections.Generic;

namespace ObiektDwa
{
    public class RefreshmentsService : IServiceable
    {
        public Item[] Items => refreshments;
        public int ItemsCount => refreshments.Length;

        private Item[] refreshments = new Item[]
        {
            new Item("Water",new List<Ingredient>(){ new Ingredient("water",1.00)}),
            new Item("Pepsi",new List<Ingredient>(){ new Ingredient("Pepsi",3.00)})
        };

        public Item GetItemById(int refreshmentNumber)
        {
            return Items[refreshmentNumber];
        }
    }
}