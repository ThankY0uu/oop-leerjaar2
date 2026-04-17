using System.Collections.Generic;

namespace DEALER.classes
{
    public class Player
    {
        public List<Hand> hands = new List<Hand>();
        public int chips { get; set; }
        public bool AllowedPlay { get; set; } = true;

        public Player(int chips)
        {
            this.chips = chips;
            hands.Add(new Hand());
        }

        public void Hit(Card card)
        {
            hands[0].Hit(card);
        }

        public void Stand()
        {
            hands[0].Stand();
        }

        public void PlaceBets(int amount)
        {
            chips -= amount;
        }

        public void Reset()
        {
            hands[0].Clear();
            AllowedPlay = true;
        }
    }
}