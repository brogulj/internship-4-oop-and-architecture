using internship_4_oop_and_architecture.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace internship_4_oop_and_architecture.Domain.Models
{
    public class Goblin : Monster
    {
        public Goblin()
        {
            Health = RandomNumber.Int(30,60);
            Damage = RandomNumber.Int(10, 20);
            GivenExp = 20;
        }
    }
}
