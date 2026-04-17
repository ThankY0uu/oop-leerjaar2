//using System.Collections.Generic;

//namespace DEALER.classes
//{
//    public class Shoe
//    {
//        private List<Card> allCards = new List<Card>(); // alle kaarten in de shoe

//        public Shoe()
//        {
//            // Maak een nieuwe deck aan en shuffle hem
//            Deck myDeck = new Deck();
//            myDeck.Shuffle();

//            // Stop alle 52 kaarten in de shoe
//            for (int i = 0; i < 52; i++)
//            {
//                allCards.Add(myDeck.Draw());
//            }
//        }

//        // Trek de bovenste kaart uit de shoe
//        public Card Draw()
//        {
//            if (allCards.Count == 0) return null; // shoe is leeg
//            Card topCard = allCards[0];
//            allCards.RemoveAt(0);
//            return topCard;
//        }
//    }
//}