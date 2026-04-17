namespace DEALER.classes
{
    public class Player
    {
        public Hand hand = new Hand();

        public void Hit(Card card)
        {
            hand.AddCard(card);
        }

        public void Reset()
        {
            hand.Clear();
        }
    }
}