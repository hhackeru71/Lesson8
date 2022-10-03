using System;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {

            //Pt6();
            //Pt6A();
            //Pt6M();
            Pt7E();
            Pt7M();
            Pt7I();
            //Pt2();
            //while (true)
            //{
            //    Console.WriteLine("Please ente a num ");
            //    int.TryParse(Console.ReadLine(), out int number5);
            //    Console.WriteLine(IsPrimeI(number5) == 1);

            //}

            //Pt3A();
            //Pt4A();
            //Pt5();


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

        static void Pt7I()
        {
            int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                int indexOfMinFromI = i;

                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[j] < intArray[indexOfMinFromI])
                    {
                        indexOfMinFromI = j;
                    }
                }

                (intArray[i], intArray[indexOfMinFromI]) =
                (intArray[indexOfMinFromI], intArray[i]);
            }

        }

        static void Pt7M()
        {
            int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };
            int temp;

            for (int i = 1; i <= intArray.Length - 1; i++)
            {
                for (int j = 0; j < intArray.Length - i; j++)
                {
                    if (intArray[j] > intArray[j + 1])
                    {
                        temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("print the array in ascending order:");
            foreach (int num in intArray)
                Console.Write($"{num}\t");

            Console.WriteLine("\n");
            Console.WriteLine("print the array in descending order:");
            for (int i = intArray.Length - 1; i >= 0; i--)
                Console.Write($"{intArray[i]}\t");

        }

        static void Pt7E()
        {
            int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };
            int temp;
            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = 0; j < intArray.Length - 1; j++)
                    if (intArray[j] > intArray[j + 1])
                    {
                        temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[(j + 1)] = temp;
                    }
            }

            Console.WriteLine("The ascending array is: (min to max");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            Console.WriteLine("========================================");

            Console.WriteLine("The ascending array is: (max to min");
            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(intArray[i]);
            }

        }

        static void Pt6M()
        {
            int n, m;
            Console.WriteLine("Enter two numbers->");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[m];

            Console.WriteLine("Inserts numbers->");
            for (int i = 0; i < arr1.Length; i++)
                arr1[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserts numbers->");
            for (int i = 0; i < arr2.Length; i++)
                arr2[i] = int.Parse(Console.ReadLine());


            Console.WriteLine($"The difference between the sums of the arrays->{WhichArrayIsBiggerM(arr1, arr2)}");

        }

        static int WhichArrayIsBiggerM(int[] arr1, int[] arr2)
        {
            int sumArr1 = 0, sumArr2 = 0;

            for (int i = 0; i < arr1.Length; i++)
                sumArr1 += arr1[i];

            for (int i = 0; i < arr2.Length; i++)
                sumArr2 += arr2[i];
            return sumArr1 - sumArr2;

        }


        static void Pt6A()
        {
            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = { 1, 2, 3 };
            Console.WriteLine(WhichArrayIsBiggerA(arr1, arr2));
        }

        static string WhichArrayIsBiggerA(int[] arr1, int[] arr2)
        {
            int doubleArr = arr1.Length + arr2.Length;
            int arr1Sum = 0;
            int arr2Sum = 0;
            while (doubleArr - 1 >= 0)
            {
                for (int i = 0; i <= arr1.Length - 1; i++)
                {
                    arr1Sum += arr1[i];
                    doubleArr--;

                }
                for (int j = 0; j <= arr2.Length - 1; j++)
                {
                    arr2Sum += arr2[j];
                    doubleArr--;
                }

            }
            return ($"the sum of both the arrays are {arr1Sum + arr2Sum}");
        }

        static int SumArray(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }
        static int WhichArrayIsBigger(int[] arr1, int[] arr2)
        {
            int SumArr1 = SumArray(arr1);
            int SumArr2 = SumArray(arr2);
            if (SumArr1 > SumArr2)
                return 1;
            else if (SumArr1 == SumArr2)
                return 0;
            return -1;
        }

         static void Pt5()
        {
            int[]arr3 = { 2, 17, 13, 9, 4, };
            CheckArrayForPrimeNumbers(arr3);
        }
         static void CheckArrayForPrimeNumbers(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine($"is number prime? {item} {IsPrimeI(item) == 1}");
            }
        }
        private static void Pt4A()
        {
            Console.WriteLine("________________TR4________________");
            int[] arr = { 1, 2, 3, 11, 5, 6, 7, 8, 9, 10 };
            CheckAarrayForPrimeNumbers(arr);
            Console.WriteLine("________________TR4________________");
        }
        static void Pt6()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5, 6, };
            Console.WriteLine($"the array is {WhichArrayIsBigger(arr1, arr2)}");
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
