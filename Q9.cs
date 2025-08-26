using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q9
    {
        static void FindTwoUniqueNumbers(int[] arr)
        {
            int xorAll = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                xorAll ^= arr[i];
            }
            int rightmostSetBit = xorAll & -xorAll;
            int num1 = 0, num2 = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] & rightmostSetBit) != 0)
                {
                    num1 ^= arr[i];
                }
                else
                {
                    num2 ^= arr[i];
                }
            }
            if (num1 < num2)
                Console.WriteLine(num1 + " " + num2);
            else
                Console.WriteLine(num2 + " " + num1);
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 2, 1, 4 };
            Console.Write("Output for arr1: ");
            FindTwoUniqueNumbers(arr1);

            int[] arr2 = { 2, 1, 3, 2 };
            Console.Write("Output for arr2: ");
            FindTwoUniqueNumbers(arr2);
        }
    }
}