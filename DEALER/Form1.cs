using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using DEALER.classes;

namespace DEALER
{
    public partial class Form1 : Form
    {
        Table table;        // de tafel met alle logica
        Card drawnCard;     // de kaart die je net getrokken hebt
        int nextCardIndex;  // bijhouden welke picturebox als volgende gevuld wordt

        public Form1()
        {
            InitializeComponent();

            // Maak een tafel aan met 1 speler
            table = new Table(1);
            nextCardIndex = 0;
            drawnCard = null;
        }

        // SHUFFLE KNOP - maak een nieuwe tafel aan
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            table = new Table(1);
            nextCardIndex = 0;
            drawnCard = null;

            // Maak alle plaatjes leeg
            pictureBoxPlayer1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBoxDrawn.Image = null;

            lblPlayerScore.Text = "Score: 0";
        }

        // DRAW KNOP - trek 1 kaart en laat hem zien in de preview box
        private void btnDraw_Click(object sender, EventArgs e)
        {
            // Trek een kaart via de tafel
            drawnCard = table.DrawCard();

            if (drawnCard == null)
            {
                MessageBox.Show("Shoe is leeg! Shuffle eerst.");
                return;
            }

            // Laat de kaart zien in de preview box
            string mapje = Path.Combine(Application.StartupPath, "kaarten");
            string bestand = Path.Combine(mapje, drawnCard.ImageName + ".png");
            pictureBoxDrawn.Image = Image.FromFile(bestand);
        }

        // DEAL KNOP - stuur de getrokken kaart naar de speler (van links naar rechts)
        private void btnDeal_Click(object sender, EventArgs e)
        {
            // Check of er wel een kaart getrokken is
            if (drawnCard == null)
            {
                MessageBox.Show("Trek eerst een kaart!");
                return;
            }

            if (nextCardIndex > 3)
            {
                MessageBox.Show("Speler heeft al 4 kaarten!");
                return;
            }

            // Laad het plaatje
            string mapje = Path.Combine(Application.StartupPath, "kaarten");
            string bestand = Path.Combine(mapje, drawnCard.ImageName + ".png");

            // Zet de kaart in de juiste picturebox
            if (nextCardIndex == 0) pictureBoxPlayer1.Image = Image.FromFile(bestand);
            if (nextCardIndex == 1) pictureBox2.Image = Image.FromFile(bestand);
            if (nextCardIndex == 2) pictureBox3.Image = Image.FromFile(bestand);
            if (nextCardIndex == 3) pictureBox4.Image = Image.FromFile(bestand);

            // Voeg kaart toe aan speler via de tafel
            table.DealCardToPlayer(0, drawnCard);
            lblPlayerScore.Text = "Score: " + table.GetPlayerScore(0);

            // Reset de preview en ga naar de volgende positie
            drawnCard = null;
            pictureBoxDrawn.Image = null;
            nextCardIndex++;
        }

        // NEW GAME KNOP - reset alles
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            table.Reset();
            nextCardIndex = 0;
            drawnCard = null;

            pictureBoxPlayer1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBoxDrawn.Image = null;

            lblPlayerScore.Text = "Score: 0";
        }

        // Lege click handlers
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void pictureBox6_Click(object sender, EventArgs e) { }
        private void lblDealerScore_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click_1(object sender, EventArgs e) { }
        private void btnStand_Click(object sender, EventArgs e) { }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }

}