using System;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pt2();
            while (true)
            {
                Console.WriteLine("Please ente a num ");
                int.TryParse(Console.ReadLine(), out int number5);
                Console.WriteLine(IsPrimeI(number5) == 1);

            }

            Pt3A();
            Pt4A();


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

        private static void Pt4A()
        {
            Console.WriteLine("________________TR4________________");
            int[] arr = { 1, 2, 3, 11, 5, 6, 7, 8, 9, 10 };
            CheckAarrayForPrimeNumbers(arr);
            Console.WriteLine("________________TR4________________");
        }
        static void CheckAarrayForPrimeNumbers(int[] arr)
        {
            int arrayLength = arr.Length - 1;
            int arrayPosition = arr[0];
            int i = 0;
            while (arrayLength >= 0)
            {
                int numCalc = arr[i];
                int devisors = 0;
                for (int j = 1; j <= arrayPosition; j++)
                {
                    if (arrayPosition % j == 0)
                    {
                        devisors++;
                    }
                }
                if (devisors == 2)
                {
                    Console.WriteLine($"{numCalc} is a prime number");
                }
                else
                {
                    Console.WriteLine($"{numCalc} is not a prime number");
                }
                arrayPosition++;
                arrayLength--;
                i++;
            }
        }
        static void Pt3A()
        {
            Console.WriteLine("________________TR3 sol 2________________");
            Console.WriteLine("please enter a number");
            int.TryParse(Console.ReadLine(), out int num);
            int devisors = 0;
            if (num <= 0)
            {
                Console.WriteLine("please enter a valid number");
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                        devisors++;
                }
            }
            if (devisors == 2)
            {
                Console.WriteLine("is a prime");
            }
            else
            {
                Console.WriteLine("is not prime");
            }
            Console.WriteLine("________________TR3 sol 2________________");
        }
        static void Pt2()
        {
            Console.WriteLine("enter a number");
            int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine($"number between 1 -10 {PrintNumber1to10(number)}");
        }
        static bool IsPrime(int number5)
        {

            if ((number5 % 2 == 0 && number5 != 2) || (number5 % 3 == 0 && number5 != 3))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        static bool PrintNumber1to10(int until)
        {
            for (int i = 1; i <= until; i++)
            {
                Console.WriteLine(i);
            }

            return (until >= 1) && (until <= 10);
        }
        static int IsPrimeI(int number)
        {
            if (number < 2)
                return 0;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return 0;//מספר לא ראשוני
                }
            }

            return 1;//מספר ראשוני
        }


    }
}
