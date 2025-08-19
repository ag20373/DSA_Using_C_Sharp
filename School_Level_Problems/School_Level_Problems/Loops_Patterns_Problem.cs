using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace School_Level_Problems.School_Level_Problems
{
    static class Loops_Patterns_Problem
    {
        #region Problem 1 : Print right triangle pattern

        public static void TrianglePattern()
        {
            int N = 5;
            for(int i = 0 ; i < (N); i++)
            {
                // Logic For Inverted Left Triangle
                for(int j = (N-1) - i ; j > 0; j--)
                {
                    Console.Write(" ");
                }

                // Logic For Right Triange
                for(int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        #endregion Problem 1 : Print right triangle pattern

        #region Problem 2 : Print inverted triangle pattern

        public static void Inverted_Triangle_Patter()
        {
            int N = 5; 
            for(int i = 0; i < N; i++)
            {
                for(int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j < (N-i) ; j++)
                {
                    Console.Write("*");
                }
                for(int p = 0; p < (N - 1)-i; p++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        #endregion Problem 2 : Print inverted triangle pattern

        #region Problem 3 : Pyramid triangle Pattern 

        public static void Pyramid_Pattern()
        {
            int N = 5;
            for(int i = 0; i < N; i++)
            {
                for(int j = (N-1)-i ;j > 0; j--)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        #endregion Problem 3 : Pyramid triangle Pattern

        #region Problem 4 : Print diamond pattern

        public static void diamond_Pattern()
        {
            int N = 5;
            for (int i = 0; i < N; i++)
            {
                for (int j = (N - 1) - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            for (int i = 0; i < N-1; i++)
            {
                for (int k = 0; k <= i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < ((N-1) - i); j++)
                {
                    Console.Write("*");
                }
                for (int p = 0; p < (N - 2) - i; p++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        #endregion Problem 4 :  Print diamond pattern

        #region Problem 5 : Square Pattern

        public static void Square_Pattern()
        {
            int n = 5;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }

        #endregion Problem 5 : Square Pattern

        #region Problem 6 : Print multiplication table

        public static void Multiplication_Table()
        {
            int Table = 2;
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{Table} * {i} = {Table * i} ");
            }
        }

        #endregion Problem 6 : Print multiplication table

        #region Problem 7 : Sum of first N natural numbers using loop

        public static void Sum_Of_Natual_Numbers()
        {
            int input = 5;
            int Sum = 0;
            for(int i = 1; i <= input; i++)
            {
                Sum += i;
            }
            Console.WriteLine($"Sum Of First N Natural Number Is : {Sum}");
        }

        #endregion Problem 7 : Sum of first N natural numbers using loop

        #region Problem 8 : Factorial Using Loop

        public static void Fact_Soluton()
        {
            int input = 5;

            BigInteger Fact = 1;
            for(int i = 1; i <= input; i++)
            {
                Fact *= i;
            }

            //LINQ
            //int factorial = Enumerable.Range(1, n)
            //                      .Aggregate(1, (acc, x) => acc * x);
            
            Console.WriteLine($"Factorial For {input} is : {Fact}");
        }

        public static void Fact_Recusion_Solution()
        {
            int input = 5;

            BigInteger Fact = Factorial_Logic(input , 1 );
            
            Console.WriteLine($"Factorial For {input} is : {Fact}");
        }

        private static BigInteger Factorial_Logic(int input , int Count)
        {
            if(Count == input)
            {
                return Count;
            }

            return Count * Factorial_Logic(input, Count + 1);
        }

        #endregion Problem 8 : Factorial Using Loop 

        #region Problem 9 : Count digits using loop

        public static void Count_Digits()
        {
            int Number = 1234;

            int Sum = Count_digit_RecusionLogic(Number);

            Console.WriteLine($"Sum {Sum} ");
        }

        private static int Count_digit_RecusionLogic(int Number)
        {
            if(Number == 0)
            {
                return 0;
            }

            int LastDigit = Number % 10;
            return LastDigit + Count_digit_RecusionLogic(Number / 10);

        }

        #endregion Problem 9 : Count digits using loop

        #region Problem 10 : Reverse number using loop

        public static void Reverse_Number()
        {
            int input = 1234;

            int Rev = Revrse_Logic(input ,0);

            Console.WriteLine($"Rev {Rev} ");
        }

        private static int Revrse_Logic(int input ,int Rev)
        {
            if(input == 0)
            {
                return Rev;
            }

            return Revrse_Logic(input / 10, ((Rev *10) + (input % 10)));
        }

        #endregion Problem 10 : Reverse number using loop

    }
}
