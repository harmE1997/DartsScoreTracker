using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DartsScoreTracker
{
    public partial class Form1 : Form
    {
        private const int EnterKeyCode = 13;
        private GameManager gamemanager;
        private const string FileName = "DartsGame";
        public Form1()
        {
            InitializeComponent();
            gamemanager = new GameManager();
            ResetGame();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            SubmitScore();
        }

        private void btnNewLeg_Click(object sender, EventArgs e)
        {
            gamemanager.NewLeg();
            newLeg();
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void rtbScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == EnterKeyCode)
                SubmitScore();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (FileStream stream = new FileStream(FileName, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, gamemanager);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!File.Exists(FileName))
                MessageBox.Show("Can't load file! It doesn't exist!");

            using (FileStream stream = new FileStream(FileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                gamemanager = (GameManager)formatter.Deserialize(stream);
            }

            setLabels();
            OutputStanding();
        }

        private void setLabels()
        {
            lblScore.Text = gamemanager.ScoreLeft.ToString();
            lblTurns.Text = gamemanager.Turns.ToString();
            lblAVG.Text = gamemanager.Average.ToString();
        }

        private void OutputStanding()
        {
            lblLegs.Text = gamemanager.GetStanding();
        }
        private void SubmitScore()
        {
            string input = rtbScore.Text;
            rtbScore.Clear();
            var t = gamemanager.GetThrow(input);
            if (t == null)
            {
                MessageBox.Show("Invalid input");
                return;
            }

            if (!gamemanager.ProcessThrow(t))
            {
                MessageBox.Show("Error! Score too high or no more turns left");
                return;
            }

            if (gamemanager.ScoreLeft == 0)
            {                
                BackColor = Color.Green;
                rtbScore.Enabled = false;
            }

            else if (gamemanager.Turns == 0)
            {
                BackColor = Color.Red;
                rtbScore.Enabled = false;
            }
            setLabels();
            OutputStanding();
        }

        private void ResetGame()
        {
            gamemanager.ResetGame();
            newLeg();
            OutputStanding();
            lblAVG.Text = "";
        }

        private void newLeg()
        {
            BackColor = Color.Blue;
            setLabels();
            rtbScore.Enabled = true;
        }
    }
}
