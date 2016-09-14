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
    public partial class Leaderboard : Form {
        public Leaderboard() {
            InitializeComponent();
        }

        private void Leaderboard_Load(object sender, EventArgs e) {
            

            //dataGridView1.Rows.Add();
            //dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "Name area";
            //dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = "Score area";
            //dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = "Time area";
        }

        public void AddRecord(Record record) {
            dataGridView1.Rows.Add();
            var count = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[count].Cells[0].Value = record.Name;
            dataGridView1.Rows[count].Cells[1].Value = record.Score;
            dataGridView1.Rows[count].Cells[2].Value = record.Time.ToString("HH:mm:ss");
        }
    }
}
