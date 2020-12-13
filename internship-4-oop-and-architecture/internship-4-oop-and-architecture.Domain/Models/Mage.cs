using System;
using System.Collections.Generic;
using System.Text;

namespace internship_4_oop_and_architecture.Domain.Models
{
    public class Mage : Player
    {
        public Mage(string name)
        {
            Name = name;
            MaxHealth = 100;
            Health = 100;
            Damage = 50;
        }
        public int MaxMana { get; set; } = 100;
        public int Mana { get; set; } = 100;
        public bool WasRevived { get; set; } = false;
        public override void AttackMonster(Monster monster, Player player)
        {
            if (Mana > 0) {
            base.AttackMonster(monster, player);
            Mana -= 20;
            }
            else
            {
                Mana = MaxMana;
                Console.WriteLine($"{player.Name} is resting, he can't attack right now.");
            }
            
        }
    }
}
