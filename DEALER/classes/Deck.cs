using System;
using System.Collections.Generic;
using System.Text;

namespace DEALER.classes
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();
        public int CardsLeft { get; set; }

        public void Shuffle() { }
        public Card Draw() { return null; }
    }
}
