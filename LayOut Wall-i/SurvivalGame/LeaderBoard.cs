using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LayOut_Wall_i
{
    public class LeaderBoard
    {
        public List<string> Scores { get; set; }
        public List<Speler> SpelerScores { get; set; } = new List<Speler>();
        public LeaderBoard()
        {
            this.Scores = File.ReadAllLines(@"C:\Users\zessa\Desktop\Git\WorkMateLayOut\LayOut Wall-i\Scores.txt").ToList();
        }

        public void VoegSpelerToe(Speler speler)
        {
            foreach (var score in this.Scores)
            {
                string[] scor = score.Split(' ');
                if (scor.Length == 3)
                    this.SpelerScores.Add(new Speler(scor[0], Convert.ToInt32(scor[1]), Convert.ToInt32(scor[2])));
            }
            this.SpelerScores.Add(speler);
            SorteerSpelerLijstOpScore();
            SlaScoresOp();
        }
        public void SorteerSpelerLijstOpScore()
        {
            this.SpelerScores = this.SpelerScores.OrderByDescending(x => x.Score).ThenByDescending(x => x.EnemyCount).ToList();
        }

        public void SlaScoresOp()
        {
            this.Scores.Clear();
            this.Scores.Add("Playernaam | Score | EnemyCount");
            this.Scores.Add("----------------------------------------------");
            foreach (var speler in this.SpelerScores)
            {
                this.Scores.Add(speler.ToString());
            }
            File.WriteAllLines(@"C:\Users\zessa\source\repos\Speech_Recognition\Speech_Recognition\Scores.txt", this.Scores);
        }
    }
}
