using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Level_Problems.DSA_GPT._1_Arrays
{
    static class ArrayScLevel
    {
        #region Basic Theory

        /* What is Array ?
         * Array ek data structure hai jo ek hi type ke multiple values ko single variable ke andar store karta hai.
         * 
         * Matlab agar aapko 100 students ke marks store karne hain, toh aapko 100 alag variables banane ki zarurat nahi hai (marks1, marks2, marks3...). Instead, ek array banakar saare marks ek sath store kar sakte ho.
         */

        /* Point To Remember
         * 1. Indexing Always starts from 0 -> first element arr[0]
         * 2. Array ek fixed size ka hota hai → ek bar declare kar diya toh uska size change nahi hota.
         * 3. Array ke elements same data type ke hone chahiye. Example: int[], string[], double[] etc.
         * 4. Length property se size nikal sakte ho.
         */

        #region Array School Level Problem

        #region Problem 1 : Print all elements of an array

        /* Iterative Version
         * Time Taken : O(n) - To iterate the array
         * Space Taken : O(1) - No Extra Array
        */
        public static void Print_Array(int[] arr)
        {
            Console.Write("Elements In Array Are : ");
            foreach(var item in arr)
            {
                Console.Write($"{item} , ");
            }

            Console.WriteLine();
        }

        /* Recursive Version
        * Time Complexity : O(n)   // n elements print karne hain
        * Space Complexity : O(n)  // recursion stack depth n
        */
        public static void Print_Array_Recusive(int[] arr)
        {
            Console.Write("Elements In Array Are : ");

            Print_Array_Recusive_Logic(arr ,0);
        }
        public static void Print_Array_Recusive_Logic(int[] arr , int index)
        {
            if(arr.Length == index)
            {
                return;
            }

            Console.Write($"{arr[index]} , ");
            Print_Array_Recusive_Logic(arr, index + 1);
        }

        #endregion Problem 1 : Print all elements of an array

        #region Problem 2 : Print array elements in reverse order

        //Input [10,20,30,40]	OutPut 40 30 20 10

        /* Iterative Version
         * Time Taken : O(n) - To iterate the array
         * Space Taken : O(1) - No Extra Array
        */
        public static void Print_Array_Reverse(int[] arr)
        {
            Console.Write("Elements In Array Are : ");

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} , ");
            }

            Console.WriteLine();
        }

        /* Recursive Version
        * Time Complexity : O(n)   // n elements print karne hain
        * Space Complexity : O(n)  // recursion stack depth n
        */
        public static void Print_Array_Reverse_Recusive(int[] arr)
        {
            Console.Write("Elements In Array Are : ");

            Print_Array_Reverse_Recusive_Logic(arr, arr.Length - 1);

            Console.WriteLine();
        }
        public static void Print_Array_Reverse_Recusive_Logic(int[] arr , int index) 
        {
            if(index < 0)
            {
                return;
            }

            Console.Write($"{arr[index]} , ");
            Print_Array_Reverse_Recusive_Logic(arr, index - 1);
        }

        #endregion Problem 2 : Print array elements in reverse order 

        #region Problem 3 : Find sum of all elements
        // [5,10,15]	30

        /* Iterative
         * Time  : O(N) - Iteration 
         * Space : O(1)
         */
        public static void Find_Array_Sum(int[] arr)
        {
            Print_Array(arr);
            
            // Will Get Total Sum of all Elements
            int Sum = 0;

            foreach(var item in arr)
            {
                Sum += item;
            }

            Console.WriteLine($"Sum Is : {Sum}");
        }

        /* Recursive 
         * Time : O(N)
         * Space : O(N)
         */
        public static void Find_Array_Sum_Recusion(int[] arr)
        {
            Print_Array(arr);

            int Sum = Find_Array_Sum_Recusion_Logic(arr, 0 ,0);

            Console.WriteLine($"Sum Is : {Sum}");
        }
        public static int Find_Array_Sum_Recusion_Logic(int[] arr , int index ,int Sum)
        {
            if(arr.Length == index)
            {
                return Sum;
            }

            Sum += arr[index];
            return Find_Array_Sum_Recusion_Logic(arr, index+1, Sum);
        }

        #endregion Problem 3 : Find sum of all elements

        #region Problem 4 : Find average of elements

        // [5,10,15]	10

        /* Iterative
         * Time  : O(N) - Iteration 
         * Space : O(1)
         */
        public static void Find_Array_Avg(int[] arr)
        {
            Print_Array(arr);

            // Will Get Total Sum of all Elements
            int Sum = 0;

            foreach (var item in arr)
            {
                Sum += item;
            }

            Console.WriteLine($"Avg Is : {Sum/arr.Length}");
        }

        /* Recursive 
         * Time : O(N)
         * Space : O(N)
         */
        public static void Find_Array_Avg_Recusion(int[] arr)
        {
            Print_Array(arr);

            int Sum = Find_Array_Avg_Recusion_Logic(arr, 0, 0);

            Console.WriteLine($"Sum Is : {Sum/arr.Length}");
        }
        public static int Find_Array_Avg_Recusion_Logic(int[] arr, int index, int Sum)
        {
            if (arr.Length == index)
            {
                return Sum;
            }

            Sum += arr[index];
            return Find_Array_Avg_Recusion_Logic(arr, index + 1, Sum);
        }

        #endregion Problem 4 : Find average of elements

        #region Problem 5 : Count even and odd numbers

        //[2,5,7,8,10] Even=3, Odd=2

        /* Iteration 
         * Time : O(N)
         * Space : O(1)
         */
        public static void Count_Even_Odd(int[] arr)
        {
            Print_Array(arr);

            (int Even,int Odd) = (0,0);

            foreach(var item in arr)
            {
                if (item % 2 == 0)
                {
                    Even++;
                }
                else
                {
                    Odd++;
                }
            }

            Console.WriteLine($"Even : {Even} , Odd : {Odd}");
        }

        /* Recursion
         * Time : O(N)
         * Space : O(N)
         */
        public static void Count_Even_Odd_Recurssion(int[] arr)
        {
            Print_Array(arr);

            (int Even, int ODD) = Count_Even_Odd_Recurssion_logic(arr, 0, 0, 0);

            Console.WriteLine($"Even : {Even} , Odd : {ODD}");
        }
        private static (int Even, int ODD) Count_Even_Odd_Recurssion_logic(int[] arr ,int index ,int Even ,int Odd)
        {
            if(arr.Length == index)
            {
                return (Even, Odd);
            }

            if(arr[index]% 2 == 0)
            {
                Even++;
            }
            else
            {
                Odd++;
            }

            return Count_Even_Odd_Recurssion_logic(arr, index + 1, Even, Odd);
        }

        #endregion Problem 5 : Count even and odd numbers


        #endregion Array School Level Problem

        #endregion Basic Theory
    }
}
