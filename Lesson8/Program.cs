using System;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Pt2();

            //int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } };
            ////foreach(int index in arr)
            ////{
            ////    Console.WriteLine(index);
            ////}

            ////שורות
            //for (int i = 0; i <arr.GetLength(0); i++)
            //{
            //    //עמודות
            //    for (int j = 0; j <arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"{arr[i,j]}");
            //    }
            //}
        }

        static void Pt2()
        {
            Console.WriteLine("enter a number");
            int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine($"number between 1 -10 {PrintNumber1to10(number)}");
        }

        static bool PrintNumber1to10(int until)
        {
            for (int i = 1; i <= until; i++)
            {
                Console.WriteLine(i);
            }

            return (until >= 1) && (until <= 10);
        }

    }
}
