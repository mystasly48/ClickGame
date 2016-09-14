using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickGame {
    public partial class RegisterRecord : Form {
        public RegisterRecord(int score, DateTime time) {
            InitializeComponent();
            Score = score;
            Time = time;
        }

        int Score;
        DateTime Time;
        Leaderboard board = new Leaderboard();

        private void RegisterRecord_Load(object sender, EventArgs e) {
            button1.Enabled = true;
            label1.Text = "Score: " + Score.ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
            var name = textBox1.Text;
            if (name.Length == 0) {
                MessageBox.Show("名前は１文字以上でお願いします。");
            } else if (name.Length > 10) {
                MessageBox.Show("名前は１０文字以下でお願いします。");
            } else {
                Record record = new Record();
                record.Name = name;
                record.Score = Score;
                record.Time = Time;
                board.AddRecord(record);
                button1.Enabled = false;
                MessageBox.Show("スコアボードに登録されました。");
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            board.ShowDialog();
        }
    }
}
