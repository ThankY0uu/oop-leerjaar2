using System;
using System.Collections.Generic;

namespace DEALER.classes
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();

        public Deck()
        {
            string[] suits = { "clubs", "diamonds", "hearts", "spades" };
            string[] ranks = { "ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };

            for (int s = 0; s < 4; s++)
            {
                for (int r = 0; r < 13; r++)
                {
                    Card newCard = new Card();
                    newCard.suit = (Suit)s;
                    newCard.rank = (Rank)r;

                    if (r == 0) newCard.Value = 11;
                    else if (r >= 9) newCard.Value = 10;
                    else newCard.Value = r + 1;

                    newCard.ImageName = ranks[r] + "_of_" + suits[s];
                    cards.Add(newCard);
                }
            }
        }

        public void Shuffle()
        {
            Random rng = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int p1 = rng.Next(cards.Count);
                int p2 = rng.Next(cards.Count);
                Card temp = cards[p1];
                cards[p1] = cards[p2];
                cards[p2] = temp;
            }
        }

        public Card Draw()
        {
            if (cards.Count == 0) return null;
            Card picked = cards[0];
            cards.RemoveAt(0);
            return picked;
        }
    }
}