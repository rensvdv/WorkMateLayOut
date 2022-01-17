using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayOut_Wall_i
{
   public class Player
    {
        public enum Karakter
        {
            Vorst,
            Keizerin,
            Techneut,
            Heks
        }

        public string Naam { get; set; }
        public int Score { get; set; }
        public int MaxScore { get; set; }
        public int Winst { get; set; }
        public int Verlies { get; set; }
        public int Schade { get; set; }
        public int HealWaarde { get; set; }
        public Karakter DeKarakter { get; set; }
        public Random random = new Random();

        public Player(string naam, Karakter karakter)
        {

            this.Naam = naam;
            this.Score = 200;
            this.Winst = 0;
            this.Verlies = 0;
            this.DeKarakter = karakter;
        }

        public virtual void NormalAttack(Player player)
        {
            Schade += 24;
            player.Score -= Schade;
            Schade = 0;
        }

        public virtual void PowerAttack(Player player)  
        {
            Schade += 29;
            player.Score -= Schade;
            Schade = 0;
        }

        public virtual void BanditAttack(Player player2)
        {
            Schade = 19;
            this.Score += Schade;
            player2.Score -= Schade;
            Schade = 0;
        }

        public virtual void SelfDmg1(Player player)
        {
            Schade = 17;
            player.Score -= Schade;
            Schade = 0;
        }

        public virtual void SelfDmg2(Player player)
        {
            Schade = 22;
            player.Score -= Schade;
            Schade = 0;
        }

        public virtual void PestAttack(Player player)
        {
            Schade += random.Next(1, 20);
            player.Score -= Schade;
            Schade = 0;
        }

        public virtual void Healen(Player player)
        {
            HealWaarde = 19;
            player.Score += HealWaarde;
            HealWaarde = 0;
        }

        public void WinstOfVerlies(Player player)
        {
            if (player.Score <= 0 && this.Score > 0)
            {
                player.Verlies++;
                this.Winst++;
                player.Score = 200;
                this.Score = 200;
            }

            else if (player.Score > 0 && this.Score <= 0)
            {
                this.Verlies++;
                player.Winst++;
                player.Score = 200;
                this.Score = 200;
            }
        }
    }
}
