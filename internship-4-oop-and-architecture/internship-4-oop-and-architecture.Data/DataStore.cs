using System;
using System.Collections.Generic;
using System.Text;
using internship_4_oop_and_architecture.Domain.Models;
using internship_4_oop_and_architecture.Domain.Services;

namespace internship_4_oop_and_architecture.Data
{
    public class DataStore
    {
        public List<Monster> MonsterList { get; set; } = new List<Monster>();

        public DataStore()
        {

            for (var i = 0; i < 10; i++)
            {
                MonsterList.Add(GenerateMonster.NewMonster(MonsterList));
            }

            Console.WriteLine("Enter the name of your player: ");
            var playerName = GetInput.GetString();

            Console.WriteLine("Enter the class of your player\n1 - Warrior\n2 - Ranger\n3 - Mage");
            var hasChosen = false;
            while (!hasChosen)
            {

                var UserChoice = GetInput.GetInt();
                if (UserChoice == 1 || UserChoice == 2 || UserChoice == 3)
                {
                    hasChosen = true;
                    switch (UserChoice)
                    {
                        case 1:
                            Player = new Warrior(playerName);
                            break;
                        case 2:
                            Player = new Ranger(playerName);
                            break;
                        case 3:
                            Player = new Mage(playerName);
                            break;
                        default:
                            Console.WriteLine("Wrong input, please enter new number");
                            UserChoice = GetInput.GetInt();
                            break;
                    }
                }
            }
        }
        public Player Player { get; set; }
    }
}
