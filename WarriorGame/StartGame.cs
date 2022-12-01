using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorGame;
namespace WarriorGame
{
    internal class StartGame
    {
        public void Start()
        {
            try
            {
                Character character = ChooseCharacter();
                while (character.HP > 0)
                {
                    BaseEnemy enemy = GetEnemy();
                    Fight(character, enemy);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static Character ChooseCharacter()
        {
            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine().Trim();//Måste fixa null på något sätt här
            
            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("\nEveryone has a name.");
                return ChooseCharacter();
            }
            Console.WriteLine($"\nWelcome {name} \n\nWhat class do you choose? [1] [2] [3]");
            char c = Convert.ToChar(Console.ReadLine());
            switch (c)
            {
                case '1': return new Human(name);
                case '2': return new Wizard(name);
                case '3': return new Dwarf(name);
                default:
                    Console.WriteLine("\nInvalid class, choose again");
                    return ChooseCharacter();
            }
        }



        static BaseEnemy GetEnemy()
        {
            Console.WriteLine("\nWho do you want to fight? Vampire [V] Goblin [G] Orc [O]");
            char e = Convert.ToChar(Console.ReadLine());
            switch (e)
            {
                case 'v': return new Vampire();
                case 'g': return new Goblin();
                case 'o': return new Orc();
                default:
                    Console.WriteLine("\nInvalid enemy, choose again");
                    return GetEnemy();
            }
        }



        static void Fight(Character character, BaseEnemy enemy)
        {
            while (enemy.HP > 0 && character.HP > 0)
            {
                if (character.HP > 0)
                {
                    Console.WriteLine("\nChoose your attack: Basic [B] or Special [S]");
                    char k = Convert.ToChar(Console.ReadLine());
                    switch (k)
                    {
                        case 'b': character.BasicAttack(enemy, character); break;
                        case 's': character.SpecialAttack(enemy, character); break;
                        default:
                            Console.WriteLine("\nInvalid attack");
                            Fight(character, enemy);
                            break;
                    }
                }
                if (enemy.HP > 0)
                {
                    enemy.Attack(character, enemy);
                }   
            }
            if (character.HP <= 0 )
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("\nGAME OVER");
                Console.ReadKey();
                Environment.Exit(0);
            }
            
        }

    }
}
