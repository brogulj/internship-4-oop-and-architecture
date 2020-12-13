using System;
using System.Collections.Generic;
using System.Text;

namespace internship_4_oop_and_architecture.Domain.Services
{
    public static class GetInput
    {

        public static string GetString()
        {
            string str = "";
            while (str == "")
            {

                str = Console.ReadLine();
                if (str != "")
                {
                    return str;
                }
                else
                {
                    Console.WriteLine("There has been an error with your input\nPlease enter the required text again");
                }
            }
            return str;
        }

        public static int GetInt()
        {
            int integer;
            if (int.TryParse(Console.ReadLine(), out integer))
            {
                return integer;
            }
            while (true)
            {
                Console.WriteLine("There has been an error with your input.\nPlease enter the required number again");
                if (int.TryParse(Console.ReadLine(), out integer))
                {
                    return integer;
                }
            }
        }
    }
}
