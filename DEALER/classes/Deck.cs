//using System;
//using System.Collections.Generic;

//namespace DEALER.classes
//{
//    public class Deck
//    {
//        private List<Card> cards = new List<Card>(); // alle 52 kaarten

//        public Deck()
//        {
//            // Alle kleuren en waarden
//            string[] suits = { "clubs", "diamonds", "hearts", "spades" };
//            string[] ranks = { "ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };

//            // Loop door alle kleuren en waarden en maak kaarten aan
//            for (int s = 0; s < 4; s++)
//            {
//                for (int r = 0; r < 13; r++)
//                {
//                    Card newCard = new Card();
//                    newCard.suit = (Suit)s;
//                    newCard.rank = (Rank)r;

//                    // Blackjack waardes
//                    if (r == 0) newCard.Value = 11;      // Aas = 11
//                    else if (r >= 9) newCard.Value = 10; // 10, J, Q, K = 10
//                    else newCard.Value = r + 1;          // 2 t/m 9

//                    // Naam voor het plaatje bijv. "ace_of_spades"
//                    newCard.ImageName = ranks[r] + "_of_" + suits[s];

//                    cards.Add(newCard);
//                }   
//            }
//        }

//        // Shuffle de kaarten door ze 1000x te wisselen
//        public void Shuffle()
//        {
//            Random rng = new Random();
//            for (int i = 0; i < 1000; i++)
//            {
//                int p1 = rng.Next(cards.Count);
//                int p2 = rng.Next(cards.Count);

//                // Wissel twee kaarten om
//                Card temp = cards[p1];
//                cards[p1] = cards[p2];
//                cards[p2] = temp;
//            }
//        }

//        // Trek de bovenste kaart
//        public Card Draw()
//        {
//            if (cards.Count == 0) return null; // deck is leeg
//            Card picked = cards[0];
//            cards.RemoveAt(0);
//            return picked;
//        }
//    }
//}