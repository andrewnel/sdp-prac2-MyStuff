using System;
using System.Collections.Generic;

namespace Problems
{
    public class Program
    {
        public static string Prefix(string input)
        {
            if(input == null)
                return null;
            else
            {
                string[] split = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                return($"{input.Length}, {split.Length}:{input}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Prefix("hello"));
            Console.WriteLine(Prefix(""));
            Console.WriteLine(Prefix("what    ...  did you say?? "));
        }
    }
}
