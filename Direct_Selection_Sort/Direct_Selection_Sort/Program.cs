using System;

namespace Direct_Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length of vector -> ");
            int VectorLength = int.Parse(Console.ReadLine());
            int[] Vector = DisplayVector(VectorLength);
            Console.WriteLine();
            DirectSort(Vector, VectorLength);
            Display(Vector);
            Console.WriteLine();
        }

    }
    private static void Display(int[] Vector)
    {
        Console.WriteLine("After Selection Sort");
        for (int i = 0; i < Vector.Length; i++)
            Console.Write(Vector[i] + " ");
    }
    static void DirectSort(int[] Vector,int VectorLength)
    {
        int posMin,i;
        for (i = 0; i < Vector.Length; i++)
            posMin = findPosMin(Vector[i]);
        int temp = Vector[i];
        Vector[i] = Vector[posMin];
        Vector[posMin] = temp;
    }
     static void findPosMin(int[] Vector)
        {
        int value = int.MaxValue;
        int pos = int.MaxValue;
        for(int i=1;i<Vector.Length;i++)
            if(Vector[i]<value)
            {
                value = Vector[i];
                pos = i;
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
