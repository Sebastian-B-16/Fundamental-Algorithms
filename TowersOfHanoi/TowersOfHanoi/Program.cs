using System;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            char StartTower = 'A';
            char EndTower = 'C';
            char TempTower = 'B';
            int TotalDisks = 3;
            solveTowers(TotalDisks, StartTower, EndTower, TempTower);
        }
        private static void solveTowers(int n,char StartTower,char EndTower,char TempTower)
        {
            if(n>0)
            {
                solveTowers(n - 1, StartTower, TempTower, EndTower);
                Console.WriteLine("Move disk from " + StartTower + " to " + EndTower);
                solveTowers(n - 1, TempTower, EndTower, StartTower);
            }
        }
    }
}
