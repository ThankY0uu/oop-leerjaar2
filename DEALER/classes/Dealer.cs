namespace DEALER.classes
{
    public class Dealer
    {
        public Hand hand = new Hand();

        public void Hit(Card card)
        {
            hand.Hit(card);
        }

        public void Stand()
        {
            hand.Stand();
        }

        public Card Deal(Deck deck)
        {
            return deck.Draw();
        }

        public void Reset()
        {
            hand.Clear();
        }
    }
}