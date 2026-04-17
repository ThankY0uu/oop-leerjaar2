using System.Collections.Generic;

namespace DEALER.classes
{
    public class Shoe
    {
        public List<Deck> decks = new List<Deck>();

        public Shoe()
        {
            decks.Add(new Deck());
        }

        public void Shuffle()
        {
            foreach (Deck d in decks)
            {
                d.Shuffle();
            }
        }

        public Deck Draw()
        {
            if (decks.Count == 0) return null;
            return decks[0];
        }
    }
}