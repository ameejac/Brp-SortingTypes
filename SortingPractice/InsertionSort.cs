using System;
using System.Collections.Generic;
using System.Text;

namespace SortingPractice
{
    class InsertionSort
    {
        public void InsertionUserDefind()
        {
            Console.WriteLine("please enter the number length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[length];
            int  i, j, val, flag;
            Console.WriteLine("enter the num:");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 1; i < arr.Length; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            Console.WriteLine("Sort the elements in  Array : ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"\n");
            }
        }
        public void InerstionPredefined()
        {
            int i, j, temp;
            int[] num = { 25, 10, 5, 15, 20 };
            Console.WriteLine("Before Sorting:");
            for (i = 0; i < num.Length; i++)
            {
                Console.Write(" "+num[i]);
            }
            for (i = 0; i < num.Length-1; i++)
            {
                for (j = 0; j <num.Length-1; j++)
                {
                    if (num[j] > num[j+1])
                    {
                        temp = num[j+1];
                        num[j + 1] = num[j];
                        num[j] = temp;
                    }
                }
            }
            Console.WriteLine("after sorting:");
            foreach(var numbers in num)
            {
                Console.WriteLine(numbers);
            }
        }
    }
}
