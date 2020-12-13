using internship_4_oop_and_architecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace internship_4_oop_and_architecture.Domain.Services
{
    public static class AttackPrompt
    {
        public static void NewTurn(Player player, List<Monster> monsters)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var monster = monsters[0];
            if (player is Ranger ranger)
            {
                if (ranger.PreviousRoundStun)
                {
                    Console.WriteLine("You win a round automatically!");
                    ranger.AttackMonster(monster, ranger);
                    ranger.PreviousRoundStun = false;
                }
            }
            Console.WriteLine("New turn");
            Console.WriteLine("Do you want to attack directly, from the side or counter attack?");
            Console.WriteLine("Type 1 for Direct");
            Console.WriteLine("Type 2 for Side");
            Console.WriteLine("Type 3 for Counter");
            var UserChoice = Console.ReadLine();
            var HasChosen = false;
            while (!HasChosen)
            {

                var randomInt = RandomNumber.Int(1, 3);
                if (UserChoice == "1" || UserChoice == "2" || UserChoice == "3") {
                    if (randomInt == 1)
                    {
                        Console.WriteLine($"Your attack has passed through {monster.Name} defenses!");
                        player.AttackMonster(monster, player);
                    }
                    else if (randomInt == 2)
                    {
                        Console.WriteLine("Your attack has been blocked");
                    }
                    else
                    {
                        Console.WriteLine("Monster has parried your attack!");
                        monster.AttackPlayer(player, monster, monsters);
                    }
                        HasChosen = true;
                    }
                else
                {
                    Console.WriteLine("Wrong input, please enter correct input");
                    UserChoice = Console.ReadLine();
                }
            }
            Console.ResetColor();
        }
    }
}
