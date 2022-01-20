using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedGame
{
    public class Assassin : Speler
    {

        public Assassin()
        {
            Heal = false;
            Hp = 40;
            MaxHp = Hp;
        }


        public override void LichteAanval(Speler speler2)
        {
            Damage += random.Next(8, 11);
            speler2.Hp -= Damage;
            Damage = 0;
            HealCount++;
        }

        public override void ZwareAanval(Speler speler2)
        {
            Damage += random.Next(15, 22);
            speler2.Hp -= Damage;
            Damage = 0;
            ZwareAanvalGebruikt = !ZwareAanvalGebruikt;
            HealCount++;

        }

        public override string ToString()
        {
            return "Assassin.";
        }
    }
}
