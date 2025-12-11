using Mob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mob
{
    internal class WeaponDatabase
    {
        private readonly Dictionary<string, Weapon> Weapons = new Dictionary<string, Weapon>
        {
            
            {
                "Wasserpistole",
                new Weapon
                {
                    Name = "Wasserpistole",
                    wpMulti = 0,
                    wpSpc = (user, target) =>
                {
                    if (rng.Next(1, 51) == 1)
                    {
                        Console.WriteLine($"The Waterpistol hits clean into the brain of {target.Name}, killing them instantly!")
                        target.HealthPoints = 0;
                    }
                    else
                    {
                        Console.WriteLine($"The Water of the pistol splashes onto the enemy, dealing 0 damage!");
                    }

                }
                }
                
            }
            "FIH",
            new Weapon
            {
                Name = "FIH",
                wpMulti = 0,
                wpSpc = (user, target) =>
                {
                    if (rng.Next(1, 51) == 1)
                    {
                        Console.WriteLine($"The Waterpistol hits clean into the brain of {target.Name}, killing them instantly!")
                        target.HealthPoints = 0;
                    }
                    else
                    {
                        Console.WriteLine($"The Water of the pistol splashes onto the enemy, dealing 0 damage!");
                    }

                }
            }
        };
    }
}

namespace Pokemon_weapons
{
    internal class Weapons
    {
        private Random rng = new Random();

        public void Weapon(string weapon, Pokemon target)
        {
            switch (weapon)
            {
                case "Wasserpistole":
                    if (rng.Next(1, 51) == 1)
                        target.Health = 0;
                    break;

                case "FIH":
                    if (rng.Next(1, 26) == 1)
                        target.Health = 0;
                    break;

                case "Lil Richie":
                    if (rng.Next(1, 3) == 1)
                        target.Health = 0;
                    else
                        Health = 0;
                    break;
                case "Messer":

                    break;
                case "Machete":

                    break;

                case "Zweihänder":
                    break;

                case "Glock":
                    break;

                case "MP5":
                    break;

                case "AK-47":
                    break;

                case "Granate":
                    if (
                    break;

                case "Rocketlauncher":
                    break;

                case "Nukelauncher":
                    break;

                case "Vape":
                    break;

                case "Zigarette":
                    break;

                case "Zigarre":
                    break;

                default:
                    Console.WriteLine("du huso was hesch du kei waffe");
                    break;
            }
        }
    }
}