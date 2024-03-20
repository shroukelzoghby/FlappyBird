namespace FlappyBird
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
            components = new System.ComponentModel.Container();
            BirdBox = new PictureBox();
            pictureBox2 = new PictureBox();
            pipeBox2 = new PictureBox();
            pipeBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            gameOverBox = new PictureBox();
            label1 = new Label();
            messageBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BirdBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gameOverBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)messageBox).BeginInit();
            SuspendLayout();
            // 
            // BirdBox
            // 
            BirdBox.BackColor = Color.Transparent;
            BirdBox.Image = Properties.Resources.yellowbird_upflap;
            BirdBox.Location = new Point(81, 172);
            BirdBox.Name = "BirdBox";
            BirdBox.Size = new Size(51, 42);
            BirdBox.SizeMode = PictureBoxSizeMode.StretchImage;
            BirdBox.TabIndex = 0;
            BirdBox.TabStop = false;
            BirdBox.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._base;
            pictureBox2.Location = new Point(0, 432);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(834, 162);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pipeBox2
            // 
            pipeBox2.BackColor = Color.Transparent;
            pipeBox2.Image = Properties.Resources.tube2;
            pipeBox2.Location = new Point(568, -1);
            pipeBox2.Name = "pipeBox2";
            pipeBox2.Size = new Size(58, 154);
            pipeBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBox2.TabIndex = 2;
            pipeBox2.TabStop = false;
            // 
            // pipeBox1
            // 
            pipeBox1.BackColor = Color.Transparent;
            pipeBox1.Image = Properties.Resources.tube1;
            pipeBox1.Location = new Point(613, 263);
            pipeBox1.Name = "pipeBox1";
            pipeBox1.Size = new Size(58, 170);
            pipeBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBox1.TabIndex = 3;
            pipeBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // gameOverBox
            // 
            gameOverBox.BackColor = Color.Transparent;
            gameOverBox.Image = Properties.Resources.gameover;
            gameOverBox.Location = new Point(294, 186);
            gameOverBox.Name = "gameOverBox";
            gameOverBox.Size = new Size(233, 59);
            gameOverBox.SizeMode = PictureBoxSizeMode.StretchImage;
            gameOverBox.TabIndex = 4;
            gameOverBox.TabStop = false;
            gameOverBox.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bebas Neue", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(733, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 33);
            label1.TabIndex = 5;
            label1.Text = "Score";
            // 
            // messageBox
            // 
            messageBox.BackColor = Color.Transparent;
            messageBox.Image = Properties.Resources.message;
            messageBox.Location = new Point(189, 63);
            messageBox.Name = "messageBox";
            messageBox.Size = new Size(350, 329);
            messageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            messageBox.TabIndex = 6;
            messageBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_day;
            ClientSize = new Size(832, 542);
            Controls.Add(messageBox);
            Controls.Add(label1);
            Controls.Add(gameOverBox);
            Controls.Add(pipeBox1);
            Controls.Add(pipeBox2);
            Controls.Add(pictureBox2);
            Controls.Add(BirdBox);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)BirdBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gameOverBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)messageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BirdBox;
        private PictureBox pictureBox2;
        private PictureBox pipeBox2;
        private PictureBox pipeBox1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox gameOverBox;
        private Label label1;
        private PictureBox messageBox;
    }
}
