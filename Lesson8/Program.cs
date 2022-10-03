using System;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number until which to print:");
            int.TryParse(Console.ReadLine(), out int until);
            bool inRange1to10 = PrintNumbers(until);
            Console.WriteLine($"{until} is in range 1-10: {inRange1to10}");

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

        static bool PrintNumbers(int until)
        {
            for (int i = 1; i <= until; i++)
            {
                Console.WriteLine(i);
            }

            return (until >= 1) && (until <= 10);
        }

    }
}
