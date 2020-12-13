using internship_4_oop_and_architecture.Data;
using internship_4_oop_and_architecture.Domain.Models;
using internship_4_oop_and_architecture.Domain.Services;
using System;
using System.Collections.Generic;

namespace internship_4_oop_and_architecture.Presentation
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var data = new DataStore();
            while (LifeCheck.Check(data.Player, data.MonsterList))
            {
                Console.Clear();
                ShowEntityState.Show(data.Player);
                Console.WriteLine("");
                ShowEntityState.Show(data.MonsterList[0]);
                AttackPrompt.NewTurn(data.Player,data.MonsterList);
                Console.WriteLine("");
                LifeCheck.Check(data.Player, data.MonsterList);
                Console.WriteLine("");
                LevelCheck.Check(data.Player); 
                Console.WriteLine("Press any key for next turn");
                Console.ReadLine();
                ShowEntityState.Show(data.Player); 
                Console.WriteLine("");
                ShowEntityState.Show(data.MonsterList[0]);


            }
        }
    }
}
