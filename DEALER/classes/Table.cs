using System.Collections.Generic;

namespace DEALER.classes
{
    public class Table
    {
        public Deck deck = new Deck();

        public void Shuffle()
        {
            deck.Shuffle();
        }

        public Card Draw()
        {
            return deck.Draw();
        }
    }
}