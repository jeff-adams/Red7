using System;
using System.Collections.Generic;

namespace Red7
{
    public class GameManager
    {
        private List<Player> players;
        private Deck deck;
        private Queue<Card> canvas;

        public GameManager()
        {
            players = new List<Player>();
            deck = new Deck();
            canvas = new Queue<Card>();
            canvas.Enqueue(new Card(0, Color.Red));
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        
    }
}