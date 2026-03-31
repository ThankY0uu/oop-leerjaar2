namespace DEALER
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox6 = new PictureBox();
            btnDraw = new Button();
            btnStand = new Button();
            btnNewGame = new Button();
            lblDealerScore = new Label();
            label2 = new Label();
            label3 = new Label();
            lblPlayerScore = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(449, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(703, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(197, 257);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(703, 371);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(197, 257);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(62, 21);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(75, 77);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // btnDraw
            // 
            btnDraw.Location = new Point(12, 573);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(94, 29);
            btnDraw.TabIndex = 6;
            btnDraw.Text = "Draw";
            btnDraw.UseVisualStyleBackColor = true;
            // 
            // btnStand
            // 
            btnStand.Location = new Point(194, 573);
            btnStand.Name = "btnStand";
            btnStand.Size = new Size(94, 29);
            btnStand.TabIndex = 7;
            btnStand.Text = "Stand";
            btnStand.UseVisualStyleBackColor = true;
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(102, 608);
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
            lblDealerScore.Text = "label1";
            lblDealerScore.Click += lblDealerScore_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1189, 351);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1189, 294);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 11;
            label3.Text = "label3";
            // 
            // lblPlayerScore
            // 
            lblPlayerScore.AutoSize = true;
            lblPlayerScore.Location = new Point(330, 283);
            lblPlayerScore.Name = "lblPlayerScore";
            lblPlayerScore.Size = new Size(50, 20);
            lblPlayerScore.TabIndex = 12;
            lblPlayerScore.Text = "label4";
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(143, 21);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(81, 77);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(449, 371);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(197, 257);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 721);
            Controls.Add(lblPlayerScore);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblDealerScore);
            Controls.Add(btnNewGame);
            Controls.Add(btnStand);
            Controls.Add(btnDraw);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private Button btnDraw;
        private Button btnStand;
        private Button btnNewGame;
        private Label lblDealerScore;
        private Label label2;
        private Label label3;
        private Label lblPlayerScore;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
    }
}
