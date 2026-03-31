using System;
using System.Collections.Generic;
using System.Text;


namespace DEALER.classes
{
    public class Player
    {
        private List<Hand> hands = new List<Hand>();
        public int chips { get; set; }
        public bool AllowedPlay { get; set; }

        public Player(int chips) { this.chips = chips; }

        public void Hit(Card card) { }
        public void Stand() { }
        public void PlaceBets(int amount) { }
        public void Reset() { }
    }
}