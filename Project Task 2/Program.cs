using System;
using System.Text.RegularExpressions;

namespace Project_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Console.WriteLine(Func(input));
            Console.ReadLine();
        }
        public static int Func(string input)
        {
            var match = Regex.Match(input.Trim(), pattern: @"^(?<Whole>\d+)([.|,]\d*)?$");
            if (!match.Success)
                return 0;

            var number = int.Parse(match.Groups["Whole"].Value);

            if(number <= 0)
                return 0;
            if (number >= 100) 
                return 100;

            return (int)Math.Round((double)number / 5) * 5;

        }
    }
}
