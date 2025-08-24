using School_Level_Problems.DSA_GPT._1_Arrays;
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
        static void Main(string[] args)
        {
            int[] arr = new int[]
            {
             //10 ,9 ,8,7,6,5,4,3,2,1
             //10 ,9 ,8,7,6,5,4,3,2   
             //1,1,2,3,3,5,6,7,8,9,10,10
                //1,2,3,4
                //1,2
                5,7,7,8,8,6,6,9,8,10,10
                //1,1,5,7,8,9,10
            };
            ArryEasyLvlProb.FindDuplicates_BruteForce(arr);
            
            //ArryEasyLvlProb.Reverse_Array_Optimal_Solution(arr);
        }
    }
}
