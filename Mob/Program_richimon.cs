using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;
using Microsoft.Win32;
using Mob;

namespace Program_Richimon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create your Character:");
            Console.Write("Enter your name: ");

            bool Encounter = false;
            bool TerryDavis = false;
            bool PokeEncounter = false;
            bool fountain = false;
            bool OFC = true; //OFC = Out of Combat
            bool uInputCheck = true;
            int uInput;
            int lives = 3;

            CreatePokemon.MakeAllPokemon();
            int rand = new Random().Next(1, 45);
            int playerPokemon = rand;
            Pokemon player = new Pokemon(
                PokeBase.All[playerPokemon].Name,
                PokeBase.All[playerPokemon].AttackPower,
                PokeBase.All[playerPokemon].DefensePower,
                PokeBase.All[playerPokemon].HealthPoints,
                PokeBase.All[playerPokemon].Condition,
                PokeBase.All[playerPokemon].Weapon,
                PokeBase.All[playerPokemon].Special
            );

            Console.WriteLine();
            Console.WriteLine(
                $"Player ready: {player.Name} | ATK: {player.AttackPower} | DEF: {player.DefensePower} | HP: {player.HealthPoints} | Weapon: {player.Weapon} | Special: {player.Special})"
            );
            Console.ReadKey();

            while (OFC)
            {
                rand = new Random().Next(1, 101);

                Console.WriteLine(
                    "You encounter a crossway with three paths, Choose one of three: \n [1]Left | [2]Straight | [3]Right"
                );
                while (!int.TryParse(Console.ReadLine(), out uInput))
                {
                    Console.WriteLine("Invalid choice, try again:");
                }
                Console.WriteLine("Your choice is " + uInput);
                if (rand <= 5)
                {
                    TerryDavis = true;
                }
                else if (rand > 5 && rand <= 20)
                {
                    fountain = true;
                }
                else if (rand > 20 && rand <= 50)
                {
                    PokeEncounter = true;
                }
                else if (rand > 50)
                {
                    Encounter = true;
                }
            }

            while (Encounter) // Placeholder for encounter loop
            {
                Console.ReadKey();
                rand = new Random().Next(1, 45);
                int enemyPokemon = rand;
                Pokemon enemy = new Pokemon(
                    PokeBase.All[enemyPokemon].Name,
                    PokeBase.All[enemyPokemon].AttackPower,
                    PokeBase.All[enemyPokemon].DefensePower,
                    PokeBase.All[enemyPokemon].HealthPoints,
                    PokeBase.All[enemyPokemon].Condition,
                    PokeBase.All[enemyPokemon].Weapon,
                    PokeBase.All[enemyPokemon].Special
                );

                Console.WriteLine(
                    "Encountered an aggresive Pokemon! Choose your action each turn."
                );

                while (player.HealthPoints > 0 && enemy.HealthPoints > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(
                        $"Status -> You: HP {player.HealthPoints}, ATK {player.AttackPower}, DEF {player.DefensePower} \n Enemy: HP {enemy.HealthPoints}, ATK {enemy.AttackPower}, DEF {enemy.DefensePower})"
                    );
                    Console.Write("Choose action: [A]ttack, [F]lee, [S]pecial, [R]esist: ");
                    var action = Console.ReadLine()?.Trim().ToUpperInvariant();
                    player.SpecialCharge++;
                    if (action == "F")
                    {
                        rand = new Random().Next(1, 11);
                        if (rand >= 7)
                        {
                            Console.WriteLine("You successfully fled the encounter!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine(
                                "Flee attempt failed! The enemy attacks you as you try to escape."
                            );
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
                        int ChargeNeeded = AbilityDatabase.Specials[player.Special].ChargeNeeded;
                        if (player.SpecialCharge >= ChargeNeeded)
                        {
                            player.PokeSpecial(enemy);
                            if (enemy.HealthPoints <= 0)
                            {
                                break;
                            }
                            enemy.Turn(player);
                        }
                        else
                        {
                            Console.WriteLine(
                                $"Not enough charge for special! Needed: {ChargeNeeded}, Current: {player.SpecialCharge}"
                            );
                        }
                    }
                    else if (action == "R")
                    {
                        player.Resist();
                        enemy.Turn(player);
                    }
                    else
                    {
                        Console.WriteLine(
                            "Invalid action. Please choose a Valid Action by pressing the corresponding Letter on your Keyboard."
                        );
                    }
                }
                if (player.HealthPoints >= 0)
                {
                    lives--;
                    if (lives == 0)
                    {
                        Console.Write("No more Lives!! You and your Pokemon are DEFEATED.");
                        break;
                    }
                    Console.WriteLine(
                        $"You lost the fight aswell as one life, remaining lifes : {lives}!!"
                    );
                }
                else if (enemy.HealthPoints >= 0)
                {
                    Console.WriteLine($"You survived the Encounter!");
                }
                player.HealthPoints = PokeBase.All[playerPokemon].HealthPoints;
                player.Condition = "None";
                player.ConditionTime = 0;
                player.SpecialCharge = 0;
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
    }
}
