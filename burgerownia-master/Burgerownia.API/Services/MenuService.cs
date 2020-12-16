using System;
using System.Collections.Generic;
using System.Linq;

namespace ObiektDwa
{
    public class MenuService
    {
        private Item[] menus = new Item[]
        {
        new Item("Burgers"),
        new Item("Refreshments"),
        new Item("Nothing thanks")
        };

        private Item[] services = new Item[]
        {
        new Item("Take Order") {IsService = true },
        new Item("Check, please") {IsService = true }
        };

        public void AddToMenu(string whichMenu, Item whatToAdd)
        {
            List<Item> temp;
            switch (whichMenu)
            {
                case "Services":
                    temp = services.ToList();
                    temp.Add(whatToAdd);
                    services = temp.ToArray();
                    break;
                case "Menus":
                    temp = menus.ToList();
                    temp.Add(whatToAdd);
                    menus = temp.ToArray();
                    break;
            }
        }

        public void ChangeItem(string whichMenu, string whatToReplace, Item withWhat)
        {
            List<Item> temp;
            switch (whichMenu)
            {
                case "Services":
                    temp = services.ToList();
                    temp.Remove(temp.Find(item => item.Name == whatToReplace));
                    services = temp.ToArray();
                    break;
                case "Menus":
                    temp = menus.ToList();
                    temp.Remove(temp.Find(item => item.Name == whatToReplace));
                    menus = temp.ToArray();
                    break;
            }
            AddToMenu(whichMenu, withWhat);
        }

        public Item[] Menus { get => menus; }
        public Item[] Services { get => services; }
    }
}
