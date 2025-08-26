using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q12
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter the element to search: ");
            int target = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == target)
                {
                    found = true;
                    break;
                }
            }
            if (found)
                Console.WriteLine("1");
            else
                Console.WriteLine("0");
        }
    }
}
