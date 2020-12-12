using internship_4_oop_and_architecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace internship_4_oop_and_architecture.Domain.Services
{
    public static class LevelCheck
    {
        public static void Check(Player player)
        {
            var baseLevel = player.Level;
            if (player is Warrior warrior)
            {
                if (warrior.Experience > 50)
                {
                    warrior.Level += warrior.Experience / 50;
                    var leftoverExperience = warrior.Experience % 50;
                    if (warrior.Level > baseLevel)
                    {
                        warrior.MaxHealth += (warrior.Level - baseLevel) * 7;
                        warrior.Health = warrior.MaxHealth;
                        warrior.Damage += (warrior.Level - baseLevel) * 10;
                        warrior.Experience = leftoverExperience;
                    }
                }
            }
            else if (player is Mage mage)
            {
                if (mage.Experience > 50)
                {
                    mage.Level += mage.Experience / 50;
                    var leftoverExperience = mage.Experience % 50;
                    if (mage.Level > baseLevel)
                    {
                        mage.MaxHealth += (mage.Level - baseLevel) * 9;
                        mage.Health = mage.MaxHealth;
                        mage.Damage += (mage.Level - baseLevel) * 7;
                        mage.Experience = leftoverExperience;
                        mage.MaxMana += (mage.Level - baseLevel) * 10;
                        mage.Mana = mage.MaxMana;
                    }
                }
            }
            else if (player is Ranger ranger)
            {

                if (ranger.Experience > 50)
                {
                    ranger.Level += ranger.Experience / 50;
                    var leftoverExperience = ranger.Experience % 50;
                    if (ranger.Level > baseLevel)
                    {
                        ranger.MaxHealth += (ranger.Level - baseLevel) * 8;
                        ranger.Health = ranger.MaxHealth;
                        ranger.Damage += (ranger.Level - baseLevel) * 8;
                        ranger.Experience = leftoverExperience;
                        ranger.CriticalChance += 0.3;
                        ranger.StunChance += 0.3;
                    }
                }
            }
        }
    }
}
