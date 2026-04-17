using DEALER.classes;

namespace DEALER
{
    public partial class Form1 : Form
    {
        private Table table = new Table();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            table.Shuffle();
            pictureBoxDeck.Image = Image.FromFile("kaarten/minionback_1024x.png");
            pictureBoxDraw.Image = null;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Card card = table.Draw();
            pictureBoxDraw.Image = Image.FromFile("kaarten/minionback_1024x.png");
        }

        private void btnStand_Click(object sender, EventArgs e) { }
        private void btnNewGame_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void button1_Click_1(object sender, EventArgs e) { }
    }
}