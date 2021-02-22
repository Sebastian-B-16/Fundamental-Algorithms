using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("how many numbers you wanna see ? : ");
            int n = int.Parse(Console.ReadLine());
            fibo(n, 1, 1, 0);
        }
        static void fibo(int n,int c,int a,int b)
        {
            if (c > n)
                return;
            else
            {
                Console.Write((a + b) + " ");
                fibo(n, c + 1, b, a + b);
            }
        }
    }
}
