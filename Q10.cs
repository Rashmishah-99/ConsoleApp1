using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q10
    {
        static int MatSearch(int[,] mat, int N, int M, int X)
        {
            int i = 0, j = M - 1;

            while (i < N && j >= 0)
            {
                if (mat[i, j] == X)
                    return 1;
                else if (mat[i, j] > X)
                    j--;
                else
                    i++;
            }
            return 0;
        }

       static void Main(string[] args)
        {
            int[,] mat1 = {
            { 3, 30, 38 },
            { 44, 52, 54 },
            { 57, 60, 69 }
        };
            Console.WriteLine(MatSearch(mat1, 3, 3, 62)); 

            int[,] mat2 = {
            { 18, 21, 27, 38, 55, 67 }
        };
            Console.WriteLine(MatSearch(mat2, 1, 6, 55)); 
        }
    }

}