using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speech_Recognition
{
    public class Speler
    {
        public enum PowerAttack
        {
            MonkeyJumper = 30,
            SuperDuper = 60,
            Catelyzer = 45,
            Beast = 80
        }
        private Random rnd = new Random();
        public string PlayerNaam { get; }
        public int Leven { get; set; }
        public int Damage { get; set; }
        public int BewegingSnelheid { get; set; }
        public int Kogels { get; set; }
        public int Score { get; set; }
        public int EnemyCount { get; set; }
        public PowerAttack SuperAanval { get; }

        public Speler(string naam, int leven, int damage, int bewegingsnelheid, int kogels, PowerAttack superaanval)
        {
            this.PlayerNaam = naam;
            this.Leven = leven;
            this.Damage = damage;
            this.BewegingSnelheid = bewegingsnelheid;
            this.Kogels = kogels;
            this.SuperAanval = superaanval;
        }
        public Speler(string naam, int score, int enemyCount)
        {
            this.PlayerNaam = naam;
            this.Score = score;
            this.EnemyCount = enemyCount;
        }
        public void Attack(Enemy enemy)
        {
            if(this.Kogels > 0)
            {
                enemy.GetDamage(this.Damage);
                this.Kogels--;
                VoegScoreToe(this.Damage);
            }
        }
        public void VoegScoreToe(int aanval)
        {
            this.Score += this.rnd.Next(aanval);
        }

        public void SuperAttack(Enemy enemy, int tijd)
        {
            if(tijd % 30 == 0)
            {
                enemy.Leven -= (int)this.SuperAanval;
                VoegScoreToe((int)this.SuperAanval);
            }
        }
        public void ReceiveDamage(int damage)
        {
            if(this.Leven > 0)
            {
                this.Leven -= damage;
            }
        }

        public void Genees(int tijd)
        {
            if(tijd % 25 == 0)
            {
                this.Leven = 150;
            }
        }

        public override string ToString()
        {
            return $"{this.PlayerNaam} {this.Score} {this.EnemyCount}";
        }
    }
    
}
