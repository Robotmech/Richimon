using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mob;

namespace Mob
{
    internal class WeaponDatabase
    {
        public static Dictionary<string, Weapon> weapons = new Dictionary<string, Weapon>
        {
            {
                "Wasserpistole",
                new Weapon
                {
                    Name = "Wasserpistole",
                    wpMulti = 0,
                    wpSpc = (user, target) =>
                    {
                        if (Globals.rng.Next(1, 51) == 1)
                        {
                            Console.WriteLine(
                                $"The Waterpistol hits clean into the brain of {target.Name}, killing them instantly!"
                            );
                            target.HealthPoints = 0;
                        }
                        else
                        {
                            Console.WriteLine(
                                $"The Water of the pistol splashes onto the enemy, dealing 0 damage!"
                            );
                        }
                    },
                }
            },
            {
                "FIH",
                new Weapon
                {
                    Name = "FIH",
                    wpMulti = 0,
                    wpSpc = (user, target) =>
                    {
                        if (Globals.rng.Next(1, 11) == 1)
                        {
                            Console.WriteLine(
                                $"The FIH hits clean into the brain of {target.Name}, killing them instantly!"
                            );
                            target.HealthPoints = 0;
                        }
                        else
                        {
                            Console.WriteLine(
                                $"The Spit of the FIH splashes onto the enemy, dealing 0 damage!"
                            );
                        }
                    },
                }
            },
            {
                "Lil Richie",
                new Weapon
                {
                    Name = "Lil Richie",
                    wpMulti = 0,
                    wpSpc = (user, target) =>
                    {
                        if (Globals.rng.Next(1, 3) == 1)
                        {
                            Console.WriteLine(
                                $"The Lil Richie hits clean into the brain of {target.Name}, killing them instantly!"
                            );
                            target.HealthPoints = 0;
                        }
                        else
                        {
                            Console.WriteLine(
                                $"The Lil Richie explodes when it was drawn, killing {user.Name} instantly!"
                            );
                            user.HealthPoints = 0;
                        }
                    },
                }
            },
            // ===============================
            // HIGH DAMAGE + SELF DAMAGE
            // ===============================

            {
                "Messer",
                new Weapon
                {
                    Name = "Messer",
                    wpMulti = 1.2,
                    wpSpc = (user, target) =>
                    {
                        int dmg = (int)(user.AttackPower * 1.2f * (1 - target.DefensePower / 100f));

                        int maxSelf = user.HealthPoints / 3;
                        int self = Globals.rng.Next(1, maxSelf + 1);

                        Console.WriteLine(
                            $"{user.Name} strikes {target.Name} with a Messer, dealing {dmg} damage and taking {self} self-damage!"
                        );

                        target.HealthPoints -= dmg;
                        user.HealthPoints -= self;
                    },
                }
            },
            {
                "Machete",
                new Weapon
                {
                    Name = "Machete",
                    wpMulti = 1.8,
                    wpSpc = (user, target) =>
                    {
                        int dmg = (int)(user.AttackPower * 1.8f * (1 - target.DefensePower / 100f));

                        int maxSelf = user.HealthPoints / 3;
                        int self = Globals.rng.Next(1, maxSelf + 1);

                        Console.WriteLine(
                            $"{user.Name} hacks {target.Name} with a Machete, dealing {dmg} damage and taking {self} recoil!"
                        );

                        target.HealthPoints -= dmg;
                        user.HealthPoints -= self;
                    },
                }
            },
            {
                "Zweihänder",
                new Weapon
                {
                    Name = "Zweihänder",
                    wpMulti = 2.5,
                    wpSpc = (user, target) =>
                    {
                        int dmg = (int)(user.AttackPower * 2.5f * (1 - target.DefensePower / 100f));

                        int maxSelf = user.HealthPoints / 3;
                        int self = Globals.rng.Next(1, maxSelf + 1);

                        Console.WriteLine(
                            $"{user.Name} swings the Zweihänder, dealing {dmg} and taking {self} recoil!"
                        );

                        target.HealthPoints -= dmg;
                        user.HealthPoints -= self;
                    },
                }
            },
            // ===============================
            // RELIABLE DAMAGE
            // ===============================

            {
                "Glock",
                new Weapon
                {
                    Name = "Glock",
                    wpMulti = 1.0,
                    wpSpc = (user, target) =>
                    {
                        int dmg = (int)(user.AttackPower * 1.0f * (1 - target.DefensePower / 100f));
                        Console.WriteLine(
                            $"{user.Name} fires a Glock and deals {dmg} reliable damage!"
                        );
                        target.HealthPoints -= dmg;
                    },
                }
            },
            {
                "MP5",
                new Weapon
                {
                    Name = "MP5",
                    wpMulti = 1.3,
                    wpSpc = (user, target) =>
                    {
                        int dmg = (int)(user.AttackPower * 1.3f * (1 - target.DefensePower / 100f));
                        Console.WriteLine($"{user.Name} unloads an MP5, dealing {dmg}!");
                        target.HealthPoints -= dmg;
                    },
                }
            },
            {
                "AK",
                new Weapon
                {
                    Name = "AK",
                    wpMulti = 1.6,
                    wpSpc = (user, target) =>
                    {
                        int dmg = (int)(user.AttackPower * 1.6f * (1 - target.DefensePower / 100f));
                        Console.WriteLine($"{user.Name} fires an AK for {dmg} damage!");
                        target.HealthPoints -= dmg;
                    },
                }
            },
            // ===============================
            // BIG DAMAGE + RELOAD
            // ===============================

            {
                "Granate",
                new Weapon
                {
                    Name = "Granate",
                    wpMulti = 2.0,
                    wpSpc = (user, target) =>
                    {
                        int dmg = (int)(user.AttackPower * 2.0f * (1 - target.DefensePower / 100f));
                        Console.WriteLine(
                            $"{user.Name} throws a grenade for {dmg} damage! Reload = 1 round."
                        );
                        target.HealthPoints -= dmg;
                        user.ReloadTime = 1;
                    },
                }
            },
            {
                "Rocketlauncher",
                new Weapon
                {
                    Name = "Rocketlauncher",
                    wpMulti = 3.0,
                    wpSpc = (user, target) =>
                    {
                        int dmg = (int)(user.AttackPower * 3.0f * (1 - target.DefensePower / 100f));
                        Console.WriteLine(
                            $"{user.Name} fires a rocket for {dmg}! Reload = 2 rounds."
                        );
                        target.HealthPoints -= dmg;
                        user.ReloadTime = 2;
                    },
                }
            },
            {
                "Nukelauncher",
                new Weapon
                {
                    Name = "Nukelauncher",
                    wpMulti = 4.0,
                    wpSpc = (user, target) =>
                    {
                        int dmg = (int)(user.AttackPower * 4.0f * (1 - target.DefensePower / 100f));
                        Console.WriteLine(
                            $"{user.Name} launches a NUKE for {dmg}!!! Reload = 3 rounds."
                        );
                        target.HealthPoints -= dmg;
                        user.ReloadTime = 3;
                    },
                }
            },
            // ===============================
            // HEALING + SMALL DAMAGE
            // ===============================

            {
                "Vape",
                new Weapon
                {
                    Name = "Vape",
                    wpMulti = 0.5,
                    wpSpc = (user, target) =>
                    {
                        int dmg = (int)(user.AttackPower * 0.5f * (1 - target.DefensePower / 100f));
                        Console.WriteLine($"{user.Name} vapes, healing 40 HP and dealing {dmg}!");
                        user.HealthPoints += 40;
                        target.HealthPoints -= dmg;
                    },
                }
            },
            {
                "Zigarette",
                new Weapon
                {
                    Name = "Zigarette",
                    wpMulti = 0.8,
                    wpSpc = (user, target) =>
                    {
                        int dmg = (int)(user.AttackPower * 0.8f * (1 - target.DefensePower / 100f));
                        Console.WriteLine(
                            $"{user.Name} smokes a cigarette, healing 75 HP and dealing {dmg}!"
                        );
                        user.HealthPoints += 75;
                        target.HealthPoints -= dmg;
                    },
                }
            },
            {
                "Zigarre",
                new Weapon
                {
                    Name = "Zigarre",
                    wpMulti = 1.0,
                    wpSpc = (user, target) =>
                    {
                        int dmg = (int)(user.AttackPower * 1.0f * (1 - target.DefensePower / 100f));
                        Console.WriteLine(
                            $"{user.Name} smokes a cigar, healing 100 HP and dealing {dmg}!"
                        );
                        user.HealthPoints += 100;
                        target.HealthPoints -= dmg;
                    },
                }
            },
        };
    }
}
