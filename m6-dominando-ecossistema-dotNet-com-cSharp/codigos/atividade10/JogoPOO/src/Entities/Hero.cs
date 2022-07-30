using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoPOO.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Hero()
        {
            
        }

        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString()
        {
            return $"\nSou o {this.Name}, level {this.Level} e sou um {this.HeroType}\n";
        }

        public virtual string Attack()
        {
            return $"\nHero{this.Name} - Atacou com sua espada\n";
        }
    }
}