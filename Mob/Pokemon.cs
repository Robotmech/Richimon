using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mob
{
    internal class Pokemon
    {
        public string Name { get; }
        public int AttackPower { get; private set; }
        public int DefensePower { get; private set; }
        public int HealthPoints { get; set; }
        public string Weapon { get; private set; }
        public bool InCover { get; private set; }

        public Pokemon(string name, int attackPower, int defensePower, int healthPoints, string weapon)
        {
            Name = name;
            HealthPoints = healthPoints;
            Weapon = weapon;
            AttackPower = attackPower * ;
            DefensePower = defensePower
            this.positionX = positionX;
            this.positionY = positionY;
            Console.WriteLine($"PMC {this.Name} created: ");
        }

    }
}
