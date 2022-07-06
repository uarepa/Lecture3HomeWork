using System;

namespace Lecture3HomeWork
{
    class Program
    {
        # region tasks
        // Task1 The user enters 2 numbers (A and B). Raise the number A to the power of B.
        static double Exponentiation(double a, double b)
        {
            double temp = a;
            for (int i = 1; i < b; i++)
            {
                a *= temp;
            }
            return a;
        }

        // Task2 The user enters 1 number (A). Print all numbers from 1 to 1000 that are divisible by A.
        static int[] DivisibleNumbers(double a)
        {
            int[] NumberArray = new int[1000];
            int ArrayLength = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if ((i % a) == 0)
                {
                    NumberArray[ArrayLength++] = i;
                }
            }
            return NumberArray;
        }

        // Task3 The user enters 1 number (A). Find the number of positive integers whose square is less than A.
        static int SquareLessA(int a)
        {

            int result = 1;
            int i = a;
            while(a % i == 0)
            {
                i--;
                result = (int)Math.Sqrt(i);
            }
            return result;
        }
        // Task4 The user enters 1 number (A). Print the largest divisor (other than A itself) of the number A.
        static int TheLargestDivisor(int a)
        {

            int result = 1;
            for (int i = a - 1; i > 0; i--)
            {
                if(a % i == 0)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        // Task5 The user enters 2 numbers (A and B). Print the sum of all numbers from the range A to B that are divisible by 7 without a remainder. (Note that B may be less than A if you type).
        static int DivisibleSumOfSeven(int a, int b)
        {

            if(b < a)
            {
                int temp = a;
                a = b;
                b = temp;
            }    

            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        // Task6 The user enters 1 number (N). Print the Nth number of the fibonacci series. In the fibonacci series, each next number is the sum of the previous two. The first and second are considered equal to 1.
        static int Fibo(int n)
        {

            int first = 1;
            int second = 1;
            for (int i = 1; i < n; i++)
            {
                int temp = first;
                first = second;
                second = temp + first;

            }
            return first;
        }

        //Task7 7. The user enters 2 numbers. Find their greatest common divisor using Euclid's algorithm.
        static int Euqlid(int a, int b)
        {

            while (a != 0 && b != 0)
            {
                if(a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }

            return a + b;
        }

        //Task8 8 The user enters a positive integer that is the cube of the integer N.
        //Find the number N using binary search algorithm.
        static int CubeOfTheIntegerN(int number)
        {
            int cube = 0;
            int temp = number;
            while(temp > 1)
            {
                
                if((temp * temp * temp) > number)
                {
                    temp /= 2;
                }
                else
                {
                    temp = 0;
                }

                if ((temp * temp * temp) == number)
                {
                    cube = temp;
                    break;
                }


            }

            /// simple version

            //for (int i = 1; i <= number; i++)
            //{
            //    if (i * i * i > number)
            //    {
            //        return 0;
            //    }

            //    if (i * i * i == number)
            //    {
            //        cube = i;
            //        break;
            //    }
            //}

            /// simple version


            return cube;
        }

        //task 9. The user enters number. Find the number of odd digits of this number.
        static int OddDigits(int number)
        {

            int count = 0;
            while (number != 0)
            {
                if (number % 2 != 0)
                {
                    count++;
                }

                number /= 10;
            }

            return count;
        }


        //Task10. 10. The user enters number.
        //Find a number that is a mirror image of the sequence of digits of a given number,
        //for example, given the number 123, output 321.
        static int MirrorDigits(int number)
        {
            int result = 0;
            while (number != 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }

            return result;
        }

        //Task11. 11. The user enters a positive integer (N).
        //Print numbers in the range from 1 to N, the sum of whose even digits is greater than the sum of the odd ones.
        static int[] NumbersRange(int number)
        {
            int countOdd = 0;
            int countEven = 0;
            int[] NumberArray = new int[number];
            int ArrayLength = 0;
            while (number != 0)
            {
                if (number % 2 != 0)
                {
                    countOdd++;
                }
                else
                {
                    countEven++;
                    NumberArray[ArrayLength++] = number;
                }

                number /= 10;

            }

            if (countEven > countOdd)
            {
                return NumberArray;
            }
            else
            {
                Array.Clear(NumberArray, 0, ArrayLength);
                return NumberArray;
            }
            
        }


        //Task12  The user enters 2 numbers. Tell me if there are the same digits in the spelling of two numbers.
        //For example, for a pair of 123 and 3456789, the answer would be “YES”, and for a pair of 500 and 99, “NO”.
        static bool CheckDigits(int a, int b)
        {
            bool result = false;

            int temp = b;

            while (a != 0)
            {
                int tempA = a % 10;

                while(b != 0)
                {
                    int tempB = b % 10;

                    if(tempA == tempB)
                    {
                        result = true;
                        return result;
                    }

                    b /= 10;
                }

                b = temp;
                a /= 10;
            }

            return result;
        }
        #endregion

        #region helpers
        static void DisplayArray(int[] arr)
        {
            foreach(int i in arr)
            {
                if(i == 0)
                {
                    continue;
                }
                Console.Write($" {i}");
            }
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Menu Tasks");
            int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"check for same digits: {CheckDigits(a,b) }" );
            //Console.WriteLine(CubeOfTheIntegerN(a));
            DisplayArray(NumbersRange(a));
            Main(null);
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(Exponentiation(a, b));
            //Console.WriteLine(TheLargestDivisor(a));
            // Console.WriteLine(DivisibleSumOfSeven(a, b));
             
        }
    }
}
