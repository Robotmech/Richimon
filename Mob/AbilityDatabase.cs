using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mob
{
    public class AbilityDatabase
    {
        public static Dictionary<string, Ability> Specials = new Dictionary<string, Ability>()
        {
            {
                "Rapture",
                new Ability
                {
                    ChargeNeeded = 5,
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
                    ChargeNeeded = 4,
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
                    ChargeNeeded = 4,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"A black hole explodes in a wide area, doing 300 Damage to {target.Name}!"
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
                    ChargeNeeded = 3,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} traps {target.Name} in an unbreakable cage for 10 rounds!"
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
                    ChargeNeeded = 3,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} flashes {target.Name}, dealing 100 damage and confusing them!"
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
                    ChargeNeeded = 3,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"Richi restrains {target.Name} for 5 rounds!");
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
                    ChargeNeeded = 3,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} deals 180 lightning damage and stuns {target.Name}!"
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
                    ChargeNeeded = 3,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} drops a compressed meteor on {target.Name}, dealing 160 and burning them!"
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
                    ChargeNeeded = 2,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name}'s defense rises for 3 rounds!");
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
                    ChargeNeeded = 2,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} deals 120 piercing damage to {target.Name}!"
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
                    ChargeNeeded = 2,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} smashes {target.Name} for 140 damage and a stun!"
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
                    ChargeNeeded = 2,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} burns {target.Name} for 110 damage!");
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
                    ChargeNeeded = 2,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} deals 100 psychic damage and weakens {target.Name}!"
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
                    ChargeNeeded = 2,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} deals 130 flame damage!");
                        target.HealthPoints -= 130;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Volt Stunwave",
                new Ability
                {
                    ChargeNeeded = 2,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} shocks {target.Name} for 100 damage and paralysis!"
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
                    ChargeNeeded = 2,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} curses {target.Name}, dealing 90 and lowering defense!"
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
                    ChargeNeeded = 2,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} casts a hex dealing variable damage!");
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
                    ChargeNeeded = 2,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} freezes {target.Name}'s thoughts for 90 damage!"
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
                    ChargeNeeded = 2,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} slams {target.Name} for 100 damage and stun!"
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
                    ChargeNeeded = 2,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} crushes {target.Name} under gravity!");
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
                    ChargeNeeded = 2,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} deals 90 psychic-water damage!");
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
                    ChargeNeeded = 1,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} slams {target.Name} for 80 damage!");
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
                    ChargeNeeded = 1,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} bashes {target.Name} for 70 damage!");
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
                    ChargeNeeded = 2,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} erupts the ground, dealing 100!");
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
                    ChargeNeeded = 1,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} verbally destroys {target.Name}, dealing 40!"
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
                    ChargeNeeded = 1,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} deals 50 damage and blocks buffs!");
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
                    ChargeNeeded = 1,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} marks {target.Name} for increased future damage!"
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
                    ChargeNeeded = 1,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} recklessly charges for 40 damage!");
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
                    ChargeNeeded = 2,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine(
                            $"{user.Name} channels voices, dealing 70 and causing panic!"
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
                    ChargeNeeded = 1,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} burns {target.Name} for 60 damage!");
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
                    ChargeNeeded = 1,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} shocks {target.Name} for 70!");
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
                    ChargeNeeded = 1,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} mud-pops {target.Name} for 40!");
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
                    ChargeNeeded = 1,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} deals 30 damage and raises Attack!");
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
                    ChargeNeeded = 1,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} pulses {target.Name}'s brain for 50!");
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
                    ChargeNeeded = 1,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} nudges {target.Name} for 20!");
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
                    ChargeNeeded = 1,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} bursts from underground for 40!");
                        target.HealthPoints -= 40;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Iron Spirit",
                new Ability
                {
                    ChargeNeeded = 1,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} deals 30 and increases Defense!");
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
                    ChargeNeeded = 1,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} jabs {target.Name} for 50 and slows them!");
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
                    ChargeNeeded = 1,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} slashes for 40 damage!");
                        target.HealthPoints -= 40;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Mind Skip",
                new Ability
                {
                    ChargeNeeded = 1,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} forces {target.Name} to skip a turn!");
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
                    ChargeNeeded = 1,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} slides lazily for 20 damage!");
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
                    ChargeNeeded = 1,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} flicks water for 10 damage!");
                        target.HealthPoints -= 10;
                        user.SpecialCharge = 0;
                    },
                }
            },
            {
                "Static Peep",
                new Ability
                {
                    ChargeNeeded = 1,
                    Effect = (user, target) =>
                    {
                        Console.WriteLine($"{user.Name} peeps static for 20 damage and paralysis!");
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
