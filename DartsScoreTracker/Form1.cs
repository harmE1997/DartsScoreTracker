using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartsScoreTracker
{
    public partial class Form1 : Form
    {
        private int LegsWon;
        private int LegsLost;
        private int ScoreLeft;
        private int Turns;     
        private Decimal Average;
        private int TotalScore;
        private int SetsWon;
        private int SetsLost;
        private Decimal Darts;
        private const int EnterKeyCode = 13;
        private const char SplitChar = '.';
        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            SubmitScore();
        }

        private void btnNewLeg_Click(object sender, EventArgs e)
        {
            ScoreLeft = 501;
            Turns = 12;
            BackColor = Color.Blue;
            setLabels();
            btnScore.Enabled = true;
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btnScore_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("hit");
        }

        private void rtbScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == EnterKeyCode)
                SubmitScore();
        }

        private void setLabels()
        {
            lblScore.Text = ScoreLeft.ToString();
            lblTurns.Text = Turns.ToString();
        }

        private void OutputStanding()
        {
            lblLegs.Text = LegsWon + " - " + LegsLost + "\n" + SetsWon + " - " + SetsLost;
        }
        private void SubmitScore()
        {
            string input = rtbScore.Text;
            if (!input.Contains(SplitChar))
            {
                MessageBox.Show("invalid input");
                return;
            }
            var i = input.Split(SplitChar);

            if (!int.TryParse(i[0], out int score) || !int.TryParse(i[1], out int darts))
            {
                MessageBox.Show("Invalid input!");
                rtbScore.Clear();
                return;
            }

            rtbScore.Clear();
            if (score > 180 || Turns == 0)
            {
                MessageBox.Show("Score is too high or no more turns left!");
                return;
            }

            ScoreLeft -= score;
            Turns--;
            TotalScore += score;
            Darts += darts;
            setLabels();
            CalculateAVG();
            if (ScoreLeft == 0)
            {
                //leg won
                LegsWon++;
                if(LegsWon == 3)
                {
                    LegsWon = 0;
                    SetsWon++;
                }
                OutputStanding();
                BackColor = Color.Green;
            }

            else if (Turns == 0)
            {
                //leg lost
                LegsLost++;
                if (LegsLost == 3)
                {
                    LegsLost = 0;
                    SetsLost = 1;
                }
                OutputStanding();
                BackColor = Color.Red;
            }
        }

        private void ResetGame()
        {
            ScoreLeft = 501;
            Turns = 12;
            LegsWon = 0;
            LegsLost = 0;
            TotalScore = 0;
            SetsWon = 0;
            SetsLost = 0;
            Darts = 0;
            BackColor = Color.Blue;
            setLabels();
            OutputStanding();
            lblAVG.Text = "";
            
        }

        private void CalculateAVG()
        {
            Decimal avg = (TotalScore / Darts) * 3;
            Average = Math.Round(avg, 2);
            lblAVG.Text = Average.ToString();
        }
    }
}
