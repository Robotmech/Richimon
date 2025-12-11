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
                    target.HealthPoints -= 500;
                    target.Condition = "Stun";
                    target.ConditionTime = 3;
                    return;

                case "Doom":
                    Console.WriteLine($"The sky's color is overshadowed by a glooming red orb, appearing from the palm of Richard's Hand. As he raises his hand, the orb shifts into the form of a black hole and seconds later, explodes in a wide area, giving {target.Name} no chance to dodge and doing 300 Damage");
                    target.HealthPoints -= 300; 
                    return;

                case "Fish cage":
                    Console.WriteLine($"{Name} spawns an indestructible, fenced cage around {target.Name}, making them unable to make a turn for 10 rounds");
                    target.Condition = "Stunned";
                    target.ConditionTime = 10;
                    return;

                case "Flash":
                    Console.WriteLine($"{Name} Flashes the enemy and deals 100 damage. The flash is so strong, that the enemy is confused for 3 rounds");
                    target.HealthPoints -= 100;
                    target.Condition = "Confused";
                    target.ConditionTime = 3;
                    return;

                case "FESCHT HÄBE":
                    Console.WriteLine("Richi holds down the enemy with all his might, restraining him for 5 rounds");
                    target.Condition = "Restrained";
                    target.ConditionTime = 5;
                    return;

                case "Chained Storms":
                    Console.WriteLine($"{Name} calls down chained lightning that crashes into {target.Name}, dealing 180 damage and stunning them for 2 rounds!");
                    target.HealthPoints -= 180;
                    target.Condition = "Stunned";
                    target.ConditionTime = 2;
                    return;

                case "Concentrated Meteor":
                    Console.WriteLine($"{Name} compresses a meteor and drops it onto {target.Name}, dealing 160 damage and burning them for 3 rounds!");
                    target.HealthPoints -= 160;
                    target.Condition = "Burned";
                    target.ConditionTime = 3;
                    return;

                case "Luminar Buff":
                    Console.WriteLine($"{Name} is blessed by lunar energy, gaining a glowing shield that boosts their Defense for 3 rounds!");
                    Condition = "DefenseUp";
                    ConditionTime = 3;
                    return;

                case "Pierced Focus":
                    Console.WriteLine($"{Name} focuses completely and strikes {target.Name}'s weakest spot, dealing 120 damage!");
                    target.HealthPoints -= 120;
                    return;

                case "Titan Knuckle":
                    Console.WriteLine($"{Name} slams a massive fist into {target.Name}, dealing 140 damage and stunning them for 1 round!");
                    target.HealthPoints -= 140;
                    target.Condition = "Stunned";
                    target.ConditionTime = 1;
                    return;

                case "Ember Lock":
                    Console.WriteLine($"{Name} traps {target.Name} in swirling embers, dealing 110 damage and burning them for 2 rounds!");
                    target.HealthPoints -= 110;
                    target.Condition = "Burned";
                    target.ConditionTime = 2;
                    return;

                case "Mind Fracture":
                    Console.WriteLine($"{Name} fractures {target.Name}'s thoughts with a psychic burst, dealing 100 damage and weakening them!");
                    target.HealthPoints -= 100;
                    target.Condition = "Weakened";
                    target.ConditionTime = 3;
                    return;

                case "Blaze Lance":
                    Console.WriteLine($"{Name} fires a sharp flame lance at {target.Name}, dealing 130 damage!");
                    target.HealthPoints -= 130;
                    return;

                case "Volt Stunwave":
                    Console.WriteLine($"{Name} sends a shockwave through {target.Name}, dealing 100 damage and paralyzing them!");
                    target.HealthPoints -= 100;
                    target.Condition = "Paralyzed";
                    target.ConditionTime = 1;
                    return;

                case "Cursed Snap":
                    Console.WriteLine($"{Name} snaps a curse onto {target.Name}, dealing 90 damage and weakening their defenses!");
                    target.HealthPoints -= 90;
                    target.Condition = "DefenseDown";
                    target.ConditionTime = 3;
                    return;

                case "Royal Hex":
                    Console.WriteLine($"{Name} casts a royal hex on {target.Name}, dealing extra damage if they are already afflicted!");
                    int dmg = string.IsNullOrEmpty(target.Condition) ? 80 : 160;
                    target.HealthPoints -= dmg;
                    return;

                case "Neural Freeze":
                    Console.WriteLine($"{Name} freezes {target.Name}'s thoughts, dealing 90 damage and slowing them!");
                    target.HealthPoints -= 90;
                    target.Condition = "Slowed";
                    target.ConditionTime = 1;
                    return;

                case "Mud Concussion":
                    Console.WriteLine($"{Name} slams mud into {target.Name}, dealing 100 damage and stunning them!");
                    target.HealthPoints -= 100;
                    target.Condition = "Stunned";
                    target.ConditionTime = 1;
                    return;

                case "Gravity Drop":
                    Console.WriteLine($"{Name} increases gravity around {target.Name}, crushing them and pinning them down!");
                    int grav = Math.Max(1, target.HealthPoints / 20); // 5% HP
                    target.HealthPoints -= grav;
                    target.Condition = "Pinned";
                    target.ConditionTime = 1;
                    return;

                case "Psyshock Torrent":
                    Console.WriteLine($"{Name} blasts {target.Name} with psychic water, dealing 90 damage and confusing them!");
                    target.HealthPoints -= 90;
                    target.Condition = "Confused";
                    target.ConditionTime = 1;
                    return;

                case "Coil Slam":
                    Console.WriteLine($"{Name} coils up and slams into {target.Name}, dealing 80 damage and dazing them!");
                    target.HealthPoints -= 80;
                    target.Condition = "Dazed";
                    target.ConditionTime = 1;
                    return;

                case "Timber Bash":
                    Console.WriteLine($"{Name} bashes {target.Name} with a heavy swing, dealing 70 damage and making them flinch!");
                    target.HealthPoints -= 70;
                    target.Condition = "Flinched";
                    target.ConditionTime = 1;
                    return;

                case "Seismic Spike":
                    Console.WriteLine($"{Name} erupts the ground beneath {target.Name}, dealing 100 damage and stunning them!");
                    target.HealthPoints -= 100;
                    target.Condition = "Stunned";
                    target.ConditionTime = 1;
                    return;

                case "Bitchass Hating":
                    Console.WriteLine($"{Name} verbally destroys {target.Name}, dealing 40 damage and crushing their morale!");
                    target.HealthPoints -= 40;
                    target.Condition = "Demoralized";
                    target.ConditionTime = 3;
                    return;

                case "Feet Feast":
                    Console.WriteLine($"{Name} performs a disturbing ritual on {target.Name}, dealing 50 damage and blocking buffs!");
                    target.HealthPoints -= 50;
                    target.Condition = "NoBuffs";
                    target.ConditionTime = 2;
                    return;

                case "Stalk":
                    Console.WriteLine($"{Name} quietly marks {target.Name}, making them take more damage for 3 rounds!");
                    target.Condition = "Marked";
                    target.ConditionTime = 3;
                    return;

                case "goon":
                    Console.WriteLine($"{Name} recklessly charges {target.Name}, dealing 40 damage and exposing their defense!");
                    target.HealthPoints -= 40;
                    target.Condition = "DefenseDown";
                    target.ConditionTime = 1;
                    return;

                case "Call of the Voices":
                    Console.WriteLine($"{Name} channels strange voices into {target.Name}, dealing 70 damage and causing panic!");
                    target.HealthPoints -= 70;
                    target.Condition = "Panicked";
                    target.ConditionTime = 2;
                    return;

                case "Fire Breath":
                    Console.WriteLine($"{Name} breathes fire at {target.Name}, dealing 60 damage and burning them!");
                    target.HealthPoints -= 60;
                    target.Condition = "Burned";
                    target.ConditionTime = 2;
                    return;

                case "Lightning":
                    Console.WriteLine($"{Name} strikes {target.Name} with lightning, dealing 70 damage and paralyzing them!");
                    target.HealthPoints -= 70;
                    target.Condition = "Paralyzed";
                    target.ConditionTime = 1;
                    return;

                case "Mud Pop":
                    Console.WriteLine($"{Name} pops mud at {target.Name}, dealing 40 damage and slowing them!");
                    target.HealthPoints -= 40;
                    target.Condition = "Slowed";
                    target.ConditionTime = 1;
                    return;

                case "Adapt Burst":
                    Console.WriteLine($"{Name} fires an adaptive strike, dealing 30 damage and boosting their own strength!");
                    target.HealthPoints -= 30;
                    Condition = "AttackUp";
                    ConditionTime = 2;
                    return;

                case "Head Pulse":
                    Console.WriteLine($"{Name} sends a sudden pulse into {target.Name}, dealing 50 damage and confusing them!");
                    target.HealthPoints -= 50;
                    target.Condition = "Confused";
                    target.ConditionTime = 1;
                    return;

                case "Timber Nudge":
                    Console.WriteLine($"{Name} nudges {target.Name}, dealing 20 damage and making them flinch!");
                    target.HealthPoints -= 20;
                    target.Condition = "Flinched";
                    target.ConditionTime = 1;
                    return;

                case "Burrow Sting":
                    Console.WriteLine($"{Name} bursts from underground and strikes {target.Name}, dealing 40 damage!");
                    target.HealthPoints -= 40;
                    return;

                case "Iron Spirit":
                    Console.WriteLine($"{Name} strikes with hardened resolve, dealing 30 damage and raising their defense!");
                    target.HealthPoints -= 30;
                    Condition = "DefenseUp";
                    ConditionTime = 1;
                    return;

                case "Boulder Jab":
                    Console.WriteLine($"{Name} jabs {target.Name} with rock-like force, dealing 50 damage and slowing them!");
                    target.HealthPoints -= 50;
                    target.Condition = "Slowed";
                    target.ConditionTime = 1;
                    return;

                case "Spark Claw":
                    Console.WriteLine($"{Name} slashes {target.Name} with a spark-covered claw, dealing 40 damage!");
                    target.HealthPoints -= 40;
                    return;

                case "Mind Skip":
                    Console.WriteLine($"{Name} interrupts {target.Name}'s thoughts, forcing them to skip their next turn!");
                    target.Condition = "Stunned";
                    target.ConditionTime = 1;
                    return;

                case "Lazy Slide":
                    Console.WriteLine($"{Name} lazily slides into {target.Name}, dealing 20 damage and slowing them!");
                    target.HealthPoints -= 20;
                    target.Condition = "Slowed";
                    target.ConditionTime = 1;
                    return;

                case "Aqua Flick":
                    Console.WriteLine($"{Name} flicks a droplet of water at {target.Name}, dealing 10 damage!");
                    target.HealthPoints -= 10;
                    return;

                case "Static Peep":
                    Console.WriteLine($"{Name} releases a tiny static chirp at {target.Name}, dealing 20 damage and paralyzing them!");
                    target.HealthPoints -= 20;
                    target.Condition = "Paralyzed";
                    target.ConditionTime = 1;
                    return;
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
