using System;
using System.Collections.Generic;
namespace LogicalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string : ");
            string message = Console.ReadLine();
            //Remove the empty spaces from the message
            message = message.Replace(" ", string.Empty);
            Dictionary<char, int> d = new Dictionary<char, int>();
            foreach (char ch in message)
            {
                if (d.ContainsKey(ch))
                {
                    d[ch] = d[ch] + 1;
                }
                else
                {
                    d.Add(ch, 1);
                }
            }
            foreach (var item in d.Keys)
            {
                Console.WriteLine(item + " : " + d[item]);
            }
            Console.ReadKey();
        }
    }
}