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
            Name = "Goblin";
            Health = 70;
            Damage = 15;
            GivenExp = 20;
            MaxHealth = Health;
        }
    }
}
