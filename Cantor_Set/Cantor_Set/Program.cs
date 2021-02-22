using System;

namespace Cantor_Set
{
    class Program
    {
        const int Width = 81;
        const int Height = 5;
        private static char[,] lines = new char[Height, Width];
        static Program()
        {
            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                    lines[i, j] = '*';
        }
        private static void cantor(int start , int len , int index)
        {
            int segment = len / 3;
            if (segment == 0)
                return;
            for (int i = index; i < Height; i++)
                for (int j = start + segment; j < start + segment * 2; j++)
                    lines[i, j] = ' ';
            cantor(start, segment, index + 1);
            cantor(start + segment * 2, segment, index + 1);
        }

        static void Main(string[] args)
        {
            cantor(0, Width, 1);
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                    Console.Write(lines[i, j]);
                Console.WriteLine();
            }
        }
    }
}
