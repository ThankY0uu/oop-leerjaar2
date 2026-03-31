using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using DEALER.classes;

namespace DEALER
{
    public partial class Form1 : Form
    {
        // Maak de objecten aan (NIET in de button click, maar hierboven!)
        Shoe gameShoe = new Shoe();
        Hand playerHand = new Hand();
        Hand dealerHand = new Hand();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // 1. Reset de handen
            playerHand.Clear();
            dealerHand.Clear();

            // 2. Deel kaarten uit (2 voor elk)
            playerHand.AddCard(gameShoe.Draw());
            playerHand.AddCard(gameShoe.Draw());
            dealerHand.AddCard(gameShoe.Draw());
            dealerHand.AddCard(gameShoe.Draw());

            // 3. Update het scherm
            UpdateUI();
        }

        private void UpdateUI()
        {
            try
            {
                string cardPath = Path.Combine(Application.StartupPath, "kaarten");

                // Player Cards
                if (playerHand.cards.Count >= 2)
                {
                    pictureBox1.Image = Image.FromFile(Path.Combine(cardPath, playerHand.cards[0].ImageName + ".png"));
                    pictureBox2.Image = Image.FromFile(Path.Combine(cardPath, playerHand.cards[1].ImageName + ".png"));
                }

                // Dealer Cards (1 dicht, 1 open)
                if (dealerHand.cards.Count >= 2)
                {
                    pictureBox3.Image = Image.FromFile(Path.Combine(cardPath, "minionback_1024x.png"));
                    pictureBox4.Image = Image.FromFile(Path.Combine(cardPath, dealerHand.cards[1].ImageName + ".png"));
                }

                lblPlayerScore.Text = "Player Score: " + playerHand.CalculateScore();
                lblDealerScore.Text = "Dealer Score: ?";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Foutje met de plaatjes: " + ex.Message);
            }
        }

        // --- HIERONDER DE LEGE FUNCTIES OM DE ERRORS TE FIXEN ---
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void pictureBox6_Click(object sender, EventArgs e) { }
        private void lblDealerScore_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}