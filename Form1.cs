namespace FlappyBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        int gravity = 10;
        int speed = 15;
        Random random = new Random();
        int score = 0;  

        private void timer1_Tick(object sender, EventArgs e)
        {
            BirdBox.Top += gravity;
            pipeBox1.Left -= speed;
            pipeBox2.Left -= speed;
            label1.Text = $"Score:{score}";
            if(pipeBox1.Left < 3) { pipeBox1.Left = random.Next(600,700);score++; }
            if(pipeBox2.Left < 3) { pipeBox2.Left = random.Next(600, 700); score++; }
            if(BirdBox.Bounds.IntersectsWith(pipeBox1.Bounds) || BirdBox.Bounds.IntersectsWith(pipeBox2.Bounds)|| BirdBox.Bounds.IntersectsWith(pictureBox2.Bounds)) { timer1.Stop(); gameOverBox.Visible = true ; score = 0; }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (timer1.Enabled == false) {
                if (e.KeyCode == Keys.Enter) { messageBox.Visible = false; timer1.Start(); pipeBox1.Left = random.Next(600, 700); pipeBox2.Left = random.Next(600, 700); BirdBox.Top = 30; gameOverBox.Visible = false; }
            }
            
            if (e.KeyCode == Keys.Space) { gravity = -10; }
            if(BirdBox.Top <2) { BirdBox.Top = 15; }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { gravity = 10; }

        }
    }
}
