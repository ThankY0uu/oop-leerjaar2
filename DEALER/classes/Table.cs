using System.Collections.Generic;

namespace DEALER.classes
{
    public enum GameState { Bet, Deal, PlayerTurn, DealerTurn, GameOver }

    public class Table
    {
        private Shoe shoe = new Shoe();
        private Dealer dealer = new Dealer();
        private List<Player> players = new List<Player>();
        private GameState gameState = GameState.Bet;
        public int chips { get; set; }
        public int points { get; set; }
        public int activePlayerIndex { get; set; }

        public Table(int shoeSize, int amountOfPlayers)
        {
            for (int i = 0; i < amountOfPlayers; i++)
            {
                players.Add(new Player(1000));
            }
        }

        public void Shuffle()
        {
            shoe.Shuffle();
        }

        public Card Draw()
        {
            return shoe.Draw().Draw();
        }

        public void NextMove(string input)
        {
            // volgende stap logica
        }
    }
}