using internship_4_oop_and_architecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace internship_4_oop_and_architecture.Domain.Services
{
    public static class GenerateMonster
    {
        public static Monster NewMonster(List<Monster> monsters)
        {
            var randomInt = RandomNumber.Int(1, 10);
            
            if (randomInt <= 6)
            {
                return new Goblin();
            }
            else if (randomInt <= 9)
            {
                return new Brute();
            }
            else
                return new Witch(monsters);
        
        }
    }
}
