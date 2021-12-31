using System;

namespace SortingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("1.InsertionUserDefind, 2.InerstionPredefined,3.BubbleSortPredefined,4.BubbleSortUserDefind,5.PredefindSelection,6.UserDefindSelection");
            try 
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("InsertionUserDefind:");
                        InsertionSort obj = new InsertionSort();
                        obj.InsertionUserDefind();
                        break;
                    case 2:
                        Console.WriteLine("InerstionPredefined:");
                        InsertionSort obj1 = new InsertionSort();
                        obj1.InerstionPredefined();
                        break;
                    case 3:
                        Console.WriteLine("BubbleSortPredefined:");
                        Bubblesort objb = new Bubblesort();
                        objb.BubbleSortPredefined();
                        break;
                    case 4:
                        Console.WriteLine("BubbleSortPredefined:");
                        Bubblesort objb1 = new Bubblesort();
                        objb1.BubbleSortPredefined();
                        break;
                    case 5:
                        Console.WriteLine("");
                        SelectionProces selec = new SelectionProces();
                        selec.PredefindSelection();
                        break;
                    case 6:
                        Console.WriteLine("");
                        SelectionProces selec1 = new SelectionProces();
                        selec1.UserDefindSelection();
                        break;
                    default:
                        Console.WriteLine("Come Out side Of Switchcase");
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            

        }
    }
}
