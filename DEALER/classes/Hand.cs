using System.Collections.Generic;

namespace DEALER.classes
{
    public class Hand
    {
        public List<Card> cards = new List<Card>();

        public void AddCard(Card newCard)
        {
            if (newCard != null) cards.Add(newCard);
        }

        public int CalculateScore()
        {
            int total = 0;
            foreach (Card c in cards)
            {
                total += c.Value;
            }
            return total;
        }

        public void Clear()
        {
            cards.Clear();
        }
    }
}