using System.Collections.Generic;

namespace DEALER.classes
{
    public class Shoe
    {
        private List<Card> allCards = new List<Card>();

        public Shoe()
        {
            Deck myDeck = new Deck();
            myDeck.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                allCards.Add(myDeck.Draw());
            }
        }

        public Card Draw()
        {
            if (allCards.Count == 0) return null!;
            Card topCard = allCards[0];
            allCards.RemoveAt(0);
            return topCard;
        }
    }
}