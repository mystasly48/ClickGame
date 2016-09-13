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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        bool IsRunning = false;
        int Remaining = 60;
        int Count = 0;

        private void button1_Click(object sender, EventArgs e) {
            var count = int.Parse(remaining.Text);
            remaining.Text = (count++).ToString();
            if (!IsRunning) {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            var count = int.Parse(remaining.Text);
            remaining.Text = (count--).ToString();
        }

        private void Form1_Load(object sender, EventArgs e) {
            score.Text = "60";
            remaining.Text = "0";
            button1.Text = "Click!";
        }
    }
}
