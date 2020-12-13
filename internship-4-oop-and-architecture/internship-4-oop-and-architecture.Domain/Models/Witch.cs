using internship_4_oop_and_architecture.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace internship_4_oop_and_architecture.Domain.Models
{
    public class Witch:Monster
    {
        public Witch(List<Monster> monsters)
        {
            Name = "Witch";
            Health = 150;
            Damage = 50;
            GivenExp = 100;
            MaxHealth = Health;
            monsters.Add(GenerateMonster.NewMonster(monsters));
            monsters.Add(GenerateMonster.NewMonster(monsters));

        }
        public override void AttackPlayer(Player player, Monster monster, List<Monster> entities)
        {
            if (ChanceLottery.Check(0.2))
            {
                foreach(var entity in entities)
                {
                    entity.Health = RandomNumber.Int(0, (int)MaxHealth);
                }
                player.Health = RandomNumber.Int(0, (int)MaxHealth);
                Console.WriteLine("Witch has used an attack called đumbus and has set everyones health to a random number");
                Console.WriteLine($"Your current health is {player.Health}");
            }else
                base.AttackPlayer(player, monster, entities);
        }
    }
}
