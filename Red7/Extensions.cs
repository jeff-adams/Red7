using System;

namespace Red7
{
    public static class Extensions
    {
        public static ConsoleColor Swap(this Color color) =>
            color switch
            {
                Color.Red => ConsoleColor.Red,
                Color.Orange => ConsoleColor.DarkYellow,
                Color.Yellow => ConsoleColor.Yellow,
                Color.Green => ConsoleColor.Green,
                Color.Blue => ConsoleColor.Blue,
                Color.Indigo => ConsoleColor.DarkBlue,
                Color.Violet => ConsoleColor.DarkMagenta,
                _ => ConsoleColor.Gray,
            };
    }
}