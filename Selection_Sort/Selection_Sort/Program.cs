using System;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("type Vector Length -> ");
            int VectorLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Selection Sort");
            int[] Vector = DisplayVector(VectorLength); //the vector takes form.
            Console.WriteLine();
            SelectionSort(Vector); 
            Display(Vector); //will display the vector in  anyshape , depeinding on when you call the function
            Console.WriteLine();
        }
        /* Function to print an array */
        private static void Display(int[] Vector) 
        {
            Console.WriteLine("After Selection Sort");
            for (int i = 0; i < Vector.Length; i++)
                Console.Write(Vector[i] + " ");
        }
        static void SelectionSort(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                int minIndex = i;
                // One by one move boundary of unsorted subarray 
                for (int j = i + 1; j < vector.Length; j++)
                    if (vector[j] < vector[minIndex])
                        minIndex = j; // Find the minimum element in unsorted array  
                // Swap the found minimum element with the first element  
                int temporary = vector[minIndex];
                vector[minIndex] = vector[i];
                vector[i] = temporary;
            } 
        }
        private static int[] DisplayVector(int VectorLength)
        {
            Random random = new Random();
            int[] vector = new int[VectorLength];
            for (int i = 0; i < vector.Length; i++)
                vector[i] = random.Next(0, 50); // add random number in vector from 0 to 50 in this case
            for (int i = 0; i < vector.Length; i++)
                Console.Write(vector[i] + " ");

            return vector;
        }
    }
}

