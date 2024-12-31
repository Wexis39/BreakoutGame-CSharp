using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTennis
{
    public partial class GameOverForm : Form
    {
        public GameOverForm(int score)
        {
            InitializeComponent();
            if(score < 24)
            {
                lblScore.Text = score.ToString();
            }
            else
            {
                lblYourScoreis.Text = "Congratulations! You Won!";
                lblYourScoreis.Location = new Point(100, 110);
                lblScore.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
