using System;

namespace Red7
{
    public struct Card
    {
        public int Number { get;}
        public Color Color { get;}
        public string Rule { get;}

        public Card(int number, Color color)
        {
            Number = number;
            Color = color;
            Rule = SetRule(color);
        }

        private static string SetRule(Color color) => 
            color switch
            {
                Color.Red => "Highest Card",
                Color.Orange => "Cards of One Number",
                Color.Yellow => "Cards of One Color",
                Color.Green => "Most Even Cards",
                Color.Blue => "Cards of All Different Colors",
                Color.Indigo => "Cards That Form a Run",
                Color.Violet => "Most Cards Below 4",
                _ => throw new ArgumentException(message: "Invalid Card Color", paramName: nameof(color)),
            };
    }
}