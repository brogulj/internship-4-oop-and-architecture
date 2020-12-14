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
            var randomInt = RandomNumber.Int(1, 11);
            
            if (randomInt <= 5)
            {
                return new Goblin();
            }
            else if (randomInt <= 8)
            {
                return new Brute();
            }
            else
                return new Witch(monsters);
        
        }
    }
}
