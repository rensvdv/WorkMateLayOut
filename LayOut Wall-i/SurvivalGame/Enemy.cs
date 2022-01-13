using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speech_Recognition
{
    public class Enemy
    {
        private Random rnd = new Random();
        public int Leven { get; set; }
        public int Damage { get; set; }
        public int BewegingSnelheid { get; set; }

        public Enemy(int leven, int damage, int bewegingsnelheid)
        {
            this.Leven = leven;
            this.Damage = damage;
            this.BewegingSnelheid = bewegingsnelheid;
        }

        public int RandomLocation(int maxWidth, int maxHeigth)
        {
            if (maxWidth < maxHeigth)
            {
                return rnd.Next(maxWidth, maxHeigth);
            }
            else
            {
                return rnd.Next(maxHeigth, maxWidth);
            }
        }
        public void GetDamage(int damage)
        {
            if(this.Leven > 0)
            {
                this.Leven -= damage;
            }
        }
        public void GiveDamage(Speler speler)
        {
            speler.ReceiveDamage(this.Damage);
        }

        public void BeastMode(int tijd)
        {
            if (tijd % 20 == 0)
            {
                this.Damage += 20;
                this.BewegingSnelheid += 10;
            }
            else
            {
                this.Damage = 20;
                this.BewegingSnelheid = 10;
            }
        }
        public override string ToString()
        {
            return $"LevenEnemy: {this.Leven}";
        }

    }
}
