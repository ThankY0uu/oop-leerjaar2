namespace DEALER.classes
{
    public class Dealer
    {
        public Hand hand = new Hand();

        public void Hit(Card card)
        {
            hand.AddCard(card);
        }

        public void Stand()
        {
            // dealer stopt
        }

        public Card Deal(Shoe shoe)
        {
            return shoe.Draw();
        }

        public void Reset()
        {
            hand.Clear();
        }
    }
}