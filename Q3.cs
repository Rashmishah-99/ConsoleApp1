using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Doe";
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.Write("Please enter a new first name:");
            firstName = Console.ReadLine();
            Console.Write("Please enter a new last name:");
            lastName = Console.ReadLine();
            Console.WriteLine("New name: " + firstName + " " + lastName);
            Console.ReadLine();

        }
    }
}
