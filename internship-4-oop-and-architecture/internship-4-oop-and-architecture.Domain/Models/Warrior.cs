using System;
using System.Collections.Generic;
using System.Text;

namespace internship_4_oop_and_architecture.Domain.Models
{
    public class Warrior : Player
    {
        public Warrior(string name)
        {
            Name = name;
            MaxHealth = 200;
            Health = 200;
            Damage = 25;
        }
        public override void AttackMonster(Monster monster, Player player)
        {
            base.AttackMonster(monster, player);
            Console.WriteLine("Do you wanna rage attack for the cost of 15% of your health?");
            Console.WriteLine("Type yes for yes and or no for no:");
            var UserChoice = Console.ReadLine().ToLower();
            if (UserChoice == "yes")
            {
                monster.Health -= player.Damage;
                player.Health *= (float)0.85;
                Console.WriteLine("You did DOUBLE DAMAGE!!!");
            }
        }
    }
}
