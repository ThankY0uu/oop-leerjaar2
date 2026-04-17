namespace DEALER.classes
{
    // Alle kleuren van een kaart
    public enum Suit { clubs, diamonds, hearts, spades }

    // Alle waarden van een kaart
    public enum Rank { ace, two, three, four, five, six, seven, eight, nine, ten, jack, queen, king }

    public class Card
    {
        public Suit suit { get; set; }   // kleur van de kaart
        public Rank rank { get; set; }   // waarde van de kaart
        public int Value { get; set; }   // blackjack waarde (1-11)
        public string ImageName { get; set; } = string.Empty; // naam van het plaatje

        // Geeft een leesbare tekst terug bijv. "ace of spades"
        public override string ToString()
        {
            return $"{rank} of {suit}";
        }
    }
}