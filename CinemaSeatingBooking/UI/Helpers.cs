using System.Runtime.CompilerServices;

namespace CinemaSeatingBooking.UI
{
    public static class Helpers
    {
        public static bool ParameterErrorHandler<T>(T value, [CallerArgumentExpression("value")] string expression = "")
        {
            Console.WriteLine($"Incorrect input value: {value} passed in property: {expression}");
            return false;
        }

        public static string DisplayClasses(Dictionary<string, Action> dict)
        {
            List<string> classes = new();
            foreach (var item in dict.Keys)
            {
                AddToList(classes, item);
            }
            return ConsoleMenu.MultipleChoice(true, classes);
        }

        public static List<T> AddToList<T>(this List<T> list, T item)
        {
            list.Add(item);
            return list;
        }

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
        public static void ExitProgram()
        {
            Console.Write("\rNo More Bookings Available. Press any key to exit...");
            Console.ReadKey(true);
            Console.Clear();
            Environment.Exit(0);
        }
    }
}