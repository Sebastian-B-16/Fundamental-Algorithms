using System;

namespace Euclid_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input First Number (x) -> ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Input Second number (y) -> ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(CMMDCS(x, y));
            Console.WriteLine(CMMDCD(x, y));
        }
        private static int CMMDCS(int x, int y)
        {
            while (x != y)
            {
                if (x < y)
                    y = y - x;
                else
                    x = x - y;
                Console.WriteLine(x);
            }
            return x;
        }
        private static int CMMDCD(int x,int y)
        {
            int c;
            while(y!=0)
            {
                c = x % y;
                x = y;
                y = c;
            }
            return x;
        }
    }
}
