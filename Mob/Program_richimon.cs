using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Console.Write("Enter your Name: ");
            Console.ReadLine();

            

            string selectedWeapon = SelectWeapon(new[] { "M4A1", "AK-74m", "SVD", "MP5A3", "VSS" });

            string selectedArmor = SelectArmor(
                new[]
                {
                    "PACA (20)",
                    "Trooper (30)",
                    "IBA (40)",
                    "Gen4 Assault (45)",
                    "Slick (55 DEF)",
                }
            );

            PMC player = new PMC(name, 0, 0, hp, selectedWeapon, selectedArmor);
            player.changeWeapon(selectedWeapon);
            player.changeArmor(selectedArmor);

            Console.WriteLine();
            Console.WriteLine(
                $"PMC ready: {player.Name} | ATK: {player.AttackPower} | DEF: {player.DefensePower} | HP: {player.HealthPoints} | Weapon: {player.weapon} | Armor: {player.armor} (Durability {player.ArmorDurability}/{player.ArmorMaxDurability})"
            );

            var enemyWeapons = new[] { "M4A1", "AK-74m", "SVD", "MP5A3", "VSS" };
            var enemyArmors = new[] { "PACA", "Trooper", "IBA", "Gen4 Assault", "Slick" };
            var rand = new Random();
            string enemyWeapon = enemyWeapons[rand.Next(enemyWeapons.Length)];
            string enemyArmor = enemyArmors[rand.Next(enemyArmors.Length)];

            PMC enemy = new PMC("Scav", 0, 0, 80, enemyWeapon, enemyArmor);
            enemy.changeWeapon(enemyWeapon);
            enemy.changeArmor(enemyArmor);

            Console.WriteLine();
            Console.WriteLine("Encounter! Choose your action each turn.");

            while (player.HealthPoints > 0 && enemy.HealthPoints > 0)
            {
                Console.WriteLine();
                Console.WriteLine(
                    $"Status -> You: HP {player.HealthPoints}, ATK {player.AttackPower}, DEF {player.DefensePower}, Armor {player.armor} ({player.ArmorDurability}/{player.ArmorMaxDurability}) | Enemy: HP {enemy.HealthPoints}, ATK {enemy.AttackPower}, DEF {enemy.DefensePower}, Armor {enemy.armor} ({enemy.ArmorDurability}/{enemy.ArmorMaxDurability})"
                );
                Console.Write("Choose action: [A]ttack, [F]lee, [H]eal, [G]renade, [C]over: ");
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
                        Console.WriteLine(
                            "Flee attempt failed! The enemy attacks you as you try to escape."
                        );
                        enemy.Attack(player);
                    }
                }
                else if (action == "A")
                {
                    player.Attack(enemy);
                    if (enemy.HealthPoints <= 0)
                    {
                        break;
                    }

                    enemy.Attack(player);
                }
                else if (action == "H")
                {
                    int healAmount = 20;
                    player.Heal(healAmount);
                    Console.WriteLine($"You healed for {healAmount} HP.");
                }
                else if (action == "G")
                {
                    player.ThrowGrenade(enemy);
                    if (enemy.HealthPoints <= 0)
                    {
                        break;
                    }
                    enemy.Attack(player);
                }
                else if (action == "C")
                {
                    player.TakeCover();
                    enemy.Attack(player);
                }
                else
                {
                    Console.WriteLine(
                        "Invalid action. Please choose 'A' to attack or 'F' to flee or 'H' to Heal."
                    );
                }
            }
            Console.ReadLine();
            Console.WriteLine("Encounter ended.");
            Console.ReadLine();
            Console.WriteLine("Press Enter to exit.");
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

    public class PMC
    {
        private static readonly Random rng = new Random();

        // Automatic Properties
        public string Name { get; }
        public int AttackPower { get; private set; }
        public int DefensePower { get; private set; }
        public int HealthPoints { get; set; }
        public string weapon { get; private set; }
        public string armor { get; private set; }
        public int positionX { get; private set; }
        public int positionY { get; private set; }
        public int Grenade = 1;
        public bool inCover { get; private set; }
        public string location { get; private set; }

        // Armor durability
        public int ArmorMaxDurability { get; private set; }
        public int ArmorDurability { get; private set; }

        // Constructor
        public PMC(
            string name,
            int attackPower,
            int defensePower,
            int healthPoints,
            string weapon,
            string armor
        )
        {
            this.Name = name;
            this.HealthPoints = healthPoints;
            this.weapon = weapon;
            this.armor = armor;
            this.AttackPower = CalculateAttackFromWeapon(weapon);
            this.ArmorMaxDurability = GetArmorMaxDurability(armor);
            this.ArmorDurability = this.ArmorMaxDurability;
            this.DefensePower = CalculateDefenseFromArmor(
                armor,
                this.ArmorDurability,
                this.ArmorMaxDurability
            );
            this.positionX = positionX;
            this.positionY = positionY;
            Console.WriteLine($"PMC {this.Name} created: ");
        }

        // Methods

        //******COMBAT METHODS******//

        //******COVER METHOD******//
        public void TakeCover()
        {
            this.inCover = true;
            this.DefensePower += 100;
            Console.WriteLine(
                $"{Name} is taking cover! Defense Power increased to {DefensePower}."
            );
        }

        //******COVER METHOD******//

        //******GRENADE METHOD******//
        public void ThrowGrenade(PMC target)
        {
            if (Grenade <= 0)
            {
                Console.WriteLine($"{Name} has no grenades left to throw.");
                return;
            }
            else
            {
                Grenade--;
                int grenadeDamage = 70;
                target.HealthPoints -= grenadeDamage;
                if (target.HealthPoints < 0)
                    target.HealthPoints = 0;
                Console.WriteLine(
                    $"{Name} threw a grenade at {target.Name}, dealing {grenadeDamage} damage. {target.Name} has {target.HealthPoints} HP left."
                );
            }
        }

        //******GRENADE METHOD******//

        //******MOVEMENT METHOD******//
        public void move(int addX, int addY)
        {
            this.positionX += addX;
            this.positionY += addY;
            Console.WriteLine($"{Name} moved to new position: ({positionX}, {positionY})");
        }

        //******MOVEMENT METHOD******//

        //******Weapon AND Armor CHANGE METHODS******//
        public void changeWeapon(string newWeapon)
        {
            this.weapon = newWeapon;
            this.AttackPower = CalculateAttackFromWeapon(newWeapon);
            Console.WriteLine(
                $"{Name} changed weapon to: {weapon}. New Attack Power: {AttackPower}"
            );
        }

        
        }

        //******COMBAT METHODS******//
        public void Attack(PMC target)
        {
            if (target == null)
            {
                Console.WriteLine($"{this.Name} tried to attack, but the target was invalid.");
                return;
            }

            if (ReferenceEquals(this, target))
            {
                Console.WriteLine($"{this.Name} cannot attack themselves.");
                return;
            }

            if (target.HealthPoints <= 0)
            {
                Console.WriteLine($"{target.Name} is already defeated.");
                return;
            }

            if (RollHeadshot())
            {
                target.HealthPoints = 0;
                Console.WriteLine(
                    $"{this.Name} landed a HEADSHOT on {target.Name} with {this.weapon}! Instant kill."
                );
                return;
            }

            int damage = Math.Max(0, this.AttackPower - target.DefensePower);
            if (damage == 0)
            {
                Console.WriteLine(
                    $"{this.Name} shot at {target.Name}, but the armor absorbed the damage."
                );
                target.DegradeArmor(1);
                return;
            }

            target.HealthPoints -= damage;
            if (target.HealthPoints < 0)
                target.HealthPoints = 0;
            target.DegradeArmor(damage / 2);

            if (target.HealthPoints <= 0)
            {
                Console.WriteLine(
                    $"{this.Name} shot {target.Name} with {this.weapon} dealing {damage} damage. {target.Name} has been killed!"
                );
                return;
            }

            Console.WriteLine(
                $"{this.Name} shot {target.Name} with {this.weapon} dealing {damage} damage. {target.Name} has {target.HealthPoints} HP left."
            );
        }

        //******COMBAT METHODS******//

        //******Healing METHOD******//
        public void Heal(int healAmount)
        {
            this.HealthPoints += healAmount;
            Console.WriteLine(
                $"{this.Name} healed for {healAmount} points. Current HP: {this.HealthPoints}"
            );
        }

        //******Healing METHOD******//

        //******Armor Degrade******//
        private void DegradeArmor(int amount)
        {
            if (this.ArmorDurability <= 0 || amount <= 0)
                return;

            this.ArmorDurability -= amount;
            if (this.ArmorDurability < 0)
                this.ArmorDurability = 0;

            this.DefensePower = CalculateDefenseFromArmor(
                this.armor,
                this.ArmorDurability,
                this.ArmorMaxDurability
            );

            Console.WriteLine(
                $"{this.Name}'s {this.armor} durability decreased by {amount}. Durability: {this.ArmorDurability}/{this.ArmorMaxDurability}. New DEF: {this.DefensePower}"
            );
        }

        //******Armor Degrade******//

        //******RANDOM METHODS FOR ATTACK AND DEFENSE CALCULATION******//
        private bool RollHeadshot()
        {
            return rng.Next(0, 100) < 10;
        }

        public bool fleesuccesschance()
        {
            return rng.Next(0, 100) < 50;
        }

        //******RANDOM METHODS FOR ATTACK AND DEFENSE CALCULATION******//
        private int CalculateAttackFromWeapon(string w)
        {
            switch (w)
            {
                case "M4A1":
                    return 50;
                case "AK-74m":
                    return 45;
                case "SVD":
                    return 65;
                case "MP5A3":
                    return 30;
                case "VSS":
                    return 40;
                default:
                    return 20;
            }
        }
    }
}
