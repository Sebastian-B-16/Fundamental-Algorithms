using System;

namespace Matrix_SpiralDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose the number of lines for the Matrix : ");
            int MatrixLinesNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Choose the number of Columns for the Matrix : ");
            int MatrixColumnsNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[,] Matrix = new int[MatrixLinesNumber, MatrixColumnsNumber];
            MatrixElements(Matrix);
            Console.WriteLine();
            DisplayMatrix(Matrix);
            SpiralTravelPrint(MatrixLinesNumber, MatrixColumnsNumber, Matrix);

        }
        static Random random = new Random();
        private static void MatrixElements(int[,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
                for (int j = 0; j < Matrix.GetLength(1); j++)
                    Matrix[i, j] = random.Next(0, 10);
        }
        private static void DisplayMatrix(int[,] Matrix)
        {
            Console.WriteLine("This is the Matrix : ");
            for (int i = 0; i < Matrix.GetLength(0); i++)
            { for (int j = 0; j < Matrix.GetLength(1); j++)
                    Console.Write(Matrix[i, j] + " ");
                Console.WriteLine();
            }
        }
        static void SpiralTravelPrint(int MatrixLinesNumber, int MatrixColumnsNumber, int[,] Matrix)
        {
            int StartingRowIndex = 0;
            int StartingColumnsIndex = 0;
            /*
             * MatrixLinesNumber - ending row index
             * MatrixColumnsNumber - ending column index
            */
            while (StartingRowIndex < MatrixLinesNumber && StartingColumnsIndex < MatrixColumnsNumber)
            {
                //Print the first row
                // from the remaining rows
                for (int i = StartingColumnsIndex; i < MatrixColumnsNumber; i++)
                    Console.Write(Matrix[StartingRowIndex, i] + " ");
                StartingRowIndex++;

                //Print the last column from the 
                // remaining columns
                for (int i = StartingRowIndex; i < MatrixLinesNumber; i++)
                    Console.Write(Matrix[i, MatrixColumnsNumber- 1] + " ");
                MatrixColumnsNumber--;

                //Print the last row from 
                // the remaining rows
                if (StartingRowIndex < MatrixLinesNumber)
                { for (int i = MatrixColumnsNumber - 1 ; i >= 0; i--)
                        Console.Write(Matrix[MatrixLinesNumber- 1, i] + " ");
                    MatrixLinesNumber--;
                }

                //Print the first column from 
                // the remaining columns
                if(StartingColumnsIndex<MatrixColumnsNumber)
                { for (int i = MatrixLinesNumber - 1; i >= StartingRowIndex; i--)
                        Console.Write(Matrix[i, StartingColumnsIndex] + " ");
                    StartingColumnsIndex++;
                }
            }
        }
     
    }
}
