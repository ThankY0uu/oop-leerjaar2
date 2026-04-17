namespace DEALER.classes
{
    public enum Suit { clubs, diamonds, hearts, spades }
    public enum Rank { ace, two, three, four, five, six, seven, eight, nine, ten, jack, queen, king }

    public class Card
    {
        public int Value { get; set; }
        public Suit suit { get; set; }
        public Rank rank { get; set; }
        public string ImageName { get; set; } = string.Empty;

        public override string ToString()
        {
            return rank + " of " + suit;
        }
    }
}