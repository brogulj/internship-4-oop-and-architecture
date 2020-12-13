using internship_4_oop_and_architecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace internship_4_oop_and_architecture.Domain.Services
{
    public static class LifeCheck
    {
        public static void Check(Player player, List<Monster> monsters)
        {
            if (monsters[0].Health <= 0)
            {
                Console.WriteLine("You have killed this monster!");
                monsters.RemoveAt(0);
                Console.WriteLine($"Your next opponent is a {monsters[0].Name}");
            }
            if (player.Health <= 0)
            {
                if (player is Mage mage)
                {
                    if (!mage.WasRevived)
                    {
                        Console.WriteLine("You have been killed but luckily you are a mage and you have revived yourself!");
                        Console.WriteLine("Use this oportunity because you wont get another one");
                        mage.Health = mage.MaxHealth;
                        mage.Mana = mage.MaxMana;
                        mage.WasRevived = true;
                    }
                    else
                    {
                        Console.WriteLine("You have been killed!");
                        Console.WriteLine("This is where your journey ends.");
                    }
                }
                else
                {
                    Console.WriteLine("You have been killed!");
                    Console.WriteLine("This is where your journey ends.");
                }
            }
        }
    }
}
