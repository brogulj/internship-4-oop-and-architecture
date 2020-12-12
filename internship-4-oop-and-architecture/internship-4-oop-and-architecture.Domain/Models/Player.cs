using System;
using System.Collections.Generic;
using System.Text;

namespace internship_4_oop_and_architecture.Domain.Models
{
    public class Player
    {
        public string Name { get; set; }
        public float MaxHealth { get; set; }
        public float Health { get; set; }
        public int Experience { get; set; } = 0;
        public int Level { get; set; } = 1;
        public float Damage { get; set; } = 0;
        public virtual void AttackMonster(Monster monster, Player player)
        {
            monster.Health -= player.Damage;
            Console.WriteLine($"{player.Name} has dealt {player.Damage} damage to this {monster.Name}");

        }
        public virtual void GetAttacked(Monster monster, Player player)
        {
            player.Health -= monster.Damage;
            Console.WriteLine($"{monster.Name} has dealt {monster.Damage} damage to you");
        }
    }
}
