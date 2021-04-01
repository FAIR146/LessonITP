using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int gameTime;
        int score;
        int clickPrice;
        int priceMulti;

        private void buttonClick_Click(object sender, EventArgs e)
        {

            score += clickPrice;

            labelScore.Text = score.ToString();

            if (score % 10 == 0)
            {
                buttonUP.Enabled = true;
            }
        }

        private void timerClick_Tick(object sender, EventArgs e)
        {
            gameTime--;

            labelTime.Text = $"{gameTime / 60} : {gameTime % 60}";

            if (gameTime == 0)
            {
                buttonClick.Enabled = false;
                timerClick.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            score = 0;
            gameTime = 5;

            clickPrice = 1;
            priceMulti = 2;

            labelTime.Text = $"{gameTime / 60} : {gameTime % 60}";

        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            score = 0;
            gameTime = 5;

            labelTime.Text = $"{gameTime / 60} : {gameTime % 60}";
            labelScore.Text = score.ToString();

            buttonClick.Enabled = true;
            timerClick.Enabled = true;
        }

        private void buttonUP_Click(object sender, EventArgs e)
        {
            clickPrice *= priceMulti;
            buttonUP.Enabled = false;
        }
    }
}
