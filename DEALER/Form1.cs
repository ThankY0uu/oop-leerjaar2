using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO; // Nodig om te checken of bestanden bestaan

namespace DEALER
{
    public partial class Form1 : Form
    {
        // De lijsten voor de kaarten
        List<Card> deck = new List<Card>();
        List<Card> playerHand = new List<Card>();
        List<Card> dealerHand = new List<Card>();
        Random rng = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        // De bouwtekening van een kaart
        public class Card
        {
            public int Value { get; set; }
            public string ImageName { get; set; }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            CreateDeck();
            playerHand.Clear();
            dealerHand.Clear();

            // Deel 2 kaarten aan iedereen
            playerHand.Add(DrawCard());
            playerHand.Add(DrawCard());
            dealerHand.Add(DrawCard());
            dealerHand.Add(DrawCard());

            ShowCards();
        }

        private void CreateDeck()
        {
            deck.Clear();
            string[] suits = { "clubs", "diamonds", "hearts", "spades" };
            string[] faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace" };

            foreach (string s in suits)
            {
                for (int i = 0; i < faces.Length; i++)
                {
                    int score = i + 2;
                    if (i >= 8) score = 10;
                    if (i == 12) score = 11;

                    deck.Add(new Card
                    {
                        Value = score,
                        ImageName = faces[i] + "_of_" + s // Bijv: 2_of_clubs
                    });
                }
            }
        }

        private Card DrawCard()
        {
            int index = rng.Next(deck.Count);
            Card picked = deck[index];
            deck.RemoveAt(index);
            return picked;
        }

        private void ShowCards()
        {
            try
            {
                // Het pad naar je mapje 'kaarten'
                string path = Path.Combine(Application.StartupPath, "kaarten");

                // We zetten alle 4 de kaarten gewoon OPEN op het scherm
                pictureBox1.Image = Image.FromFile(Path.Combine(path, playerHand[0].ImageName + ".png"));
                pictureBox2.Image = Image.FromFile(Path.Combine(path, playerHand[1].ImageName + ".png"));

                pictureBox3.Image = Image.FromFile(Path.Combine(path, dealerHand[0].ImageName + ".png"));
                pictureBox4.Image = Image.FromFile(Path.Combine(path, dealerHand[1].ImageName + ".png"));

                // Scores tonen
                int pScore = playerHand[0].Value + playerHand[1].Value;
                int dScore = dealerHand[0].Value + dealerHand[1].Value;

                lblPlayerScore.Text = "Speler: " + pScore;
                lblDealerScore.Text = "Dealer: " + dScore;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check of de map 'kaarten' in bin/Debug staat! Fout: " + ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void lblDealerScore_Click(object sender, EventArgs e)
        {

        }
    }
}