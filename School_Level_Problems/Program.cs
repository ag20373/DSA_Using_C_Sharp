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
                1, 2, 3, 4, 100
            };
            for (int i = 0;i< arr.Length; i++)
            {
                MathsProblem.Length_Of_Number(arr[i]);
                //Console.WriteLine($"Factorial Of Number : {arr[i]} is {MathsProblem.fact_Recursion(arr[i])} ");
            }
            
        }
    }
}
