using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedGame
{
    public class Swordsman : Speler
    {

        public Swordsman()
        {
            Hp = 60;
            MaxHp = Hp;
            Heal = false;
        }

        public override void LichteAanval(Speler speler2)
        {
            Damage += random.Next(5, 10);
            speler2.Hp -= Damage;
            Damage = 0;
            HealCount++; 
        }

        public override void ZwareAanval(Speler speler2)
        {
            Damage += random.Next(10, 20);
            speler2.Hp -= Damage;
            Damage = 0;
            ZwareAanvalGebruikt = !ZwareAanvalGebruikt;
            HealCount++;
        }

        public override string ToString()
        {
            return "Swordsman";
        }
    }
}
