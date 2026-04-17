using System.Collections.Generic;

namespace DEALER.classes
{
    public class Player
    {
        public Hand hand = new Hand(); // de hand van de speler
        public int chips { get; set; } // hoeveel chips de speler heeft
        public bool AllowedPlay { get; set; } // mag de speler nog spelen

        // Maak een speler aan met een bepaald aantal chips
        public Player(int chips)
        {
            this.chips = chips;
        }

        // Voeg een kaart toe aan de hand
        public void Hit(Card card)
        {
            hand.AddCard(card);
        }

        // Speler stopt met kaarten trekken
        public void Stand()
        {
            AllowedPlay = false;
        }

        // Zet een bedrag in
        public void PlaceBet(int amount)
        {
            if (amount <= chips)
            {
                chips -= amount; // haal chips weg
            }
        }

        // Reset de speler voor een nieuwe ronde
        public void Reset()
        {
            hand.Clear();
            AllowedPlay = true;
        }
    }
}