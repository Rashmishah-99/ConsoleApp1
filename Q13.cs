using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q13
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] noteCount = new int[notes.Length];

            int remaining = amount;

            for (int i = 0; i < notes.Length; i++)
            {
                if (remaining >= notes[i])
                {
                    noteCount[i] = remaining / notes[i];
                    remaining %= notes[i];
                }
            }

            Console.WriteLine($"\nMinimum notes required for Rs.{amount}:");

            for (int i = 0; i < notes.Length; i++)
            {
                Console.WriteLine($"Notes of Rs.{notes[i]} = {noteCount[i]}");
            }
        }
    }
}