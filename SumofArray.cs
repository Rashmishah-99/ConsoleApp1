using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SumofArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements (N): ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            int sum = 0;

            Console.WriteLine("Enter {0} elements:", n);
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }

            Console.WriteLine("Sum of array elements: " + sum);
        }
    }
}
