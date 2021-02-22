using System;

namespace Palindrom_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number you want to test -> ");
            int x = int.Parse(Console.ReadLine());
            int aux = x;
            int palindrom = 0;
            while(aux!=0)
            {
                palindrom = palindrom * 10 + (aux % 10);
                aux = aux / 10;
            }
            if (palindrom == x)
            {
                Console.WriteLine("Number {0} is palindrom", x);
            }
            else
                Console.WriteLine("Number {0} is NOT palindrom", x);
        }
    }
}
