using System;
using System.Collections.Generic;
using System.Text;

namespace DEALER.classes
{
    public enum GameState { Bet, Deal, PlayerTurn, DealerTurn, GameOver }

    public class Table
    {
        private Shoe shoe;
        private Dealer dealer;
        private List<Player> players;
        private GameState gameState;
        public int chips { get; set; }
        public int points { get; set; }
        public int activePlayerIndex { get; set; }

        public Table(int shoeSize, int amountOfPlayers) { }

        public void NextMove(string input) { }
    }
}