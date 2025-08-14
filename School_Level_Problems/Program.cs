using School_Level_Problems.Maths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Level_Problems
{
    class Program
    {
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
            MathsProblem.Greatest_Three_Num();
        }
    }
}
