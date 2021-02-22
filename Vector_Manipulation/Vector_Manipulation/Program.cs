using System;

namespace Vector_Manipulation
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Console.Write("Choose the length of the first Array: ");
            int ALength = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Choose the length of the second Array: ");
            int BLength = int.Parse(Console.ReadLine());
            //Generate random Arrays
            int[] AArray = DisplayArray(ALength);
            Console.WriteLine();
            int[] BArray = DisplayArray(BLength);

            //We sort them using insertionSort (we can use any sortation method)
            //Then we display the sorted Array.
            Console.WriteLine();
            InsertionSort(AArray); //<---First Array sorted
            Console.Write("First Array sorted : ");
            for (int i = 0; i < ALength; i++)
                Console.Write(AArray[i] + " ");
            Console.WriteLine();
            InsertionSort(BArray); //<---Second Array sorted
            Console.Write("Second Array sorted : ");
            for (int i = 0; i < BLength; i++)
                Console.Write(BArray[i] + " ");
            /*-----------------------------------------------------------*/
            Console.WriteLine();
            Console.Write("AArray & BArray after Reunion : ");
            Reunion(AArray, BArray, ALength, BLength);
            /*-----------------------------------------------------------*/
            Console.WriteLine();
            Console.Write("AArray & BArray after intersection : ");
            Intersection(AArray, BArray, ALength, BLength);
            /*-----------------------------------------------------------*/
            Console.WriteLine();
            Console.Write("AArray & BArray after Difference : ");
            Difference(AArray, BArray, ALength, BLength);
        }
        private static void Reunion(int[] AArray, int[] BArray, int ALength, int BLength)
        {
            int[] ReArray = new int[ALength + BLength];
            int i = 0, j = 0, ReArrayLength = 0;
            while (i < ALength && j < BLength)
            {
                if (AArray[i] < BArray[j])
                {
                    ReArray[ReArrayLength] = AArray[i];
                    ReArrayLength++;
                    i++;
                }
                else
                {
                    ReArray[ReArrayLength] = BArray[j];
                    ReArrayLength++;
                    j++;
                }
            }
            if (i < ALength)
            {
                for (int poz = i; poz < ALength; poz++)
                {
                    ReArray[ReArrayLength] = AArray[poz];
                    ReArrayLength++;
                }
            }
            if (j < BLength)
            {
                for (int poz = j; poz < BLength; poz++)
                {
                    ReArray[ReArrayLength] = BArray[poz];
                    ReArrayLength++;
                }
            }
            for (int p = 0; p < ReArrayLength; p++)
                Console.Write(ReArray[p] + " ");


        }
        private static void Intersection(int[] AArray, int[] BArray, int ALength,int BLength)
        {
            int[] IntArray = new int[ALength + BLength];
            int IntArrayLength = 0;
            //to make sure we check all the numbers in AArray and BArray we need to know first , witch array is bigger 
            //this if does that check and we will compare the smaller array with the bigger one.
            if(ALength<BLength)
            {
                for(int i=0;i<ALength;i++)
                for(int j=0;j<BLength;j++)
                   if(AArray[i]==BArray[j])
                    {
                        IntArray[IntArrayLength] = AArray[i];
                        IntArrayLength++;
                    }
            }
            else
            {   for(int i=0;i<BLength;i++)
                for(int j=0;j<ALength;j++)
                    if (BArray[i] == AArray[j])
                    {
                        IntArray[IntArrayLength] = BArray[i];
                        IntArrayLength++;
                    }
                
            }
            for (int i = 0; i < IntArrayLength; i++)
                Console.Write(IntArray[i] + " ");
            
        }
        private static void Difference(int[] AArray, int[] BArray, int ALength, int BLength)
        {
            int[] DifArray = new int[ALength + BLength];
            int DifArrayLength = 0;
            bool IsFound= false;
            //to make sure we check all the numbers in AArray and BArray we need to know first , witch array is bigger 
            //this if does that check and we will compare the smaller array with the bigger one.
           
                for (int i = 0; i < ALength; i++)
                {
                    IsFound = false;
                    for (int j = 0; j < BLength; j++)
                        if (AArray[i] == BArray[j])
                        {
                            IsFound = true;
                            break;
                        }
                    if(!IsFound)
                    {
                        DifArray[DifArrayLength] = AArray[i];
                        DifArrayLength++;
                    }

                }
                for (int i = 0; i < BLength; i++)
                {
                    IsFound = false;
                    for (int j = 0; j < ALength; j++)
                        if (BArray[i] == AArray[j])
                        {
                            IsFound = true;
                            break;

                        }
                    if(!IsFound)
                    {
                        DifArray[DifArrayLength] = BArray[i];
                        DifArrayLength++;
                    }
                }


            
            for (int i = 0; i < DifArrayLength; i++)
                Console.Write(DifArray[i] + " ");

        }

        private static int[] DisplayArray(int ArrayLength)
        {
            int[] array = new int[ArrayLength];
            for (int i = 0; i < ArrayLength; i++)
                array[i] = random.Next(0, 15);
            for (int i = 0; i < ArrayLength; i++)
                Console.Write(array[i] + " ");
            return array;
        }
        private static void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;
                /* Move elements of arr[0..i-1], 
                    that are greater than key, 
                     to one position ahead of 
                      their current position */
                while (j >= 0 && array[j] > key) //change ">" to "<" if you want to your array to descend
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }
    }
}
