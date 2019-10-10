using System;
using System.Linq;
using System.Collections.Generic;

namespace Red7
{
    public class Deck
    {
        private Stack<Card> drawPile;
        private List<Card> discardPile;

        public Deck()
        {
            discardPile = CreateFreshDeck();
            drawPile = Shuffle(discardPile);
        }

        public Card DrawCard()
        {
            Card topCard = drawPile.Pop();
            discardPile.Add(topCard);
            return topCard;
        }
        public int Count() => drawPile.Count();

        private List<Card> CreateFreshDeck()
        {
            // There are 49 cards, numbered 1 - 7 for each of the 7 colors
            var freshDeck = new List<Card>();

            foreach (var color in Enum.GetValues(typeof(Color)))
            {
                for (int i = 1; i < 8; i++)
                {
                    freshDeck.Add(new Card(i, (Color)color));
                }
            }

            return freshDeck;
        }

        private Stack<Card> Shuffle(List<Card> cards)
        {
            var rng = new Random();

            for (int i = 0; i < cards.Count; i++)
            {
                int random = i + rng.Next(cards.Count - i);
                Card card = cards[random];
                cards[random] = cards[i];
                cards[i] = card;
            }

            var shuffledCards = new Stack<Card>();
            cards.ForEach(shuffledCards.Push);
            return shuffledCards;
        }
    }
}