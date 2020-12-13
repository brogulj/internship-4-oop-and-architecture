using internship_4_oop_and_architecture.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace internship_4_oop_and_architecture.Domain.Models
{
    public class Brute : Monster
    {
        public Brute()
        {
            Health = 100;
            Damage = 20;
            Name = "Brute";
            GivenExp = 40;
            MaxHealth = Health;

        }
        public override void AttackPlayer(Player player, Monster monster, List<Monster> entities)
        {
            if (ChanceLottery.Check(0.2))
            {
                Console.WriteLine("Brute used a special attack and he took away 25% of your health!!!");
                player.Health *= (float)0.75;
            }else
                base.AttackPlayer(player, monster, entities);
        }
    }
}
