using System.Collections.Generic;

namespace DEALER.classes
{
    public class Hand
    {
        public bool CanPlay { get; set; } = true;
        public int Total { get; private set; }
        public List<Card> cards = new List<Card>();
        public bool hasPassed { get; set; } = false;

        public void Hit(Card card)
        {
            if (card != null)
            {
                cards.Add(card);
                Total += card.Value;
            }
        }

        public void Stand()
        {
            hasPassed = true;
        }

        public void Clear()
        {
            cards.Clear();
            Total = 0;
            hasPassed = false;
            CanPlay = true;
        }
    }
}