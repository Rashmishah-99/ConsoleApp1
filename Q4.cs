using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter integer B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            // Arithmetic Operators
            Console.WriteLine("\n--- Arithmetic Operations ---");
            Console.WriteLine($"A + B = {A + B}");
            Console.WriteLine($"A - B = {A - B}");
            Console.WriteLine($"A * B = {A * B}");
            Console.WriteLine($"A / B = {(B != 0 ? (A / B).ToString() : "undefined")}");
            Console.WriteLine($"A % B = {(B != 0 ? (A % B).ToString() : "undefined")}");

            // Relational Operators
            Console.WriteLine("\n--- Relational Operations ---");
            Console.WriteLine($"A == B: {A == B}");
            Console.WriteLine($"A != B: {A != B}");
            Console.WriteLine($"A > B: {A > B}");
            Console.WriteLine($"A < B: {A < B}");
            Console.WriteLine($"A >= B: {A >= B}");
            Console.WriteLine($"A <= B: {A <= B}");

            // Logical Operators
            Console.WriteLine("\n--- Logical Operations ---");
            bool boolA = A > 0;
            bool boolB = B > 0;
            Console.WriteLine($"boolA && boolB: {boolA && boolB}");
            Console.WriteLine($"boolA || boolB: {boolA || boolB}");
            Console.WriteLine($"!boolA: {!boolA}");

            // Assignment Operators
            Console.WriteLine("\n--- Assignment Operations ---");
            int C = A;
            Console.WriteLine($"C = A: {C}");
            C += B;
            Console.WriteLine($"C += B: {C}");
            C -= B;
            Console.WriteLine($"C -= B: {C}");
            C *= B;
            Console.WriteLine($"C *= B: {C}");
            if (B != 0) C /= B;
            Console.WriteLine($"C /= B: {C}");

            // Unary Operators
            Console.WriteLine("\n--- Unary Operations ---");
            Console.WriteLine($"++A: {++A}");
            Console.WriteLine($"--B: {--B}");

            // Bitwise Operators
            Console.WriteLine("\n--- Bitwise Operations ---");
            Console.WriteLine($"A & B: {A & B}");
            Console.WriteLine($"A | B: {A | B}");
            Console.WriteLine($"A ^ B: {A ^ B}");
            Console.WriteLine($"~A: {~A}");
            Console.WriteLine($"A << 1: {A << 1}");
            Console.WriteLine($"B >> 1: {B >> 1}");

            // Conditional (Ternary) Operator
            Console.WriteLine("\n--- Conditional Operator ---");
            string result = (A > B) ? "A is greater" : "B is greater or equal";
            Console.WriteLine(result);

            // Type Conversion and Other Data Types
            Console.WriteLine("\n--- Using Other Data Types ---");
            float f = (float)A / B;
            double d = (double)A / B;
            decimal dec = (decimal)A / B;
            Console.WriteLine($"float division: {f}");
            Console.WriteLine($"double division: {d}");
            Console.WriteLine($"decimal division: {dec}");

            // Char and String
            char ch = 'X';
            string str = "Test";
            Console.WriteLine($"Char value: {ch}, String value: {str}");

            Console.ReadLine();
        }
    }
}
