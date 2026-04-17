using System.Collections.Generic;

namespace DEALER.classes
{
    public class Hand
    {
        public List<Card> cards = new List<Card>(); // kaarten in de hand

        // Voeg een kaart toe aan de hand
        public void AddCard(Card newCard)
        {
            if (newCard != null) cards.Add(newCard);
        }

        // Bereken de totale score van de hand
        public int CalculateScore()
        {
            int total = 0;
            foreach (Card c in cards)
            {
                total += c.Value;
            }
            return total;
        }

        // Maak de hand leeg
        public void Clear()
        {
            cards.Clear();
        }
    }
}