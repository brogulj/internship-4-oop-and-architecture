using System;
using System.Collections.Generic;
using System.Text;

namespace internship_4_oop_and_architecture.Domain.Services
{
    public static class ChanceLottery
    {
        public static bool Check(double chance)
        {
            var rnd = new Random();
            var broj = rnd.NextDouble();
            if (broj <= chance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
