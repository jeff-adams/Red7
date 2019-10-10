using System;

namespace Red7
{
    public struct Card
    {
        public int Number { get;}
        public ConsoleColor Color { get;}
        public string Rule { get;}

        public Card(int number, ConsoleColor color)
        {
            Number = number;
            Color = color;
            Rule = SetRule(color);
        }

        private string SetRule(ConsoleColor color) => 
            color switch
            {
                ConsoleColor.Red => "Highest Card",
                ConsoleColor.DarkYellow => "Cards of One Number",
                ConsoleColor.Yellow => "Cards of One Color",
                ConsoleColor.Green => "Most Even Cards",
                ConsoleColor.Blue => "Cards of All Different Colors",
                ConsoleColor.DarkBlue => "Cards That Form a Run",
                ConsoleColor.DarkMagenta => "Most Cards Below 4",
                _ => throw new ArgumentException(message: "Invalid Card Color", paramName: nameof(color)),
            };
    }
}