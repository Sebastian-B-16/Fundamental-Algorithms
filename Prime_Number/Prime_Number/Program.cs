using System;

namespace Prime_Number
{   //Problem : We read an number from keyboard and we test to see if it's Prime or not.
    class Program
    {    
        static void Main(string[] args)
        {
            Console.Write("Number to test is? -> ");
            int x = int.Parse(Console.ReadLine());
            bool ok = Prime(x);
            if (ok == true)
            {
                Console.WriteLine(x + " is Prime");
            }
            else
            {
                Console.WriteLine(x + " is NOT Prime");
            }
        }
        //Private boolean function for testing the number 
        private static bool Prime(int x) 
        {
            if (x < 2) 
                return false; 
            if (x % 2 == 0)
                return false;
            for (int i = 3; i < Math.Sqrt(x); i = i + 2)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }
    }
}
