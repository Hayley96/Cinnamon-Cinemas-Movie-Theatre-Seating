using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSeatingBooking.UI
{
    public static class Helpers
    {
        public static void ClearConsoleLinesAbove(int numberoflinesabove)
        {
            if (!Console.IsOutputRedirected)
                Console.SetCursorPosition(0, Console.CursorTop - numberoflinesabove);
            ClearCurrentConsoleLine();
        }

        public static void ClearCurrentConsoleLine()
        {
            if (!Console.IsOutputRedirected)
            {
                int currentLineCursor = Console.CursorTop;
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, currentLineCursor);
            }

        }
    }
}