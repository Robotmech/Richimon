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

        public string Special { get; }
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
            switch (Special)
            {
                case "Rapture":
                    Console.WriteLine(
                        $"Divine Intellect rips reality apart, {target.Name}'s existence fully vanishes"
                    );
                    target.HealthPoints = 0;
                    return;

                case "Afisholypse":
                    Console.WriteLine(
                        $"Huge sized Fish fly down from the sky and rain down on {target.Name}. {target.Name} takes 500 Damage and is Stunned for 3 rounds!"
                    );
                    target.HealthPoints = -500;
                    return;

                case "Doom":
                    Console.WriteLine("The sky's color is overshadowed by a glooming red ");
                    return;

                case "Fish cage":
                    return;

                case "immense shield":
                    return;

                case "FESCHT HÄBE":
                    return;

                case "Chained Storms":
                    return;

                case "Concentrated Meteor":
                    return;

                case "Luminar Buff":
                    return;

                case "Pierced Focus":
                    return;

                case "Titan Knuckle":
                    return;

                case "Ember Lock":
                    return;

                case "Mind Fracture":
                    return;

                case "Blaze Lance":
                    return;

                case "Volt Stunwave":
                    return;

                case "Cursed Snap":
                    return;

                case "Royal Hex":
                    return;

                case "Neural Freeze":
                    return;

                case "Mud Concussion":
                    return;

                case "Gravity Drop":
                    return;

                case "Psyshock Torrent":
                    return;

                case "Coil Slam":
                    return;

                case "Timber Bash":
                    return;

                case "Seismic Spike":
                    return;

                case "Bitchass Hating":
                    return;

                case "Feet Feast":
                    return;

                case "Stalk":
                    return;

                case "goon":
                    return;

                case "Call of the Voices":
                    return;

                case "Fire Breath":
                    return;

                case "Lightning":
                    return;

                case "Mud Pop":
                    return;

                case "Adapt Burst":
                    return;

                case "Head Pulse":
                    return;

                case "Timber Nudge":
                    return;

                case "Burrow Sting":
                    return;

                case "Iron Spirit":
                    return;

                case "Boulder Jab":
                    return;

                case "Spark Claw":
                    return;

                case "Mind Skip":
                    return;

                case "Lazy Slide":
                    return;

                case "Aqua Flick":
                    return;

                case "Static Peep":
                    return;
            }
            if (target.HealthPoints <= 0)
            {
                Console.WriteLine($"{target.Name} is already defeated.");
                return;
            }
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
