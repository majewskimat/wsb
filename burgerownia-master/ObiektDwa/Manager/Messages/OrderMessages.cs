using System;
using System.Collections.Generic;
using System.Text;
using ObiektDwa;

namespace ObiektDwa.Manager
{
    public static class OrderMessages
    {
        public static bool IsThatAll()
        {
            bool choice = false;

            string textMessage = "Is that all? ( 1 -Yes / 2 -No )";
            var halfWay = (Console.BufferWidth / 2) - (textMessage.Length / 2);
            Console.WriteLine();
            Console.SetCursorPosition(halfWay, Console.CursorTop);
            Console.WriteLine(textMessage);

            int.TryParse(Console.ReadLine().ToString(), out int key);
            if (!(key == 1 || key == 2))
            {
                Messages.Display("Please take available choice!");
                IsThatAll();
            }
            else
            {
                choice = key switch
                {
                    1 => true,
                    2 => false,
                    _ => false
                };
            }

            return choice;
        }

        public static void Summary(Order order)
        {
            Messages.Display("This is your order: ", true);
            Messages.Display("");
            order.OrderItems.ForEach(eachItem => Messages.Display($"- {eachItem}"));
        }

        public static void ThankYouForOrder()
        {
            Messages.PressAnyKeyToContinue("Thank you for placing order. It will be ready soon.");
        }
    }
}
