using System;
using System.Windows.Forms;

namespace ClickGame {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        const int REMAINING = 5;
        const int SCORE = 0;
        bool IsRunning = false;
        int Remaining = REMAINING;
        int Score = SCORE;
        
        private void button1_Click(object sender, EventArgs e) {
            Score++;
            scoreLabel.Text = Score.ToString();
            if (!IsRunning) {
                timer1.Enabled = true;
                timer1.Start();
                IsRunning = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (Remaining == 0) {
                var time = DateTime.Now;
                RegisterRecord register = new RegisterRecord(Score, time);
                timer1.Stop();
                timer1.Enabled = false;
                IsRunning = false;
                button1.Enabled = false;
                button2.Enabled = true;
                register.ShowDialog();
            } else {
                Remaining--;
                remainingLabel.Text = Remaining.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            scoreLabel.Text = SCORE.ToString();
            remainingLabel.Text = REMAINING.ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            Score = SCORE;
            Remaining = REMAINING;
            scoreLabel.Text = Score.ToString();
            remainingLabel.Text = Remaining.ToString();
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
