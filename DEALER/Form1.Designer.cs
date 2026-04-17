namespace DEALER
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pictureBoxPlayer1 = new PictureBox();
            pictureBoxPlayer2 = new PictureBox();
            pictureBoxDealer1 = new PictureBox();
            btnDraw = new Button();
            btnStand = new Button();
            btnNewGame = new Button();
            lblDealerScore = new Label();
            lblPlayerScore = new Label();
            pictureBoxDealer2 = new PictureBox();
            btnShuffle = new Button();
            pictureBoxDraw = new PictureBox();
            pictureBoxDeck = new PictureBox();
            btnHandPlayer = new Button();
            btnHandDealer = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDraw).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeck).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPlayer1
            // 
            pictureBoxPlayer1.Location = new Point(449, 12);
            pictureBoxPlayer1.Name = "pictureBoxPlayer1";
            pictureBoxPlayer1.Size = new Size(197, 257);
            pictureBoxPlayer1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPlayer1.TabIndex = 0;
            pictureBoxPlayer1.TabStop = false;
            // 
            // pictureBoxPlayer2
            // 
            pictureBoxPlayer2.Location = new Point(703, 12);
            pictureBoxPlayer2.Name = "pictureBoxPlayer2";
            pictureBoxPlayer2.Size = new Size(197, 257);
            pictureBoxPlayer2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPlayer2.TabIndex = 1;
            pictureBoxPlayer2.TabStop = false;
            // 
            // pictureBoxDealer1
            // 
            pictureBoxDealer1.Location = new Point(703, 371);
            pictureBoxDealer1.Name = "pictureBoxDealer1";
            pictureBoxDealer1.Size = new Size(197, 257);
            pictureBoxDealer1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDealer1.TabIndex = 2;
            pictureBoxDealer1.TabStop = false;
            // 
            // btnDraw
            // 
            btnDraw.Location = new Point(191, 382);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(94, 29);
            btnDraw.TabIndex = 6;
            btnDraw.Text = "Draw";
            btnDraw.UseVisualStyleBackColor = true;
            // 
            // btnStand
            // 
            btnStand.Location = new Point(330, 415);
            btnStand.Name = "btnStand";
            btnStand.Size = new Size(94, 29);
            btnStand.TabIndex = 7;
            btnStand.Text = "Stand";
            btnStand.UseVisualStyleBackColor = true;
            btnStand.Click += btnStand_Click;
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(12, 12);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(94, 29);
            btnNewGame.TabIndex = 8;
            btnNewGame.Text = "New game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // lblDealerScore
            // 
            lblDealerScore.AutoSize = true;
            lblDealerScore.Location = new Point(330, 582);
            lblDealerScore.Name = "lblDealerScore";
            lblDealerScore.Size = new Size(50, 20);
            lblDealerScore.TabIndex = 9;
            lblDealerScore.Text = "Dealer: 0";
            // 
            // lblPlayerScore
            // 
            lblPlayerScore.AutoSize = true;
            lblPlayerScore.Location = new Point(330, 283);
            lblPlayerScore.Name = "lblPlayerScore";
            lblPlayerScore.Size = new Size(50, 20);
            lblPlayerScore.TabIndex = 12;
            lblPlayerScore.Text = "Player: 0";
            // 
            // pictureBoxDealer2
            // 
            pictureBoxDealer2.Location = new Point(449, 371);
            pictureBoxDealer2.Name = "pictureBoxDealer2";
            pictureBoxDealer2.Size = new Size(197, 257);
            pictureBoxDealer2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDealer2.TabIndex = 3;
            pictureBoxDealer2.TabStop = false;
            // 
            // btnShuffle
            // 
            btnShuffle.Location = new Point(191, 439);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Size = new Size(94, 29);
            btnShuffle.TabIndex = 13;
            btnShuffle.Text = "Shuffle";
            btnShuffle.UseVisualStyleBackColor = true;
            // 
            // pictureBoxDraw
            // 
            pictureBoxDraw.Location = new Point(164, 338);
            pictureBoxDraw.Name = "pictureBoxDraw";
            pictureBoxDraw.Size = new Size(143, 179);
            pictureBoxDraw.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDraw.TabIndex = 14;
            pictureBoxDraw.TabStop = false;
            // 
            // pictureBoxDeck
            // 
            pictureBoxDeck.Location = new Point(164, 135);
            pictureBoxDeck.Name = "pictureBoxDeck";
            pictureBoxDeck.Size = new Size(143, 179);
            pictureBoxDeck.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDeck.TabIndex = 15;
            pictureBoxDeck.TabStop = false;
            // 
            // btnHandPlayer
            // 
            btnHandPlayer.Location = new Point(449, 274);
            btnHandPlayer.Name = "btnHandPlayer";
            btnHandPlayer.Size = new Size(94, 29);
            btnHandPlayer.TabIndex = 16;
            btnHandPlayer.Text = "Hand card";
            btnHandPlayer.UseVisualStyleBackColor = true;
            btnHandPlayer.Click += button1_Click;
            // 
            // btnHandDealer
            // 
            btnHandDealer.Location = new Point(449, 634);
            btnHandDealer.Name = "btnHandDealer";
            btnHandDealer.Size = new Size(94, 29);
            btnHandDealer.TabIndex = 17;
            btnHandDealer.Text = "Hand card";
            btnHandDealer.UseVisualStyleBackColor = true;
            btnHandDealer.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 721);
            Controls.Add(btnHandDealer);
            Controls.Add(btnHandPlayer);
            Controls.Add(pictureBoxDeck);
            Controls.Add(btnShuffle);
            Controls.Add(lblPlayerScore);
            Controls.Add(lblDealerScore);
            Controls.Add(btnNewGame);
            Controls.Add(btnStand);
            Controls.Add(btnDraw);
            Controls.Add(pictureBoxDealer2);
            Controls.Add(pictureBoxDealer1);
            Controls.Add(pictureBoxPlayer2);
            Controls.Add(pictureBoxPlayer1);
            Controls.Add(pictureBoxDraw);
            Name = "Form1";
            Text = "Blackjack Dealer";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDraw).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxPlayer1;
        private PictureBox pictureBoxPlayer2;
        private PictureBox pictureBoxDealer1;  
        private PictureBox pictureBoxDealer2;     
        private PictureBox pictureBoxDraw;
        private PictureBox pictureBoxDeck;
        private Button btnDraw;
        private Button btnStand;
        private Button btnNewGame;
        private Button btnShuffle;
        private Button btnHandPlayer;
        private Button btnHandDealer;     
        private Label lblDealerScore;     
        private Label lblPlayerScore;


    }
}