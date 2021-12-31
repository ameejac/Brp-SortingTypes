using System;
using System.Collections.Generic;
using System.Text;

namespace SortingPractice
{
    class SelectionProces
    {
        public void PredefindSelection()
        {
            int i, j, temp;
            int[] arr = { 3, 1, 5, 2, 7 };
            Console.WriteLine("before sorting");
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            for (i = 0; i < arr.Length-1; i++)
            {
                int min = i;
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }
            Console.WriteLine("after sorting:");
            foreach(var numbers in arr)
            {
                Console.WriteLine(numbers);
            }
        }
        public void UserDefindSelection()
        {
            int i, j, temp;
            Console.WriteLine("please enter the num:");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[length];
            Console.WriteLine("before sorting:");
            for (i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < num.Length-1; i++)
            {
                int min = i;
                for (j = 1 + i; j < num.Length; j++)
                {
                    if (num[j] < num[min])
                    {
                        min = j;
                    }
                }
                temp = num[min];
                num[min] = num[i];
                num[i] = temp;
            }
            Console.WriteLine("After sorting:");
            foreach(var numbers in num)
            {
                Console.WriteLine(numbers);
            }
        }
    }
}
