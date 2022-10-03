using System;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } };
            //foreach(int index in arr)
            //{
            //    Console.WriteLine(index);
            //}

            //שורות
            for (int i = 0; i <arr.GetLength(0); i++)
            {
                //עמודות
                for (int j = 0; j <arr.GetLength(1); j++)
                {
                    Console.WriteLine($"{arr[i,j]}");
                }

            }
        }
    }
}
