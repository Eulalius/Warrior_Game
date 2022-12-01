using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorGame;
namespace WarriorGame
{   
    public abstract class BaseEnemy : IDescription
    {
        public string Name { get; set; } = "Enemy";
        public string? Description { get; set; } = "Nothing is known about this creature";
        public string? message { get; set; } = "No message";
        public int AtkDmg { get; set; } = 15;
        public int HP { get; set; }
        public int MaxBlock { get; set; }

        public Random rand = new();

        public string GetDescription(IDescription character) { return GetDescription(character); }
        public BaseEnemy(string? name)
        {
            Name = "arne";
            HP = 100;
        }
        public abstract void Attack(Character character, BaseEnemy enemy);
    }
    public class Vampire : BaseEnemy
    {
        
        public Vampire() : base("Vampire")
        {
            HP = 100;
            MaxBlock = 10;
            AtkDmg = 15;
            message = "Give me your blood";
        }

        public override void Attack(Character character, BaseEnemy enemy)
        {
            Damage.DealDamage(character, enemy);
        }
    }

    public class Orc : BaseEnemy
    {
        public Orc() : base("Orc")
        {
            HP = 100;
            MaxBlock = 10;
            message = "I will feast on your skull";
        }

        public override void Attack(Character character, BaseEnemy enemy)
        {
            Damage.DealDamage(character, enemy);
        }
    }
    public class Goblin : BaseEnemy
    {
        public Goblin() : base("Goblin")
        {
            HP = 100;
            MaxBlock = 10;
            message = "I will kill you";
        }

        public override void Attack(Character character, BaseEnemy enemy)
        {
            Damage.DealDamage(character, enemy);

        }

    }

}
