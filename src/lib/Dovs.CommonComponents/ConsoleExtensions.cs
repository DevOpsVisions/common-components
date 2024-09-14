using System;
using System.Linq;
namespace Dovs.CommonComponents
{
    public static class ConsoleExtensions
    {
        public enum ConsoleColorEnum
        {
            Black = ConsoleColor.Black,
            DarkBlue = ConsoleColor.DarkBlue,
            DarkGreen = ConsoleColor.DarkGreen,
            DarkCyan = ConsoleColor.DarkCyan,
            DarkRed = ConsoleColor.DarkRed,
            DarkMagenta = ConsoleColor.DarkMagenta,
            DarkYellow = ConsoleColor.DarkYellow,
            Gray = ConsoleColor.Gray,
            DarkGray = ConsoleColor.DarkGray,
            Blue = ConsoleColor.Blue,
            Green = ConsoleColor.Green,
            Cyan = ConsoleColor.Cyan,
            Red = ConsoleColor.Red,
            Magenta = ConsoleColor.Magenta,
            Yellow = ConsoleColor.Yellow,
            White = ConsoleColor.White
        }

        public static void WriteLineWithColor(string message, ConsoleColorEnum color)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(message);
            Console.ForegroundColor = originalColor;
        }

        public static void WriteWithColor(string message, ConsoleColorEnum color)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = (ConsoleColor)color;
            Console.Write(message);
            Console.ForegroundColor = originalColor;
        }
    }
}
