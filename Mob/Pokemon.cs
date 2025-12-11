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
        public int AttackPower { get; set; }
        public int DefensePower { get; set; }
        public int HealthPoints { get; set; }
        public string Weapon { get; set; }

        public string Condition { get; set; }
        public int ConditionTime { get; set; }
        public string Special { get; }
        public int SpecialCharge { get; set; }
        public bool InCover { get; set; }

        public Pokemon(
            string name,
            int attackPower,
            int defensePower,
            int healthPoints,
            string condition,
            string weapon,
            string special
        )
        {
            Name = name;
            HealthPoints = healthPoints;
            Weapon = weapon;
            DefensePower = defensePower;
            AttackPower = CalculateAttackPower(attackPower);
        }

        public void PokeAttack(Pokemon target)
        {
            if (target.HealthPoints <= 0)
            {
                Console.WriteLine($"{target.Name} is already defeated.");
                return;
            }

            int damage = Math.Max(0, this.AttackPower - target.DefensePower);

            target.HealthPoints -= damage;
            if (target.HealthPoints < 0)
                target.HealthPoints = 0;
            ;

            if (target.HealthPoints <= 0)
            {
                Console.WriteLine(
                    $"{this.Name} attacked {target.Name} with {this.Weapon} dealing {damage} damage. {target.Name} has been killed!"
                );
                return;
            }
            else
            {
                Console.WriteLine(
                    $"{this.Name} attacked {target.Name} with {this.Weapon} dealing {damage} damage. {target.Name} has {target.HealthPoints} HP left."
                );
            }
        }

        public void PokeSpecial(Pokemon target)
        {
            Ability.Specials[Special].Effect()
        }

        public double ReturnWeaponMutliplier(string name)
        {
            switch (name)
            {
                case "":
                    return 1.0;
                case "1":
                    return 1.1;
                case "2":
                    return 1.2;
                case "3":
                    return 1.3;
                case "4":
                    return 1.4;
                default:
                    return 1.5;
            }
        }

        public int CalculateAttackPower(int atP)
        {
            return Convert.ToInt32(atP * (ReturnWeaponMutliplier(Weapon)));
        }
    }
}
