using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedGame
{
    public abstract class Speler
    {
        public Random random = new Random();
        public bool Heal { get; set; }
        public bool ZwareAanvalGebruikt { get; set; }
        public int MaxHp { get; set; }
        public int HealCount { get; set; }
        public string Naam { get; set; }
        public int Hp { get; set; }
        public int Damage { get; set; }

        public virtual void LichteAanval(Speler speler2)
        {
            //aanval met random damage, damage verschilt per class
            Damage += random.Next(1, 10);
            speler2.Hp -= Damage;
            Damage = 0;
        }
        public virtual void ZwareAanval(Speler speler2)
        {
            //na 1 zware aanval 1 beurt wachten om weer te gebruiken
            Damage += random.Next(10, 18);
            speler2.Hp -= Damage;
            Damage = 0;
            ZwareAanvalGebruikt = !ZwareAanvalGebruikt;
        }

        public virtual void Healen()
        {
            //na heal gebruiken, 3 beurten wachten met healen
            //medic healt meer
            int heal = random.Next(5, 20);
            if (heal + Hp < MaxHp)
            {
                Hp += heal;
            }

            Heal = !Heal;
            HealCount = 0;
        }

        public bool CheckVoorWinst()
        {
            //geeft true terug als hp onder 0 is
            if (Hp <= 0)
            {
                return true;
            }
            return false;
        }
    }
}
