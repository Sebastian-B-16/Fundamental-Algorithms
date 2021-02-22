using System;

namespace PrimeNumber_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int MatrixStrength = ReadInput();
            DisplayMatrixOfPrimes(MatrixStrength);
        }
        // Function ReadInput is used to chose the Dimension of the Matrix 
        private static int ReadInput() 
        {
            Console.Write("Choose the number of lines and columns for Matrix : ");
            string input = Console.ReadLine();
            int MatrixStrength = int.Parse(input);
            return MatrixStrength;
        }
            // Function FindNextPrime is where we search for every prime number we need in ascended order to fill the dimension of the matrix
            private static int FindNextPrime(int StartNumber)
            {
                int Nr = StartNumber;
                while (!IsPrime(Nr)) //calling IsPrime Function where we search for the number
                    Nr++;            // When Prime number is Found , we will return that Number to the Matrix |DisplayMatrixOfPrimes Function for Print.            
                return Nr;
            }
            private static bool IsPrime(int Nr)
            {
                if (Nr == 2)
                    return true;
                if (Nr % 2 == 0)
                    return false;
                int maxDivider = (int)Math.Sqrt(Nr);
                for (int Divider = 3; Divider <= maxDivider; Divider += 2)
                    if (Nr % Divider == 0)
                        return false;
                return true;
            }
        //DisplayMatrixOfPrimes is the function where we print the Matrix of Primes 
        private static void DisplayMatrixOfPrimes(int Dimension)
        {
            Console.WriteLine("Matrix is : ");
            int LastPrime = 1;
            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    int NextPrime = FindNextPrime(LastPrime + 1); 
                    Console.Write("{0,4}", NextPrime);
                    LastPrime = NextPrime;
                }
                Console.WriteLine();
            }
        }
    }
}

