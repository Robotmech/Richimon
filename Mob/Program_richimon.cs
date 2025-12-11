using Mob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace Program_Richimon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create your Character:");
            Console.Write("Enter your name: ");
            
            int rand = new Random().Next(1, 45);
            CreatePokemon.MakeAllPokemon();
            
            Pokemon player = new Pokemon
            (
                PokeBase.All[rand].Name,
                PokeBase.All[rand].AttackPower,
                PokeBase.All[rand].DefensePower,
                PokeBase.All[rand].HealthPoints,
                PokeBase.All[rand].Condition,
                PokeBase.All[rand].Weapon,
                PokeBase.All[rand].Special
            );


            Console.WriteLine();
            Console.WriteLine($"Player ready: {player.Name} | ATK: {player.AttackPower} | DEF: {player.DefensePower} | HP: {player.HealthPoints} | Weapon: {player.Weapon} | Special: {player.Special})");

          

            while (encounter = true)
            {
                Console.WriteLine();
                Console.WriteLine("Encounterd an aggresive Pokemon! Choose your action each turn.");

                while (player.HealthPoints > 0 && enemy.HealthPoints > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Status -> You: HP {player.HealthPoints}, ATK {player.AttackPower}, DEF {player.DefensePower}, Armor {player.armor} ({player.ArmorDurability}/{player.ArmorMaxDurability}) | Enemy: HP {enemy.HealthPoints}, ATK {enemy.AttackPower}, DEF {enemy.DefensePower}, Armor {enemy.armor} ({enemy.ArmorDurability}/{enemy.ArmorMaxDurability})");
                    Console.Write("Choose action: [A]ttack, [F]lee, [S]pecial, [R]esist: ");
                    var action = Console.ReadLine()?.Trim().ToUpperInvariant();

                    if (action == "F")
                    {
                        if (player.fleesuccesschance())
                        {
                            Console.WriteLine("You successfully fled the encounter!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Flee attempt failed! The enemy attacks you as you try to escape.");
                            enemy.Turn(player);
                        }
                    }

                    else if (action == "A")
                    {
                        player.PokeAttack(enemy);
                        if (enemy.HealthPoints <= 0)
                        {
                            break;
                        }

                        enemy.Turn(player);
                    }
                   
                    else if (action == "S")
                    {
                        player.PokeSpecial(enemy);
                        if (enemy.HealthPoints <= 0)
                        {
                            break;
                        }
                        enemy.Turn(player);
                    }
                    else if (action == "R")
                    {
                        player.Resist();
                        enemy.Turn(player);
                    }
                    else
                    {
                        Console.WriteLine("Invalid action. Please choose a Valid Action by pressing the corresponding Letter on your Keyboard.");
                    }
                }
                Console.ReadLine();
                Console.WriteLine("Encounter ended.");
                Console.ReadLine();
                Console.WriteLine("Press Enter to exit.");
            }
        }
            

        private static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int value) && value >= 0)
                {
                    return value;
                }
                Console.WriteLine("Please enter a valid non-negative integer.");
            }
        }

        private static string SelectWeapon(string[] weapons)
        {
            Console.WriteLine("Select a weapon:");
            for (int i = 0; i < weapons.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {weapons[i]}");
            }

            while (true)
            {
                Console.Write("Enter choice number: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    int index = choice - 1;
                    if (index >= 0 && index < weapons.Length)
                    {
                        Console.WriteLine($"Selected weapon: {weapons[index]}");
                        return weapons[index];
                    }
                }
                Console.WriteLine("Invalid selection. Try again.");
            }
        }

        private static string SelectArmor(string[] armors)
        {
            Console.WriteLine("Select armor:");
            for (int i = 0; i < armors.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {armors[i]}");
            }

            while (true)
            {
                Console.Write("Enter choice number: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    int index = choice - 1;
                    if (index >= 0 && index < armors.Length)
                    {
                        Console.WriteLine($"Selected armor: {armors[index]}");
                        return armors[index];
                    }
                }
                Console.WriteLine("Invalid selection. Try again.");
            }
        }
    }

