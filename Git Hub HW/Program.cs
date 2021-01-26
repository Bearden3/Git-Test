using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Hub_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hellow World!");
            Console.WriteLine("I am thinking of a number betwen 0 - 100");
            Random rnd = new Random();
            int num = rnd.Next(1, 101);
            int i = 1;
            Console.WriteLine("What is your guess?");
            int choice = Convert.ToInt32(Console.ReadLine());
            while (choice != num)
            {
                if (choice < num)
                {
                    Console.WriteLine("Ooh too bad your number was too low, try again.");
                }
                if (choice > num)
                {
                    Console.WriteLine("oof too bad your number was too high, try again");
                }
                i++;
                choice = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Correct the number was: " + num);
            Console.WriteLine("That took you " + i + " guesses");
            Console.ReadKey();
        }
    }
}
