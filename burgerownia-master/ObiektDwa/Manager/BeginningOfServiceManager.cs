using System;
using System.Collections.Generic;
using System.Text;

namespace ObiektDwa.Manager
{
    class BeginningOfServiceManager
    {
        internal void BeginingOfService(MenuManager menuManager, bool clear = false)
        {

            MenuService menuService = new MenuService();
            if (menuManager.order.OrderItems.Count != 0)
            {
                menuService.AddToMenu("Services", new Item("Change the order") { IsService = true });
                menuService.ChangeItem("Services", "Take Order", new Item("Order more") { IsService = true });
            }
            menuManager.ShowMenu(menuService.Services, clear);
            menuManager.TakeChoiceFromPassedMenu(menuService.Services);
        }
    }
}
