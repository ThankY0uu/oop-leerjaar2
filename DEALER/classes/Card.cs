using System;
using System.Collections.Generic;
using System.Text;

namespace DEALER.classes
{
    public enum Suit { clubs, diamonds, hearts, spades }
    public enum Rank { ace, two, three, four, five, six, seven, eight, nine, ten, jack, queen, king }

    public class Card
    {
        public int Value { get; set; }
        public Suit suit { get; set; }
        public Rank rank { get; set; }

        public override string ToString()
        {
            return "";
        }
    }
}