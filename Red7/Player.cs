using System;
using System.Collections.Generic;

namespace Red7
{
    public class Player
    {
        public string Name { get; private set; }
        public List<Card> Hand { get; private set; }
        public List<Card> Palette { get; private set; }

        public Player(string name)
        {
            Name = name;
        }

        public void ReceiveCard(Card card)
        {
            Hand.Add(card);
        }

        public Card PlayRule(int cardIndex)
        {
            if (Hand.Count - 1 >= cardIndex)
            {
                var card = Hand[cardIndex];
                Hand.Remove(card);
                return card;
            }
            throw new ArgumentOutOfRangeException("cardIndex");
        }

        public Card PlayToPalette(int cardIndex)
        {
            if (Hand.Count - 1 >= cardIndex)
            {
                var card = Hand[cardIndex];
                Hand.Remove(card);
                Palette.Add(card);
                return card;
            }
            throw new ArgumentOutOfRangeException("cardIndex");
        }
    }
}