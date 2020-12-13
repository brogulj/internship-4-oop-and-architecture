using internship_4_oop_and_architecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace internship_4_oop_and_architecture.Domain.Services
{
    public static class ShowEntityState
    {
        public static void Show(Monster monster)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{monster.Name} state:");
            Console.WriteLine($"Health = {monster.Health}");
            Console.WriteLine($"Damage = {monster.Damage}");
            Console.WriteLine($"Experience given when dead = {monster.GivenExp}");
            Console.ResetColor();
        }

        public static void Show(Player player)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{player.Name} state:");
            Console.WriteLine($"Health = {player.Health}");
            Console.WriteLine($"Damage = {player.Damage}");
            Console.WriteLine($"Level = {player.Level}");
            if(player is Mage mage)
            {
                Console.WriteLine($"Mana = {mage.Mana}");
            }else if (player is Ranger ranger)
            {
                Console.WriteLine($"Critical hit chance = {ranger.CriticalChance}");
                Console.WriteLine($"Stun chance = {ranger.StunChance}");
            }
            Console.ResetColor();
        }
    }
}
