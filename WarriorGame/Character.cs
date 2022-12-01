﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorGame
{
    public abstract class Character : IDescription
    {
        public int HP { get; set; } = 100;
        public string? Name { get; set; } 
        public int AtkDmg { get; set; }
        public int MaxBlock { get; set; }
        public Random rand = new();
        public string Description { get; set; } = "We have no info about this character";

        public string GetDescription(IDescription character) { return GetDescription(character); }
        public Character(string name)
        {
            Name = name;
        }
        public abstract void BasicAttack(BaseEnemy enemy, Character character);
        public abstract void SpecialAttack(BaseEnemy enemy, Character character);
    }
    public class Human : Character
    {
        
        public Human(string name) : base(name)
        {
            AtkDmg = 20;
            HP = 150;
            MaxBlock = 10;
        }
        public override void BasicAttack(BaseEnemy enemy, Character character)
        {
            int Dmg = rand.Next(enemy.MaxBlock + 1, character.AtkDmg + 1) - rand.Next(2, enemy.MaxBlock + 1);
            enemy.HP -= Dmg;
            Console.WriteLine($"You hit the {enemy.Name} for {Dmg}, he now has {enemy.HP}hp left");
        }
        //
        public override void SpecialAttack(BaseEnemy enemy, Character character)
        {
            int Dmg = rand.Next(enemy.MaxBlock + 1, AtkDmg + 1) - rand.Next(2, enemy.MaxBlock + 1);
            enemy.HP -= Dmg;
            Console.WriteLine($"You hit the enemy for {Dmg}, he now has {enemy.HP}hp left");

        }

    }
    public class Dwarf : Character
    {
        public Dwarf(string name) : base(name)
        {
            AtkDmg = 18;
            HP = 170;
            MaxBlock = 12;
        }

        public override void BasicAttack(BaseEnemy enemy, Character character)
        {
            int Dmg = rand.Next(enemy.MaxBlock + 1, character.AtkDmg + 1) - rand.Next(2, enemy.MaxBlock + 1);
            enemy.HP -= Dmg;
            Console.WriteLine($"You hit the enemy for {Dmg}, he now has {enemy.HP}hp left");
        }

        public override void SpecialAttack(BaseEnemy enemy, Character character)
        {
            int Dmg = rand.Next(enemy.MaxBlock + 1, character.AtkDmg + 1) - rand.Next(2, enemy.MaxBlock + 1);
            enemy.HP -= Dmg;
            Console.WriteLine($"You hit the enemy for {Dmg}, he now has {enemy.HP}hp left");
        }
    }
    public class Wizard : Character
    {
        public Wizard(string name) : base(name)
        {
            AtkDmg = 25;
            HP = 110;
            MaxBlock = 7;
        }

        public override void BasicAttack(BaseEnemy enemy, Character character)
        {
            int Dmg = rand.Next(enemy.MaxBlock + 1, character.AtkDmg + 1) - rand.Next(2, enemy.MaxBlock + 1);
            enemy.HP -= Dmg;
            Console.WriteLine($"You hit the enemy for {Dmg}, he now has {enemy.HP}hp left");
        }

        //public override void Defence(IEnemy enemy)


        public override void SpecialAttack(BaseEnemy enemy, Character character)
        {
            int Dmg = rand.Next(enemy.MaxBlock + 1, character.AtkDmg + 1) - rand.Next(2, enemy.MaxBlock + 1);
            enemy.HP -= Dmg;
            Console.WriteLine($"You hit the enemy for {Dmg}, he now has {enemy.HP}hp left");
        }

    } 
}