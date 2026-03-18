using System;
using System.Collections.Generic;
using System.Text;


namespace DEALER.classes
{
    public class Hand
    {
        public bool CanPlay { get; set; }
        public int Total { get; set; }
        private List<Card> cards = new List<Card>();
        public bool hasPassed { get; set; }

        public bool Hit(Card card) { return false; }
        public void Stand() { }
    }
}