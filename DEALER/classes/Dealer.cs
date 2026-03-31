using System;
using System.Collections.Generic;
using System.Text;

namespace DEALER.classes
{
    public class Dealer
    {
        private Hand hand = new Hand();

        public void Hit(Card card) { }
        public void Stand() { }
        public Card Deal(Deck deck) { return null; }
        public void Reset() { }
    }
}