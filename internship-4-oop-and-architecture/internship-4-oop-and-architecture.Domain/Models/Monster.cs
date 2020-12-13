using System;
using System.Collections.Generic;
using System.Text;

namespace internship_4_oop_and_architecture.Domain.Models
{
    public class Monster 
    {
        public string Name { get; set; }
        public float Health { get; set; }
        public float Damage { get; set; }
        public int GivenExp { get; set; }
        public float MaxHealth { get; set; }
        public virtual void AttackPlayer(Player player, Monster monster, List<Monster> entities)
        {
            Console.WriteLine($"You have been attacked by a {monster.Name} and he has dealt you {monster.Damage} damage!");
            player.Health -= monster.Damage;
        }
    }
}
