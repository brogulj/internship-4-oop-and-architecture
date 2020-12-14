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
            if (monster is Goblin)
            {
                Console.WriteLine(@"             ,      ,");
                Console.WriteLine("            /(.-\"\"-.)\\");
                Console.WriteLine(@"        |\  \/      \/  /|");
                Console.WriteLine(@"        | \ / =.  .= \ / |");
                Console.WriteLine(@"        \( \   o\/o   / )/");
                Console.WriteLine(@"         \_, '-/  \-' ,_/");
                Console.WriteLine(@"           /   \__/   \");
                Console.WriteLine(@"           \ \__/\__/ /");
                Console.WriteLine(@"         ___\ \|--|/ /___");
                Console.WriteLine(@"       /`    \      /    `\");
                Console.WriteLine(@"      /       '----'       \");
            }
            else if (monster is Witch)
            {
                Console.WriteLine(@" (       "")");
                Console.WriteLine(@"  ( _  *");
                Console.WriteLine(@"     * (     /      \    ___                ");
                Console.WriteLine(@"        ""     ""        _/ /                 ");
                Console.WriteLine(@"       (   *  )    ___/   |                 ");
                Console.WriteLine(@"         )   ""     _ o)'-./__               ");
                Console.WriteLine(@"        *  _ )    (_, . $$$                 ");
                Console.WriteLine(@"        (  )   __ __ 7_ $$$$                ");
                Console.WriteLine(@"         ( :  { _)  '---  $\                ");
                Console.WriteLine(@"    ______'___//__\   ____, \               ");
                Console.WriteLine(@"     )           ( \_/ _____\_              ");
                Console.WriteLine(@"   .'             \   \------''.            ");
                Console.WriteLine(@"   |='           '=|  |         )           ");
                Console.WriteLine(@"   |               |  |  .    _/            ");
                Console.WriteLine(@"    \    (. ) ,   /  /__I_____\             ");
                Console.WriteLine(@"     '._/_)_(\__.'   (__,(__,_]             ");
                Console.WriteLine(@"    @---()_.'---@  ");
            }
            else
            {
                Console.WriteLine(@"                  (\    /)");
                Console.WriteLine(@"                  |_)//(_|");
                Console.WriteLine(@"                  |4\_/4)(");
                Console.WriteLine(@"                 '( (_  -)D");
                Console.WriteLine(@"                   ) _)  /\,__");
                Console.WriteLine(@"                 _,\_._,/ /   `)");
                Console.WriteLine(@"    \.,_,,      ( _   ~ .   ,   \");
                Console.WriteLine(@"     \   (\      \(   \/  _)(    )");
                Console.WriteLine(@"      \   \\      )). _______>-. `*");
                Console.WriteLine(@"       \  /\\    _'( /   /\  '\  _)");
                Console.WriteLine(@"        \( ,\\.-'  '/    \/    \/");
                Console.WriteLine(@"         '  \><)_'.)|/\/\/\/\/\|");
                Console.WriteLine(@"              \) ,( |\/\/\/\/\/|");
                Console.WriteLine(@"              ' ((  \    /\    /");
                Console.WriteLine(@"               ((((  \___\/___/)");
                Console.WriteLine(@"                ((,) /   ((()   )");
                Console.WriteLine(@"                 ""..-, (()(""   /");
                Console.WriteLine(@"                  _//.   ((() .");
                Console.WriteLine(@"                            / /");
                Console.WriteLine(@"                          _/,/'");
                Console.WriteLine(@"                        /,/,""");
            }
            Console.ResetColor();
        }

        public static void Show(Player player)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{ player.Name} state:");
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
