using System;

namespace Red7
{
    public class Game
    {
        public void Run()
        {
            bool isUsing = true;

            while(isUsing)
            {
                // Main Menu
                var isPlaying = true; // menu selection results
                while(isPlaying)
                {
                    // Game Engine
                    var deck = new Deck();
                    Console.WriteLine("The Shuffled Deck\n------------");
                    for (int i = 0; i < 49; i++)
                    {
                        var card = deck.DrawCard();
                        Console.Write(i + 1);
                        Console.ForegroundColor = card.Color.Swap();
                        Console.Write($" {card.Color} {card.Number}");
                        Console.ResetColor();
                        Console.WriteLine($" - {card.Rule}");
                    }  

                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }
    } 
}