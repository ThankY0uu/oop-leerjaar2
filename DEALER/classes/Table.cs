using System.Collections.Generic;

namespace DEALER.classes
{
    public enum GameState { Bet, Deal, PlayerTurn, DealerTurn, GameOver }

    public class Table
    {
        private Shoe shoe;           // de shoe met kaarten
        private Dealer dealer;       // de dealer
        private List<Player> players; // alle spelers aan tafel
        private GameState gameState; // huidige staat van het spel

        // Maak een tafel aan met een shoe en aantal spelers
        public Table(int amountOfPlayers)
        {
            shoe = new Shoe();
            dealer = new Dealer();
            players = new List<Player>();

            // Maak de spelers aan
            for (int i = 0; i < amountOfPlayers; i++)
            {
                players.Add(new Player(1000)); // elke speler begint met 1000 chips
            }

            gameState = GameState.Bet; // begin met de bet fase
        }

        // Deel 1 kaart aan een speler
        public void DealCardToPlayer(int playerIndex)
        {
            Card card = dealer.Deal(shoe);
            players[playerIndex].Hit(card);
        }

        // Deel 1 kaart aan de dealer zelf
        public void DealCardToDealer()
        {
            Card card = dealer.Deal(shoe);
            dealer.Hit(card);
        }
        // Trek een kaart uit de shoe
        public Card DrawCard()
        {
            return shoe.Draw();
        }

        // Deel een specifieke kaart aan een speler
        public void DealCardToPlayer(int playerIndex, Card card)
        {
            players[playerIndex].Hit(card);
        }

        // Geef de score van een speler terug
        public int GetPlayerScore(int playerIndex)
        {
            return players[playerIndex].hand.CalculateScore();
        }

        // Reset alles voor een nieuwe ronde
        public void Reset()
        {
            dealer.Reset();
            foreach (Player p in players)
            {
                p.Reset();
            }
            gameState = GameState.Bet;
        }
    }
}