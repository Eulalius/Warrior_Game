using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorGame
{
    public interface IDescription
    {
        protected string? Description { get; set; }
        public string GetDescription(IDescription character);
    }
    public class Damage
    {
         public static void DealDamage(Character character, BaseEnemy enemy)
        {
            int Dmg = enemy.rand.Next(character.MaxBlock + 1, enemy.AtkDmg + 1) - character.rand.Next(2, character.MaxBlock + 1);
            character.HP -= Dmg;
            Console.WriteLine($"{enemy.message} \n {enemy.Name} hits you for {Dmg} damage, you now have {character.HP} HP left.");
        }
    }
}
