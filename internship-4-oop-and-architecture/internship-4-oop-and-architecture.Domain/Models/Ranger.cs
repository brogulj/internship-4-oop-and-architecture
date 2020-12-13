using internship_4_oop_and_architecture.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace internship_4_oop_and_architecture.Domain.Models
{
    public class Ranger: Player
    {
        public Ranger(string name)
        {
            Name = name;
            MaxHealth = 150;
            Health = 150;
            Damage = 33;
        }
        public double StunChance { get; set; } = 0.1;
        public double CriticalChance { get; set; } = 0.1;
        public bool PreviousRoundStun { get; set; } = false;
        public override void AttackMonster(Monster monster, Player player)
        {
            base.AttackMonster(monster, player);
            if (ChanceLottery.Check(CriticalChance))
            {
                Console.WriteLine("You have dealt DOUBLE DAMAGE!!!");
                monster.Health -= player.Damage;
            }
            if (ChanceLottery.Check(StunChance))
            {
                Console.WriteLine("You have stunned the enemy, the next round is certainly yours!");
                PreviousRoundStun = true;
            }
        }
    }
}
