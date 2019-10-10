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
            // 1 - 7 foreach 7 colors
            
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