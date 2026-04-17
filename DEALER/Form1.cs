using DEALER.classes;

namespace DEALER
{
    public partial class Form1 : Form
    {
        private Table table = new Table(1, 1);
        private Card drawnCard = null;
        private int dealerCardCount = 0;
        private int playerCardCount = 0;
        private bool isShuffled = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            table.Shuffle();
            isShuffled = true;
            pictureBoxDeck.Image = Image.FromFile("kaarten/minionback_1024x.png");
            pictureBoxDraw.Image = null;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (!isShuffled)
            {
                MessageBox.Show("Shuffle eerst het deck!");
                return;
            }

            drawnCard = table.Draw();
            pictureBoxDraw.Image = Image.FromFile("kaarten/minionback_1024x.png");
        }

        private void button1_Click_1(object sender, EventArgs e) // btnHandDealer
        {
            if (drawnCard == null) return;

            if (dealerCardCount == 0)
            {
                pictureBoxDealer1.Image = Image.FromFile("kaarten/" + drawnCard.ImageName + ".png");
            }
            else if (dealerCardCount == 1)
            {
                pictureBoxDealer2.Image = Image.FromFile("kaarten/minionback_1024x.png"); // omgekeerd
            }

            dealerCardCount++;
            drawnCard = null;
            pictureBoxDraw.Image = null;
        }

        private void button1_Click(object sender, EventArgs e) // btnHandPlayer
        {
            if (drawnCard == null) return;

            Image cardImage = Image.FromFile("kaarten/" + drawnCard.ImageName + ".png");

            if (playerCardCount == 0) pictureBoxPlayer1.Image = cardImage;
            else if (playerCardCount == 1) pictureBoxPlayer2.Image = cardImage;

            playerCardCount++;
            drawnCard = null;
            pictureBoxDraw.Image = null;
        }

        private void btnStand_Click(object sender, EventArgs e) { }
        private void btnNewGame_Click(object sender, EventArgs e) { }
    }
}