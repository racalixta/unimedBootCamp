using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoPOO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return $"\n{this.Name} - Usou um feitiço\n";
        }
        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return $"\n{this.Name} - Lançou Magia super efetiva com {Bonus} de bonus\n";
            }
            else 
            {
                return $"\n{this.Name} - Lançou Magia com {Bonus} de bonus\n";
            }

        }
    }
}