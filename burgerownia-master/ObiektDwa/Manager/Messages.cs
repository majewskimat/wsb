using System;

namespace ObiektDwa
{
    public class Messages
    {
        internal static void Display(string textMessage, bool clear = false)
        {
            if (clear) Console.Clear();
            Console.WriteLine(textMessage);
        }

        internal static void PressAnyKeyToContinue(string textMessage = "")
        {
            if (textMessage == "")
            {
                textMessage = "press any key to continue";
            }
            var halfWay = (Console.BufferWidth / 2) - (textMessage.Length / 2);
            Console.WriteLine();
            Console.SetCursorPosition(halfWay, Console.CursorTop);
            Console.WriteLine(textMessage);
            Console.WriteLine();
            Console.ReadKey(true);
        }

        internal static void Display(params string[] msgs)
        {
            for (int i = 0; i < msgs.Length; i++)
            {
                Display(msgs[i]);
            }
        }

        
    }
}