using System;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers you want to have your list ? -> ");
            int ListLength = int.Parse(Console.ReadLine());
            int[] List = new int[ListLength];
            Random random = new Random(); //random variable 
            for(int i=0;i<ListLength;i++)
            {   //in this case we will have an random list of numbers between 0 and 150
                List[i] = random.Next(150); 
            }
            //Lets see the random the computer generated for us before we sort 
            for (int i=0; i < ListLength;i++)
            {
                Console.Write("{0} ", List[i]);
            }
            Console.WriteLine();
            bubblesort(ListLength, List);
            //List before we used bubblesort function
            for (int i = 0; i < ListLength; i++)
            {
                Console.Write("{0} ", List[i]);
            }
        }
        private static void bubblesort(int ListLength,int[] List)
        {
            for(int i=0;i< ListLength - 1;i++)
                for (int j = i + 1; j < ListLength; j++)
                   if(List[i]>List[j])   // change ">" to "<" if you want the list to descend
                    {
                        int aux = List[i];
                        List[i] = List[j];
                        List[j] = aux;
                    }   
        }
    }
}
