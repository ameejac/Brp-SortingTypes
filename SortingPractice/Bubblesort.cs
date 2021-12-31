using System;
using System.Collections.Generic;
using System.Text;

namespace SortingPractice
{
    class Bubblesort
    {
        public void BubbleSortPredefined()
        {
            int[] arr = { 11, 15, 14, 10, 12, 13 };
            Console.WriteLine("before sorting:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            int temp;
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine(" \n" + "After sorting:");
            foreach (int p in arr)
            {
                Console.Write(" " + p);

            }
        }
        public void BubbleSortUserDefind()
        {
            Console.WriteLine("please enter the legnth");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[length];
            int i, j, temp;
            Console.WriteLine("before sorting:");
            for (i = 0; i < arr.Length; i++)
            {
               arr[i] = Convert.ToInt32(Console.ReadLine());
               // Console.Write(" "+arr[i]);
            }
            for ( i = 0; i < arr.Length-1; i++)
            {
                for (j = 0; j < arr.Length-1 ; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j+1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("after sorting:");
            foreach(var numbers in arr)
            {
                Console.WriteLine(numbers);
            }
        }
    }
}
