using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartsScoreTracker
{
    class Throw
    {
        public int score;
        public int darts;
    }

    [Serializable]
    class GameManager
    {
        public int LegsWon { get; private set; }
        public int LegsLost { get; private set; }
        public int ScoreLeft { get; private set; }
        public int Turns { get; private set; }
        public Decimal Average { get; private set; }       
        public int SetsWon { get; private set; }
        public int SetsLost { get; private set; }

        private int TotalScore;
        private Decimal Darts;
        private const char SplitChar = '.';

        public void ResetGame()
        {
            ScoreLeft = 501;
            Turns = 12;
            LegsWon = 0;
            LegsLost = 0;
            TotalScore = 0;
            SetsWon = 0;
            SetsLost = 0;
            Darts = 0;
        }

        private decimal CalculateAVG()
        {
            Decimal avg = (TotalScore / Darts) * 3;
            Average = Math.Round(avg, 2);
            return Average;
        }

        public void NewLeg()
        {
            ScoreLeft = 501;
            Turns = 12;
        }

        public Throw GetThrow(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            if (!input.Contains(SplitChar))
            {
                return null;
            }
            var i = input.Split(SplitChar);

            if (!int.TryParse(i[0], out int score) || !int.TryParse(i[1], out int darts))
            {
                return null;
            }

            return new Throw() { score = score, darts = darts };
        }

        public bool ProcessThrow(Throw t)
        {
            if (t.score > 180 || Turns == 0)
            {
                return false;
            }

            ScoreLeft -= t.score;
            Turns--;
            TotalScore += t.score;
            Darts += t.darts;
            CalculateAVG();

            if (ScoreLeft == 0)
            {
                //leg won
                LegsWon++;
                if (LegsWon == 3)
                {
                    LegsWon = 0;
                    SetsWon++;
                }
            }

            else if (Turns == 0)
            {
                //leg lost
                LegsLost++;
                if (LegsLost == 3)
                {
                    LegsLost = 0;
                    SetsLost++;
                }
            }
            return true;
        }

        public string GetStanding()
        {
            return LegsWon + " - " + LegsLost + "\n" + SetsWon + " - " + SetsLost;
        }
    }
}
