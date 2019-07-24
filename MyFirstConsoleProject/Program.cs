using System;

namespace MyFirstConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int answer = Arithmetic.Add(3, 7);
            Console.WriteLine("3 + 7 = " + answer);
            answer = Arithmetic.Sub(10, 6); 
            Console.WriteLine("10 - 6 = " + answer);
            answer = Arithmetic.mult(5, 7);
            Console.WriteLine("5 * 7 = " + answer);
            answer = Arithmetic.div(7, 2);
            Console.WriteLine("7 / 2 = " + answer);
            answer = Arithmetic.mod(2345, 317);
            // Console.WriteLine("8 % 6 = " + answer); 
            bool TorF = Arithmetic.IsEvenlyDivisible(655, 5);
            Console.WriteLine($"655 is evenly divisible by 5: {TorF}");
        }
    }
    class Arithmetic {
        public static int Add (int a, int b) {
            return a + b;
           }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int mult(int a, int b)
        {
            return a * b;
        }
        public static int div(int a, int b)
        {
            return a / b;
        }
        public static int mod(int a, int b)
        {
            int ans = a % b;
            Console.WriteLine($"{a} mod {b} = {ans}");
            return ans;
        }
        public static bool IsEvenlyDivisible(int a, int b)
        {
            return mod(a, b) == 0; //to find out if a is evenly divisible by b
        }
       }

}
