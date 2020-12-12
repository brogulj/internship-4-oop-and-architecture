using System;
using System.Collections.Generic;
using System.Text;

namespace internship_4_oop_and_architecture.Domain.Services
{
    public static class RandomNumber
    {
        public static int Int(int low, int high)
        {
            var random = new Random();
            return random.Next(low, high);
        }
        public static double Double()
        {
            var random = new Random();
            return random.NextDouble();
        }
    }
}
