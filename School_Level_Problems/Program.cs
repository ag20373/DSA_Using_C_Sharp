using School_Level_Problems.Maths;
using School_Level_Problems.School_Level_Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Level_Problems
{
    class Program
    {
        public static object String_Problem { get; private set; }

        static void Main(string[] args)
        {
            int[] arr = new int[]
            {
                6, 2, 3, 4 ,5,6,7,28
            };
            for (int i = 0;i< arr.Length; i++)
            {
                //MathsProblem.Check_Odd_Even(arr[i]);
                //Console.WriteLine($"Factorial Of Number : {arr[i]} is {MathsProblem.fact_Recursion(arr[i])} ");
            }

            //MathsProblem.Swap_Two_Number(10, 20);
            //MathsProblem.Greatest_Three_Num();

            //String_Problems.Non_Repeating_Number_Recursion();
            //String_Problems.Reverse_Using_ForLoop_Manual_Swap();

            //Loops_Patterns_Problem.Reverse_Number();
            Array_Problems.Second_Smallest();
        }
    }
}
