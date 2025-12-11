using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mob
{
    public class Ability
    {
        public Action<Pokemon, Pokemon> Effect;

        //one

        public static Dictionary<string, Ability> Specials = new Dictionary<string, Ability>()
        {
            {
                "Rapture",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"Divine Intellect rips reality apart, {target.Name}'s existence fully vanishes"
                        );
                        target.HealthPoints = 0;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Afisholypse",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"Huge sized Fish fly down from the sky and rain down on {target.Name}. {target.Name} takes 500 Damage and is Stunned for 3 rounds!"
                        );
                        target.HealthPoints -= 500;
                        target.Condition = "Stun";
                        target.ConditionTime = 3;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Doom",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"The sky's color is overshadowed by a glooming red orb, appearing from the palm of Richard's Hand. As he raises his hand, the orb shifts into the form of a black hole and seconds later, explodes in a wide area, giving {target.Name} no chance to dodge and doing 300 Damage"
                        );
                        target.HealthPoints -= 300;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Fish cage",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} spawns an indestructible, fenced cage around {target.Name}, making them unable to make a turn for 10 rounds"
                        );
                        target.Condition = "Stunned";
                        target.ConditionTime = 10;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Flash",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} Flashes the enemy and deals 100 damage. The flash is so strong, that the enemy is confused for 3 rounds"
                        );
                        target.HealthPoints -= 100;
                        target.Condition = "Confused";
                        target.ConditionTime = 3;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "FESCHT HÄBE",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            "Richi holds down the enemy with all his might, restraining him for 5 rounds"
                        );
                        target.Condition = "Restrained";
                        target.ConditionTime = 5;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Chained Storms",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} calls down chained lightning that crashes into {target.Name}, dealing 180 damage and stunning them for 2 rounds!"
                        );
                        target.HealthPoints -= 180;
                        target.Condition = "Stunned";
                        target.ConditionTime = 2;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Concentrated Meteor",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} compresses a meteor and drops it onto {target.Name}, dealing 160 damage and burning them for 3 rounds!"
                        );
                        target.HealthPoints -= 160;
                        target.Condition = "Burned";
                        target.ConditionTime = 3;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Luminar Buff",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} is blessed by lunar energy, gaining a glowing shield that boosts their Defense for 3 rounds!"
                        );
                        user.Condition = "DefenseUp";
                        user.ConditionTime = 3;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Pierced Focus",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} focuses completely and strikes {target.Name}'s weakest spot, dealing 120 damage!"
                        );
                        target.HealthPoints -= 120;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Titan Knuckle",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} slams a massive fist into {target.Name}, dealing 140 damage and stunning them for 1 round!"
                        );
                        target.HealthPoints -= 140;
                        target.Condition = "Stunned";
                        target.ConditionTime = 1;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Ember Lock",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} traps {target.Name} in swirling embers, dealing 110 damage and burning them for 2 rounds!"
                        );
                        target.HealthPoints -= 110;
                        target.Condition = "Burned";
                        target.ConditionTime = 2;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Mind Fracture",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} fractures {target.Name}'s thoughts with a psychic burst, dealing 100 damage and weakening them!"
                        );
                        target.HealthPoints -= 100;
                        target.Condition = "Weakened";
                        target.ConditionTime = 3;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Blaze Lance",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} fires a sharp flame lance at {target.Name}, dealing 130 damage!"
                        );
                        target.HealthPoints -= 130;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Volt Stunwave",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} sends a shockwave through {target.Name}, dealing 100 damage and paralyzing them!"
                        );
                        target.HealthPoints -= 100;
                        target.Condition = "Paralyzed";
                        target.ConditionTime = 1;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Cursed Snap",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} snaps a curse onto {target.Name}, dealing 90 damage and weakening their defenses!"
                        );
                        target.HealthPoints -= 90;
                        target.Condition = "DefenseDown";
                        target.ConditionTime = 3;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Royal Hex",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} casts a royal hex on {target.Name}, dealing extra damage if they are already afflicted!"
                        );
                        int dmg = string.IsNullOrEmpty(target.Condition) ? 80 : 160;
                        target.HealthPoints -= dmg;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Neural Freeze",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} freezes {target.Name}'s thoughts, dealing 90 damage and slowing them!"
                        );
                        target.HealthPoints -= 90;
                        target.Condition = "Slowed";
                        target.ConditionTime = 1;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Mud Concussion",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} slams mud into {target.Name}, dealing 100 damage and stunning them!"
                        );
                        target.HealthPoints -= 100;
                        target.Condition = "Stunned";
                        target.ConditionTime = 1;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Gravity Drop",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} increases gravity around {target.Name}, crushing them and pinning them down!"
                        );
                        int grav = Math.Max(1, target.HealthPoints / 20);
                        target.HealthPoints -= grav;
                        target.Condition = "Pinned";
                        target.ConditionTime = 1;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Psyshock Torrent",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} blasts {target.Name} with psychic water, dealing 90 damage and confusing them!"
                        );
                        target.HealthPoints -= 90;
                        target.Condition = "Confused";
                        target.ConditionTime = 1;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Coil Slam",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} coils up and slams into {target.Name}, dealing 80 damage and dazing them!"
                        );
                        target.HealthPoints -= 80;
                        target.Condition = "Dazed";
                        target.ConditionTime = 1;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Timber Bash",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} bashes {target.Name} with a heavy swing, dealing 70 damage and making them flinch!"
                        );
                        target.HealthPoints -= 70;
                        target.Condition = "Flinched";
                        target.ConditionTime = 1;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Seismic Spike",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} erupts the ground beneath {target.Name}, dealing 100 damage and stunning them!"
                        );
                        target.HealthPoints -= 100;
                        target.Condition = "Stunned";
                        target.ConditionTime = 1;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Bitchass Hating",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} verbally destroys {target.Name}, dealing 40 damage and crushing their morale!"
                        );
                        target.HealthPoints -= 40;
                        target.Condition = "Demoralized";
                        target.ConditionTime = 3;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Feet Feast",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} feasts on the Feet of {target.Name}, dealing 50 damage and blocking buffs!"
                        );
                        target.HealthPoints -= 50;
                        target.Condition = "NoBuffs";
                        target.ConditionTime = 2;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Stalk",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} quietly marks {target.Name}, making them take more damage for 3 rounds!"
                        );
                        target.Condition = "Marked";
                        target.ConditionTime = 3;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "goon",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} recklessly charges {target.Name}, dealing 40 damage and exposing their defense!"
                        );
                        target.HealthPoints -= 40;
                        target.Condition = "DefenseDown";
                        target.ConditionTime = 1;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Call of the Voices",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} channels strange voices into {target.Name}, dealing 70 damage and causing panic!"
                        );
                        target.HealthPoints -= 70;
                        target.Condition = "Panicked";
                        target.ConditionTime = 2;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Fire Breath",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} breathes fire at {target.Name}, dealing 60 damage and burning them!"
                        );
                        target.HealthPoints -= 60;
                        target.Condition = "Burned";
                        target.ConditionTime = 2;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Lightning",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} strikes {target.Name} with lightning, dealing 70 damage and paralyzing them!"
                        );
                        target.HealthPoints -= 70;
                        target.Condition = "Paralyzed";
                        target.ConditionTime = 1;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Mud Pop",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} pops mud at {target.Name}, dealing 40 damage and slowing them!"
                        );
                        target.HealthPoints -= 40;
                        target.Condition = "Slowed";
                        target.ConditionTime = 1;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Adapt Burst",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} fires an adaptive strike, dealing 30 damage and boosting their own strength!"
                        );
                        target.HealthPoints -= 30;
                        user.Condition = "AttackUp";
                        user.ConditionTime = 2;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Head Pulse",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} sends a sudden pulse into {target.Name}, dealing 50 damage and confusing them!"
                        );
                        target.HealthPoints -= 50;
                        target.Condition = "Confused";
                        target.ConditionTime = 1;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Timber Nudge",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} nudges {target.Name}, dealing 20 damage and making them flinch!"
                        );
                        target.HealthPoints -= 20;
                        target.Condition = "Flinched";
                        target.ConditionTime = 1;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Burrow Sting",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} bursts from underground and strikes {target.Name}, dealing 40 damage!"
                        );
                        target.HealthPoints -= 40;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Iron Spirit",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} strikes with hardened resolve, dealing 30 damage and raising their defense!"
                        );
                        target.HealthPoints -= 30;
                        user.Condition = "DefenseUp";
                        user.ConditionTime = 1;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Boulder Jab",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} jabs {target.Name} with rock-like force, dealing 50 damage and slowing them!"
                        );
                        target.HealthPoints -= 50;
                        target.Condition = "Slowed";
                        target.ConditionTime = 1;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Spark Claw",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} slashes {target.Name} with a spark-covered claw, dealing 40 damage!"
                        );
                        target.HealthPoints -= 40;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Mind Skip",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} interrupts {target.Name}'s thoughts, forcing them to skip their next turn!"
                        );
                        target.Condition = "Stunned";
                        target.ConditionTime = 1;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Lazy Slide",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} lazily slides into {target.Name}, dealing 20 damage and slowing them!"
                        );
                        target.HealthPoints -= 20;
                        target.Condition = "Slowed";
                        target.ConditionTime = 1;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Aqua Flick",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} flicks a droplet of water at {target.Name}, dealing 10 damage!"
                        );
                        target.HealthPoints -= 10;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Static Peep",
                new Ability
                {
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} releases a tiny static chirp at {target.Name}, dealing 20 damage and paralyzing them!"
                        );
                        target.HealthPoints -= 20;
                        target.Condition = "Paralyzed";
                        target.ConditionTime = 1;
                        user.SpecialCharge = 0;
                    },
                }
            },
        };
    }
}
