using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedGame
{
    public class Medic : Speler
    {
        private int maxHp;

        public Medic()
        {
            Hp = 50;
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
            Damage += random.Next(12, 17);
            speler2.Hp -= Damage;
            Damage = 0;
            ZwareAanvalGebruikt = !ZwareAanvalGebruikt;
            HealCount++;
        }

        public override void Healen()
        {
            int heal = random.Next(20, 25);
            if (heal + Hp < MaxHp)
            {
                Hp += heal;
            }

            Heal = !Heal;
            HealCount = 0;
        }

        public override string ToString()
        {
            return "Medic";
        }
    }
}
