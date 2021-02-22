using System;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose the Length of your array -> ");
            int ArrayLength = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] array = DisplayVector(ArrayLength);
            Console.WriteLine();
            InsertionSort(array);
            Console.Write("Array sorted after using insertionSort : ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i]+" ");


        }
        //Function to sort array using insertion sort
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
        //function to read a random array with ArrayLength being chosen by user
        private static int[] DisplayVector(int ArrayLength)
        {
            Random random = new Random();
            int[] array = new int[ArrayLength];
            Console.Write("you'r array is : ");
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(0, 150);
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            return array;
        }
       
    }
}
