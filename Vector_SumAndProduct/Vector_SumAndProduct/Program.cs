using System;

namespace Vector_SumAndProduct
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Console.Write("Choose the length of first array: ");
            int Alength = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Choose the length of the second array: ");
            int Blength = int.Parse(Console.ReadLine());
            //Generate random Arrays 
            int[] AArray = DisplayArray(Alength);
            Console.WriteLine();
            int[] BArray = DisplayArray(Blength);
            Console.WriteLine();
            Console.Write("Sum or AArray & BArray is: ");
            Sum(AArray, BArray, Alength, Blength);
            /* ------------------------------------------------- */
            {/*Console.WriteLine();
            Console.Write("Prod of AArray & BArray is: ");
            Prod(AArray, BArray, Alength, Blength);*/
            }
        }
        //Function to generate random Arrays of length choosen by user
        private static int[] DisplayArray(int ArrayLength)
        {
            int[] array = new int[ArrayLength];
            for (int i = 0; i < ArrayLength; i++)
                array[i] = random.Next(0, 9);//<-- random generation of numbers between 0 & 9 
            for (int i = 0; i < ArrayLength; i++)
                Console.Write(array[i] + " ");
            return array;
        }
        private static int[] Sum(int[] AArray , int[] BArray, int Alength, int Blength)
        {
            int[] sumArray = new int[Math.Max(Alength,Blength)]; // the new array we create will have the length of biggest array between A & B
            int carry = 0; // if the sum or 2 numbers exceeed 9 we will need to carry for a clear result
            for(int i=sumArray.Length-1;i>=0;i--)
            {
                sumArray[i] = (AArray[i] + BArray[i] + carry) % 10;
                carry = (AArray[i] + BArray[i] + carry) / 10;
            }
            if(carry!=0)
            {
                int[] finalRezSum = new int[sumArray.Length + 1];
                finalRezSum[0] = carry;
                for (int i = 1; i < finalRezSum.Length; i++)
                    finalRezSum[i] = sumArray[i - 1];
                sumArray = finalRezSum;
            }
            for (int i = 0; i < sumArray.Length; i++)
                Console.Write(sumArray[i] + " ");

            return sumArray;
        }
        /*private static int[] Prod(int[] AArray, int[] BArray,int Alength, int Blength)
        {
            int[] RezProdArray = new int[Alength + Blength];
            int carry = 0;
            int RezProdArrayLength=Alength+Blength;
            for(int i=Blength;i>=0;i--)
                for(int j=Alength;j>=0;j--)
                {
                    RezProdArray[RezProdArrayLength] = ((BArray[i] * AArray[j]) + carry) % 10;
                    carry = ((BArray[i] * AArray[j]) + carry) / 10;
                    RezProdArrayLength--;
                }
            for (int i = RezProdArrayLength; i >= 0; i--)
            {
                Console.Write(RezProdArray[i] + " ");
            }
            return RezProdArray;
        }*/
    }
}
