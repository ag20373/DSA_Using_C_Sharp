using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_Level_Problems.School_Level_Problems;

namespace School_Level_Problems.DSA_GPT._1_Arrays
{
    class ArryEasyLvlProb
    {

        /* Easy Level Array Problems (Must-Know Before Medium)
         * 
         * 1. Basic Traversal & Operations
         *    - Find maximum and minimum in an array
         *    - Find second largest & second smallest element
         *    - Reverse an array
         *    - Rotate an array by k steps (left & right rotation)
         *    - Shift all elements left/right by 1
         * 
         * 2. Searching
         *    - Linear Search in unsorted array
         *    - Binary Search in sorted array
         *    - Search insert position
         *    - Find first and last occurrence of an element
         * 
         * 3. Frequency & Counting
         *    - Count occurrences of each element
         *    - Find element that appears only once
         *    - Majority element (> n/2 times)
         *    - Find duplicates in an array
         *    - Check if two arrays are equal
         * 
         * 4. Prefix/Suffix & Sum Problems
         *    - Find sum of all elements
         *    - Find subarray with given sum (positive integers)
         *    - Maximum subarray sum (Kadane’s Algorithm - basic)
         *    - Prefix sum array construction
         *    - Running sum of 1D array
         *    - Product of array except self (basic)
         * 
         * 5. Sorting & Rearranging
         *    - Sort an array (basic methods)
         *    - Sort 0s, 1s, 2s (Dutch National Flag - basic version)
         *    - Move all zeros to end while maintaining order
         *    - Rearrange array in alternating positive & negative numbers
         * 
         * 6. Set & Hashing Problems
         *    - Intersection of two arrays
         *    - Union of two arrays
         *    - Find missing number from 1…n
         *    - Find duplicate number (basic detection)
         *    - Check if array contains duplicate
         * 
         * 7. Special Pattern Problems
         *    - Two Sum
         *    - Best Time to Buy and Sell Stock I
         *    - Merge two sorted arrays
         *    - Intersection of two sorted arrays
         *    - Plus One
         *    - Pascal’s Triangle
         *    - Move negative numbers to beginning, positive to end
         * 
         */

        #region CGPT Must Know Questions

        // Basic Traversal & Operations
        #region Problem 1 : Find maximum and minimum in an array

        // GFG
        // Input - [10, 2, 30, 5]    Output - max=30, min=2

        /* Brute Force
         * Time : O(n) - Full Array Iteration Once
         * Space : O(1) - No Extra Space
         */
        public static void Find_Max_Min_Brute_Force(int[] arr)
        {
            ArrayScLevel.Print_Array(arr);
            int max = int.MinValue;
            int min = int.MaxValue;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }

            Console.WriteLine($"Max {max} , Min {min}");
        }

        /* Optimal
         * Time : O(n) - Iterates half the array but still O(n)
         * Space : O(1)
         */
        public static void Find_Max_Min_Optimal_Solution(int[] arr)
        {
            ArrayScLevel.Print_Array(arr);
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0 , j= arr.Length -1 ; i <= j; i++,j--)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
                if (i != j)  // avoid double-checking when i==j (middle element)
                {
                    if (arr[j] > max) max = arr[j];
                    if (arr[j] < min) min = arr[j];
                }
            }

            Console.WriteLine($"Max {max} , Min {min}");
        }

        /* Recussion
         * Time : O(n) - Recursion touches each element
         * Space : O(n) - Recursion stack in worst case
         */
        public static void Find_Max_Min_Recurrsion(int[] arr)
        {
            ArrayScLevel.Print_Array(arr);
            (int max, int min) = Find_Max_Min_Recurrsion_Logic(arr ,0 ,arr.Length-1 ,int.MinValue ,int.MaxValue);

            Console.WriteLine($"Max {max} , Min {min}");
        }
        public static (int max , int min) Find_Max_Min_Recurrsion_Logic(int[] arr ,int left ,int right ,int max, int min)
        {
            if(left > right)
            {
                return (max, min);
            }
            if (arr[left] > max) max = arr[left];
            if (arr[right] > max) max = arr[right];
            if (arr[left] < min) min = arr[left];
            if (arr[right] < min) min = arr[right];

            return Find_Max_Min_Recurrsion_Logic(arr ,left+1 ,right-1 ,max ,min);

        }

        /* Optimal - Pairwise Conparison.
         * Algorithm :
         * 1. Check for Array Length
         * 2. Even - Find Min And Max from First Two Element , Odd - Assign Min and Max as First Element
         * 3. Run a While Loop and Increment by 2 Each Step
         * 4. In Loop Compare Two Adjcent Elemnt to Fnd Which One is Greater .
         * 5. Then Compare The Greater One With Max and Min one Smaller.
         * 
         * Time : O(N) - Have To Iterate the Array
         * Space : O(1)
         * 
         * Why Better Then Previous One : 1.5n comparisons Compare To 2n comparisons
         * 
         */
        public static void PairWiseComparison_Optimal(int[] arr)
        {
            ArrayScLevel.Print_Array(arr);

            int min = 0;
            int max = 0;
            int i = 0;
            // IF Array is Even ,Find Max and Min using first and 2nd element
            if(arr.Length % 2 == 0)
            {
                if(arr[0] > arr[1])
                {
                    min = arr[1];
                    max = arr[0];
                }
                else
                {
                    min = arr[0];
                    max = arr[1];
                }
                i = 2;
            }
            else // Assign First Element in Both Min and Max
            {
                min = arr[0];
                max = arr[0];
                i = 1;
            }
            //[10, 2, 30, 5,65,32]
            while (i < arr.Length)
            {
                // Comapre Two Adjecent Element 
                if(arr[i] > arr[i + 1])
                {
                    // Compare Largest With Max and Smallest With Min.
                    if (arr[i] > max) max = arr[i];
                    if (arr[i + 1] < min) min = arr[i + 1];
                }
                else
                {
                    // Compare Largest With Max and Smallest With Min.
                    if (arr[i+1] >max) max = arr[i+1];
                    if (arr[i ] < min) min = arr[i];
                }

                i += 2;
            }

            Console.WriteLine($"Max {max} , Min {min}");
        }

        // Space : O(n) (call stack depth, since one call per 2 elements)
        public static void PairWiseComparison_Recusive(int[] arr)
        {
            ArrayScLevel.Print_Array(arr);
            int maxS = 0;
            int minS = 0;
            int i = 0;
            // IF Array is Even ,Find Max and Min using first and 2nd element
            if (arr.Length % 2 == 0)
            {
                if (arr[0] > arr[1])
                {
                    minS = arr[1];
                    maxS = arr[0];
                }
                else
                {
                    minS = arr[0];
                    maxS = arr[1];
                }
                i = 2;
            }
            else // Assign First Element in Both Min and Max
            {
                minS = arr[0];
                maxS = arr[0];
                i = 1;
            }

            (int max,int min) = PairWiseComparison_Recusive_Logic(arr, i ,maxS , minS);

            Console.WriteLine($"Max {max} , Min {min}");
        }
        public static (int max, int min) PairWiseComparison_Recusive_Logic(int[] arr, int index, int max, int min)
        {
            if (index >= arr.Length)
            {
                return (max, min);
            }
            
            if(arr[index] > arr[index + 1])
            {
                if (arr[index] > max) max = arr[index];
                if (arr[index + 1] < min) min = arr[index+1];
            }
            else
            {
                if (arr[index+1] > max) max = arr[index+1];
                if (arr[index] < min) min = arr[index];
            }

            return PairWiseComparison_Recusive_Logic(arr, index+2, max, min);

        }

        #endregion Problem 1 : Find maximum and minimum in an array

        #region Problem 2 : Find second largest & second smallest element

        // GFG
        // Input - [10, 5, 8, 20]    Output - 2nd max=10, 2nd min=8

        /* Brute Force
         * Time : O(n) - One Single Iteration
         * Space : O(1)
         */
        public static void Find_Second_Largest_Smallest_Brute_Force(int[] arr)
        {
            ArrayScLevel.Print_Array(arr);
            int max = int.MinValue;
            int secondMax = int.MinValue;

            int min = int.MaxValue;
            int secondMin = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                // Max and 2nd Max
                if (arr[i] > max)
                {
                    secondMax = max;
                    max = arr[i];
                }
                else if (arr[i] > secondMax && arr[i] < max)
                {
                    secondMax = arr[i];
                }

                // Min and 2nd Min
                if (arr[i] < min)
                {
                    secondMin = min;
                    min = arr[i];
                }
                else if (arr[i] < secondMin && arr[i] > min)
                {
                    secondMin = arr[i];
                }
            }
            if(secondMax == int.MinValue)
            {
                secondMax = max;
            }
            if(secondMin == int.MaxValue)
            {
                secondMin = min;
            }

            Console.WriteLine($"Max and 2nd Max is : {max} ,{secondMax} " +
                $" Min and 2nd Min is : {min} ,{secondMin} ");
        }

        /* Optimal
         * Time : O(n) 
         * Space : O(1)
         */
        public static void Find_Second_Largest_Smallest_Optimal_Solution(int[] arr)
        {
            ArrayScLevel.Print_Array(arr);
            int Max = 0;
            int Max2nd = int.MinValue;

            int min = 0;
            int min2nd = int.MaxValue;

            int index = 0;

            if(arr.Length % 2 == 0)
            {
                if(arr[0] > arr[1])
                {
                    Max = arr[0];
                    //Max2nd = arr[1];

                    min = arr[1];
                    //min2nd = arr[0];
                }
                else
                {
                    Max = arr[1];
                    //Max2nd = arr[0];

                    min = arr[0];
                    //min2nd = arr[1];
                }

                index = 2;
            }
            else
            {
                Max = min = arr[0];
                index = 1;
            }

            while(index < arr.Length)
            {
                if(arr[index] > arr[index + 1])
                {
                    if(arr[index] > Max)
                    {
                        Max2nd = Max;
                        Max = arr[index];
                        if (arr[index + 1] > Max2nd && arr[index + 1] < Max)
                        {
                            Max2nd = arr[index];
                        }
                    }
                    else if(arr[index] > Max2nd && arr[index] < Max)
                    {
                        Max2nd = arr[index];
                    }
                    

                    if(arr[index+1] < min)
                    {
                        min2nd = min;
                        min = arr[index+1];
                        if (arr[index] < min2nd && arr[index] > min)
                        {
                            min2nd = arr[index];
                        }
                    }
                    else if(arr[index+1] < min2nd && arr[index+1]> min) 
                    {
                        min2nd = arr[index + 1];
                    }
                }
                else
                {
                    if (arr[index+1] > Max)
                    {
                        Max2nd = Max;
                        Max = arr[index+1];
                        if (arr[index] > Max2nd && arr[index] < Max)
                        {
                            Max2nd = arr[index];
                        }
                    }
                    else if (arr[index+1] > Max2nd && arr[index+1] < Max)
                    {
                        Max2nd = arr[index+1];
                    }

                    if (arr[index] < min)
                    {
                        min2nd = min;
                        min = arr[index];
                        if (arr[index+1] < min2nd && arr[index+1] > min)
                        {
                            min2nd = arr[index+1];
                        }
                    }
                    else if (arr[index ] < min2nd && arr[index] > min)
                    {
                        min2nd = arr[index];
                    }
                }

                index += 2;
            }

            Console.WriteLine($"Max and 2nd Max is : {Max} ,{Max2nd} " +
                $" Min and 2nd Min is : {min} ,{min2nd} ");
        }

        /* Recursion
         * Time : 
         * Space :
         */
        public static void Find_Second_Largest_Smallest_Recursion(int[] arr)
        {
            ArrayScLevel.Print_Array(arr);
            int MaxS = int.MinValue;
            int Max2ndS = int.MinValue;

            int minS = int.MaxValue;
            int min2ndS = int.MaxValue;

            int index = 0;

            (int Max, int Max2nd, int min, int min2nd) = Find_Second_Largest_Smallest_Recursion_Logic(arr, index ,MaxS , Max2ndS,minS ,min2ndS);

            Console.WriteLine($"Max and 2nd Max is : {Max} ,{Max2nd} " +
                $" Min and 2nd Min is : {min} ,{min2nd} ");
        }
        public static (int Max ,int Max2nd ,int Min, int secondMin) Find_Second_Largest_Smallest_Recursion_Logic(int[] arr, int index, int max, int min, int secondMax, int secondMin)
        {
            if(index >= arr.Length-1)
            {
                if(arr.Length %2 == 0)
                {
                    return (max, secondMax, min, secondMin);
                }
                else
                {
                    if(arr[arr.Length-1] > max) 
                    {
                        secondMax = max;
                        max = arr[arr.Length - 1];
                    }
                    else if(arr[arr.Length - 1] > secondMax && arr[arr.Length - 1] < max)
                    {
                        secondMax = arr[arr.Length - 1];
                    }

                    if (arr[arr.Length - 1] < min)
                    {
                        secondMin = min;
                        min = arr[arr.Length - 1];
                    }
                    else if (arr[arr.Length - 1] < secondMin && arr[arr.Length - 1] < min)
                    {
                        secondMin = arr[arr.Length - 1];
                    }
                    return (max, secondMax, min, secondMin);

                }
            }

            if(arr[index] > arr[index + 1])
            {
                if(arr[index] > max)
                {
                    secondMax = max;
                    max = arr[index];

                    if(arr[index +1] > secondMax && arr[index+1] < max)
                    {
                        secondMax = arr[index + 1];
                    }
                }
                else if(arr[index] > secondMax && arr[index] < max)
                {
                    secondMax = arr[index];
                }

                if(arr[index +1] < min)
                {
                    secondMin = min;
                    min = arr[index + 1];

                    if(arr[index] < secondMin && arr[index] > min)
                    {
                        secondMin = arr[index];
                    }
                }
                else if(arr[index +1 ] <secondMin &&  arr[index+1] > min)
                {
                    secondMin = arr[index+1];
                }
            }
            else
            {
                if (arr[index+1] > max)
                {
                    secondMax = max;
                    max = arr[index+1];

                    if (arr[index ] > secondMax && arr[index] < max)
                    {
                        secondMax = arr[index];
                    }
                }
                else if (arr[index+1] > secondMax && arr[index+1] < max)
                {
                    secondMax = arr[index+1];
                }

                if (arr[index] < min)
                {
                    secondMin = min;
                    min = arr[index];

                    if (arr[index+1] < secondMin && arr[index+1] > min)
                    {
                        secondMin = arr[index+1];
                    }
                }
                else if (arr[index] < secondMin && arr[index] > min)
                {
                    secondMin = arr[index];
                }
            }

            return Find_Second_Largest_Smallest_Recursion_Logic(arr, index + 2, max, min, secondMax, secondMin);
        }

        #endregion

        #region Problem 3 : Reverse an array

        // Leetcode
        // Input - [1,2,3,4]    Output - [4,3,2,1]

        /* Brute Force
         * Time : O(N) 
         * Space : O(N) - Temp Array
         */
        public static void Reverse_Array_Brute_Force(int[] arr)
        {
            ArrayScLevel.Print_Array(arr);
            int[] temp = new int[arr.Length];
            for (int i = 0 ;  i < arr.Length ;i++)
            {
                temp[i] = arr[(arr.Length-1) - i];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = temp[i];
            }

            ArrayScLevel.Print_Array(arr);
        }

        /* Optimal
         * Time : O(N)
         * Space : O(1) - No Extra Array.
         */
        public static void Reverse_Array_Optimal_Solution(int[] arr)
        {
            ArrayScLevel.Print_Array(arr);

            for (int i = 0, j = arr.Length - 1; i < j; i++, j--)
            {
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }

            ArrayScLevel.Print_Array(arr);
        }

        /* Recursion
         * Time : O(N)
         * Space : O(N)
         */
        public static void Reverse_Array_Recursion(int[] arr)
        {
            ArrayScLevel.Print_Array(arr);

            Reverse_Array_Recursion_Logic(arr, 0, arr.Length - 1);

            ArrayScLevel.Print_Array(arr);
        }
        public static void Reverse_Array_Recursion_Logic(int[] arr, int left, int right)
        {
            if (left > right) return;
            (arr[left], arr[right]) = (arr[right], arr[left]);
            Reverse_Array_Recursion_Logic(arr, left + 1, right - 1);
        }

        #endregion Problem 3 : Reverse an array

        #region Problem 4 : Rotate an array by k steps
        // LeetCode 189

        // Input - [1,2,3,4,5], k=2    Output - [4,5,1,2,3]

        /* Brute Force
         * Algo
         * 1. Add element to Temp Array till K 
         * 2. Run iteration from K to N-1 and Swap element to Start
         * 3. Run Iteration To Add element at Last
         * 
         * Time : O(K + N -K + N - N + K) => O(N)
         * Space : O(K)
         */
        public static void Rotate_Array_Brute_Force(int[] arr)
        {
            ArrayScLevel.Print_Array(arr);
            int k = 6;
            int NoOfRev = k % arr.Length;
            List<int> TempList = new List<int>();

            for(int i = 0; i < NoOfRev; i++) //--- O(K) 
            {
                TempList.Add(arr[i]);
            }

            for(int i = NoOfRev; i < arr.Length; i++) //--- O(N - K)
            {
                arr[i-NoOfRev] = arr[i];
            }

            for(int i = arr.Length -NoOfRev ; i < arr.Length; i++) //--- O((N - (N-K)))
            {
                arr[i] = TempList[i - (arr.Length-NoOfRev)];
            }
            ArrayScLevel.Print_Array(arr);
        }

        /* Optimal
         * Algorithm
         * 1. Swap element from 0 to K-1
         * 2. Swap element from k to N-1
         * 3. Swap element from 0 to n-1
         * 
         * Time : O(N - K + K + N) =>  O(N)
         * Space : O(1)
         */
        public static void Rotate_Array_Optimal_Solution(int[] arr)
        {
            ArrayScLevel.Print_Array(arr);
            int k = 3 % arr.Length;
            if (k == 0) return; // nothing to rotate
            // Rotate 0 To K-1
            for (int i = 0,j = k-1 ; i < j ; i++ ,j--) // -- O(K)
            {
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }

            // Rotate K To N-1
            for (int i = k, j = arr.Length - 1 ; i < j; i++, j--) // -- O(N-k)
            {
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }

            // Rotate 0 To N-1
            for (int i = 0, j = arr.Length - 1; i < j; i++, j--) // -- O(N)
            {
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }

            ArrayScLevel.Print_Array(arr);
        }

        /* Recursion
         * Time : O(N)
         * Space : O(N)
         */
        public static void Rotate_Array_Recursion(int[] arr)
        {
            ArrayScLevel.Print_Array(arr);
            int k = 3 % arr.Length;
            if (k == 0) return; // nothing to rotate
            Rotate_Array_Recursion_Logic(arr, 0, k - 1);
            Rotate_Array_Recursion_Logic(arr, k, arr.Length-1);
            Rotate_Array_Recursion_Logic(arr, 0, arr.Length - 1);

            ArrayScLevel.Print_Array(arr);
        }
        public static void Rotate_Array_Recursion_Logic(int[] arr, int left, int right)
        {
            if(left > right)
            {
                return;
            }
            (arr[left], arr[right]) = (arr[right], arr[left]);

            Rotate_Array_Recursion_Logic(arr, left +1, right -1);
        }

        #endregion Rotate an array by k steps

        #region Problem 5 : Shift all elements left/right by 1
        //GFG

        // Input - [1,2,3,4]    Output Left Shift → [2,3,4,1] , Right Shift → [4,1,2,3]

        /* Brute Force
         * Time : O(N) - Iteration Whole Array Ocne
         * Space : O(1)
         */
        public static void Shift_Array_By_One_Optimal_Solution(int[] arr)
        {
            ArrayScLevel.Print_Array(arr);

            int LeftElement = arr[0];
            for(int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = LeftElement;
            ArrayScLevel.Print_Array(arr);
        }

        
        /* Recursion
         * Time : O(N) 
         * Space : O(N)
         */
        public static void Shift_Array_By_One_Recursion(int[] arr)
        {
            ArrayScLevel.Print_Array(arr);

            int LeftElement = arr[0];
            Shift_Array_By_One_Recursion_Logic(arr, 0, LeftElement);
            ArrayScLevel.Print_Array(arr);
        }
        public static void Shift_Array_By_One_Recursion_Logic(int[] arr, int index, int leftShift)
        {
            if(index == arr.Length - 1)
            {
                arr[arr.Length - 1] = leftShift;
                return;
            }

            arr[index] = arr[index + 1];
            Shift_Array_By_One_Recursion_Logic(arr, index + 1, leftShift);
        }

        #endregion

        // Searching
        #region  Problem 6 : Linear Search in unsorted array

        // GFG
        // Input : [5,10,15], key=10 
        // Output : index=1

        /* Brute Force
         * Time : O(N)
         * Space : O(1)
         */
        public static void LinearSearch_BruteForce(int[] arr, int key = 5)
        {
            ArrayScLevel.Print_Array(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == key)
                {
                    Console.WriteLine("Key Found");
                } 
            }

        }

        /* Recussion
         * Time : O(N)
         * Space : O(N)
         */
        public static void LinearSearch_Recusion(int[] arr, int key =5)
        {
            ArrayScLevel.Print_Array(arr);
            Console.WriteLine($"{LinearSearch_Recusion_Logic(arr ,0,key)}");
        }
        private static string LinearSearch_Recusion_Logic(int[] arr,int index, int key)
        {
            if(index >= arr.Length)
            {
                return "KeyNotFound";
            }

            if (arr[index] == key) return "KeyFound";
            return LinearSearch_Recusion_Logic(arr,index+1 ,key);
        }



        #endregion Problem 6 : Linear Search in unsorted array

        #region Problem 7 : Binary Search in sorted array

        // LeetCode 704
        // Input : [1,3,5,7], key=5
        // Output : index=2

        /* Binary Search - Brute Force 
         * Logic : Traverse each element, compare with key.
         * 
         * Time  : O(N)   → check all elements in worst case
         * Space : O(1)   → no extra space
        */
        public static string BinarySearch_BruteForce(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                    return $"Present at {i}";
            }
            return "Not Present";
        }

        /* Binary Search - Iterative (Optimal)
         * Logic : Use two pointers (left, right), repeatedly cut array in half.
         * 
         * Time  : O(log N)   → halved each step
         * Space : O(1)       → no recursion stack
         */
        public static string BinarySearch_Iterative(int[] arr, int key)
        {
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == key)
                    return $"Present at {mid}";
                else if (arr[mid] < key)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return "Not Present";
        }


        /* Binary Search Alogrithm 
         * Solved Using Divide and Conqure
         * Logic : Find The Mid Check if (= , < , >) - Then Divide it using mid element.
         * 
         * Time : After Each Call Array Is Recued By n/2 
         *          O(log N)
         *          
         * Space : O(log N)
         * 
         */
        public static void BinarySearch(int[] arr, int key) 
        {
            ArrayScLevel.Print_Array(arr);

            Console.WriteLine($"Key : {key} {BinarySearch_Recussion_Logic(arr,0 ,arr.Length-1,key)}");
        }
        public static string BinarySearch_Recussion_Logic(int[] arr, int left ,int right , int key) 
        {
            if(left > right)
            {
                return "Not Present";
            }
            int mid = left + (right - left) / 2;
            if(key == arr[mid])
            {
                return $"Present at {mid}";
            }
            else if(key > arr[mid])
            {
                return BinarySearch_Recussion_Logic(arr,mid+1,right,key);
            }
            else
            {
                return BinarySearch_Recussion_Logic(arr, left, mid-1, key);
            }
        }

        /* Under Standing Space and Time
         * Time : 
         * - Each recursive call halves the search space:
         * 1st Call N ,2nd Call N/2 ,3rd Call N/4 .... So On...
         * Recurrence: T(n) = T(n/2) + O(1)
         * O(log N)
         * 
         * Space : O(Log N) - Recusion Call For Every Division. 
         * 
         */

        #endregion Problem 7 : Binary Search in sorted array

        #region Problem 8 : Search insert position

        // LeetCode 35
        // Input : [1,3,5,6], key=2
        // Output : index=1

        /* Brute Force
         * Time : O(N) - Full Array Iteration At Worst
         * Space : O(1)
         */
        public static void SearchInsert_BruteForce(int[] arr, int key) 
        {
            ArrayScLevel.Print_Array(arr);
            int Index = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > key)
                {
                    Index = i;
                    break;
                }
            }

            Console.WriteLine($"Element {key} Can Be Added At Index {Index}");
        }

        /* Optimal (Binary Search)
         * Time : O(log N)
         * Space : O(1)
         */
        public static void SearchInsert_Optimal(int[] arr, int key) 
        {
            ArrayScLevel.Print_Array(arr);
            int left = 0;
            int right = arr.Length - 1;
            while(left <= right)
            {
                int mid = left + (right - left) / 2;
                
                if(arr[mid] == key)
                {
                    Console.WriteLine($"Element {key} Can Be Added At Index {mid}");
                    return;
                }
                else if(arr[mid] > key)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
           
            Console.WriteLine($"Element {key} Can Be Added At Index {left}");

        }

        public static void SearchInsert_Recurssion(int[] arr, int key)
        {
            ArrayScLevel.Print_Array(arr);

            Console.WriteLine($"Key : {key} Index At {SearchInsert_Recurssion_Logic(arr, 0, arr.Length - 1, key)}");
        }

        private static string SearchInsert_Recurssion_Logic(int[] arr, int left, int right, int key)
        {
            if (left > right)
            {
                return $"{left}";
            }

            int mid = left + (right - left) / 2;
            if(arr[mid] == key)
            {
                return $"{mid}";
            }
            else if(arr[mid] > key)
            {
                return SearchInsert_Recurssion_Logic(arr, mid + 1, right, key);
            }
            else
            {
                return SearchInsert_Recurssion_Logic(arr, left, right-1, key);
            }
        }

        #endregion Problem 8 : Search insert position

        #region Problem 9 : Find first and last occurrence

        // LeetCode 34
        // Input : [5,7,7,8,8,10], target=8
        // Output : [3,4]

        /* Brute Force : Consider Array Is Unsorted
         * Time : O(N)
         * Space : O(1)
         */
        public static void FirstLastOccurrence_BruteForce(int[] arr, int target ) 
        {
            ArrayScLevel.Print_Array(arr);
            int First = -1;
            int second = -1;
            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i] == target)
                {
                    if (First == -1) First = i;
                    second = i;
                }
            }

            Console.WriteLine($"{First } , {second}");
        }

        /* Optimal (Binary Search)
         * Time : O(log N)
         * Space : O(1)
         */
        public static void FirstLastOccurrence_Optimal(int[] arr, int target) 
        {
            ArrayScLevel.Print_Array(arr);

            #region First
            int first = 0;
            int left = 0, right = arr.Length - 1, result = -1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target)
                {
                    result = mid;
                    right = mid - 1; // keep searching left
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            first = result;
            #endregion First

            #region Last
            int last = 0;
            int left1 = 0, right1 = arr.Length - 1, result1 = -1;
            while (left1 <= right1)
            {
                int mid = left1 + (right1 - left1) / 2;
                if (arr[mid] == target)
                {
                    result1 = mid;
                    left1 = mid + 1; // keep searching right
                }
                else if (arr[mid] < target)
                {
                    left1 = mid + 1;
                }
                else
                {
                    right1 = mid - 1;
                }
            }
            right = result1;
            #endregion Last

            Console.WriteLine($"First: {first}, Last: {last}");
        }

        #endregion Problem 9 : Find first and last occurrence

        // Frequency & Counting
        #region Problem 10 : Count occurrences of each element
        // GFG
        // Input : [1,2,2,3,3,3]
        // Output : 1:1, 2:2, 3:3

        /* Brute Force 
         * Time : O(N^2)
         * Space : O(1)
         */
        public static void CountOccurrences_BruteForce(int[] arr) 
        {
            ArrayScLevel.Print_Array(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                // Skip duplicates → avoid printing same element multiple times
                bool alreadyCounted = false;
                for (int k = 0; k < i; k++)
                {
                    if (arr[k] == arr[i])
                    {
                        alreadyCounted = true;
                        break;
                    }
                }
                if (alreadyCounted) continue;

                int Count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Count++;
                    }
                }
                Console.WriteLine($"{arr[i]} Occurrence is {Count}");
            }
        }

        /* Optimal (HashMap / Dictionary)
         * Time : O(N)
         * Space : O(N)
         */
        public static void CountOccurrences_Optimal(int[] arr) 
        {
            ArrayScLevel.Print_Array(arr);
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            foreach(var item in arr)
            {
                if (keyValuePairs.ContainsKey(item))
                {
                    keyValuePairs[item] += 1;
                }
                else
                {
                    keyValuePairs[item] = 1;
                }
            }

            foreach (var item in keyValuePairs)
            {
                Console.WriteLine($"{item.Key} Total Occurance Is {item.Value}");
            }
        }
        #endregion Problem 10 : Count occurrences of each element

        #region Problem 11 : Find element that appears only once

        // LeetCode 136
        // Input : [4,1,2,1,2]
        // Output : 4

        /* Brute Force
         * Time : O(N^2)
         * Space : O(1)
         */
        public static void SingleNumber_BruteForce(int[] arr) 
        {
            ArrayScLevel.Print_Array(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                int Current = arr[i];
                bool Check = false;
                int count = 0;
                for (int j = 0; j < i; j++)
                {
                    if(arr[j] == Current)
                    {
                        Check = true;
                        break;
                    }
                }
                if (Check == true) continue;
                else
                {
                    for(int j = 0; j < arr.Length; j++)
                    {
                        if (arr[j] == Current) count++;
                    }
                    if (count == 1) Console.WriteLine($"{arr[i]}");
                }
            }
        }

        /* Optimal (Dictionary Approach)
         * Time : O(N)
         * Space : O(K) - Where K <= N
         */
        public static void SingleNumber_Optimal(int[] arr) 
        {
            ArrayScLevel.Print_Array(arr);
            Dictionary<int, int> freq = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
            }

            foreach (var kvp in freq)
            {
                if (kvp.Value == 1)
                    Console.WriteLine($"{kvp.Key} appears only once");
            }
        }

        /* Optimal (XOR) - If the problem guarantees exactly one single number (classic LeetCode "Single Number"), you can solve in O(N), O(1) using XOR:
         * Time : O(N)
         * Space : O(1) 
         */
        public static void SingleNumber_XOR_Optimal(int[] arr)
        {
            ArrayScLevel.Print_Array(arr);
            int Result = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                Result ^= arr[i];
            }
            Console.WriteLine(Result);
        }

        /*  Recurssion 
         *  Time :O(N)
         *  Space : O(N)
         */
        public static void SingleNumber_XOR_Recussion(int[] arr) 
        {
            ArrayScLevel.Print_Array(arr);
            int Result = SingleNumber_XOR_Recussion_Logic(arr, 0);
            Console.WriteLine(Result);
        }
        private static int SingleNumber_XOR_Recussion_Logic(int[] arr, int index,int result =0)
        {
            if (index >= arr.Length) return result;
            result ^= arr[index];
            return SingleNumber_XOR_Recussion_Logic(arr, index+1,result);
        }


        #endregion Problem 11 : Find element that appears only once

        #region Problem 12 : Majority element (>n/2 times)
        // LeetCode 169
        // Input : [3,3,4]
        // Output : 3

        /* Brute Force
         * Time : O(NLogN)
         * Space : O(1)
         */
        public static void MajorityElement_BruteForce(int[] arr) 
        {
            ArrayScLevel.Print_Array(arr);
            Array.Sort(arr); //O(NlogN)

            int Current = arr[0];
            int Count = 1;

            for (int i = 1; i < arr.Length; i++) //N
            {
                if(Current != arr[0])
                {
                    if (Count > arr.Length / 2)
                    {
                        Console.WriteLine($"{Current} Appears {Count}");
                    }
                    Current = arr[0];
                    Count++;
                }
                else 
                {
                    Count++;
                }
            }
        }

        /* Optimal (Moore’s Voting Algorithm)
         * Intution Behind This , That We Will Have Only One Element in Array Which is Majority.
         * 
         * Time : O(N)
         * Space : O(1)
         */
        public static void MajorityElement_Optimal(int[] arr) 
        {
            ArrayScLevel.Print_Array(arr);
            int Target = 0;
            int Count = 0;

            // Use Moore's Voting Algoritm to Find The Target
            for(int i = 0; i < arr.Length; i++)
            {
                // Get The Element if the Count is Zero
                if(Count == 0)
                {
                    Target = arr[i];
                    Count++;
                }
                // Same Element Appeart Increse the Count
                else if(Target == arr[i])
                {
                    Count++;
                }
                // Different Element Appear Decrese The Count.
                else
                {
                    Count--;
                }
            }

            // Check if the Target Element is Majority
            Count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == Target)
                {
                    Count++;
                }
            }
            if(arr.Length / 2 < Count)
            {
                Console.WriteLine($"{Target} is Majority Element");
            }
            else
            {
                Console.WriteLine($"Majority Element Not Exist");
            }
        }

        #endregion Problem 12 : Majority element (>n/2 times)

        #region Problem 13 : Find duplicates in an array

        // LeetCode 442
        // Input : [1,2,3,1]
        // Output : 1

        /* Brute Force
         * Time : O(N^2)
         * Space : O(1)
         */
        public static void FindDuplicates_BruteForce(int[] arr) 
        {
            ArrayScLevel.Print_Array(arr);
            bool skip = false;
            for (int i = 0; i < arr.Length; i++)
            {
                skip = false;
                int Current = arr[i];

                // Check If Already Appeard
                for(int j = 0; j < i; j++)
                {
                    if(arr[j] == Current)
                    {
                        skip = true;
                        break;
                    }
                }

                // Check For Duplicate Using Count > 1
                if(skip == true)
                {
                    continue;
                }
                else
                {
                    int count = 0;
                    for(int j = 0; j < arr.Length; j++)
                    {
                        if(arr[j] == Current)
                        {
                            if (count == 0)
                            {
                                count += 1;
                            }
                            else
                            {
                                Console.WriteLine($"{Current}");
                                break;
                            }
                        }
                    }
                }
            }
        }

        /* Optimal (Index Marking)
         * Note : In This The Array element Should be In Range from 1 to Arr.Length-1
         * Time : O(N)
         * Space : O(1) with index marking
         */
        public static void FindDuplicates_Optimal(int[] arr) 
        {
            ArrayScLevel.Print_Array(arr);
            List<int> ResultSet = new List<int>();
            int indexToCheck = -1;
            for(int i = 0; i < arr.Length; i++)
            {
                indexToCheck = Math.Abs(arr[i]) - 1; // map value → index

                if (arr[indexToCheck] < 0)
                {
                    // already visited → duplicate
                    ResultSet.Add(Math.Abs(arr[i]));
                }
                else
                {
                    // mark as visited
                    arr[indexToCheck] = -arr[indexToCheck];
                }
            }
        }

        public static void FindDuplicates_Recussion(int[] arr)
        {
            ArrayScLevel.Print_Array(arr);
            List<int> rs = new List<int>();
            List<int> ResultSet = FindDuplicates_Recussion_Logic(arr ,0,rs);
        }

        private static List<int> FindDuplicates_Recussion_Logic(int[] arr, int index ,List<int> RS)
        {
            if(index >= arr.Length)
            {
                return RS;
            }

            // Look For Index
            int indexToCheck = Math.Abs(arr[index]) - 1;

            // // already visited → duplicate
            if(arr[indexToCheck] < 0)
            {
                RS.Add(Math.Abs(arr[index]));
            }
            else
            {
                // mark as visited
                arr[indexToCheck] = -arr[indexToCheck];
            }

            return FindDuplicates_Recussion_Logic(arr, index+1, RS);
        }

        #endregion Problem 13 : Find duplicates in an array

        #region Problem 14 : Check if two arrays are equal
        // GFG
        // Input : [1,2,3], [3,2,1]
        // Output : Yes

        
        /* Optimal (Sorting or HashMap)
         * Time : O(N log N) or O(N)
         * Space : O(1) or O(N)
         */
        public static void AreArraysEqual_Optimal(int[] arr1, int[] arr2) 
        {
            
        }
        #endregion Problem 14 : Check if two arrays are equal

        // Prefix/Suffix & Sum Problems
        #region Problem 15 : Find sum of all elements
        // Basic
        // Input : [1,2,3,4]
        // Output : 10

        /* Brute Force
         * Time : O(N)
         * Space : O(1)
         */
        public static void SumOfArray_BruteForce(int[] arr) 
        {
            ArrayScLevel.Print_Array(arr);
            int Sum = 0;
            foreach(var item in arr)
            {
                Sum += item;
            }

            Console.WriteLine($"Sum Of Array Is : {Sum}");
        }

        /* Optimal (LINQ Sum / reduce)
         * Time : O(N)
         * Space : O(1)
         */
        public static void SumOfArray_Optimal(int[] arr) 
        {
            ArrayScLevel.Print_Array(arr);

            int Sum = arr.Sum();

            Console.WriteLine($"Sum Of Array Is : {Sum}");
        }

        /* Recursion
         * Time : O(N)
         * Space : O(N)
         */
        public static int SumOfArray_Recursion(int[] arr, int index)
        {
            if (index >= arr.Length) return 0;

            return arr[index] + SumOfArray_Recursion(arr, index + 1);
        }
        #endregion Problem 15 : Find sum of all elements

        #region Problem 16 : Find subarray with given sum (positive)

        #endregion Problem 16 : Find subarray with given sum (positive)


        #endregion CGPT Must Know Questions

        #region LeetCode_Problems_Solved

        #region 26. Remove Duplicates from Sorted Array
        /*
        // Problem : Sorted Array - Remove All Duplicate And Place Each element One Other ,then Return Unique. 
        // Time Compleixty : O(N) - One Time Run
        // Space : O(1) - No Extra Space
        // Constraints:
        //   1 <= nums.length <= 3 * 104
        //   -100 <= nums[i] <= 100
        //   nums is sorted in non-decreasing order.
        */
        public int RemoveDuplicates(int[] arr)
        {
            // First Element is Always Unique
            int Current = arr[0];
            int Index = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                // IF Same Element Appears, Ignore
                if (arr[i] == Current) continue;
                else
                {
                    // Increment the index To Store New Unique Element in next Place ,then Change the Current to new unique.
                    Index++;
                    arr[Index] = arr[i];
                    Current = arr[Index];
                }
            }

            return Index + 1;
        }

        #endregion 26. Remove Duplicates from Sorted Array

        #region 34. Find First and Last Position of Element in Sorted Array

        /* Find First and Last Position of Element in Sorted Array
         * Solve With Log N Time Complexity
         * 
         * Time Take :  O(Log N) As Array Iteration Keep Decresing By N/2
         * Space : O(1) - No Extra Space.
         * 
         * Note : To Use Binary Search Array Must Be Sorted Already 
         */
        public int[] SearchRange(int[] arr, int target)
        {
            int Left = 0;
            int Right = arr.Length - 1;
            int First = -1;
            int Last = -1;
            // Find The First Occurence Binary Search
            while (Left <= Right)
            {
                int Mid = Left + (Right - Left) / 2;
                if (arr[Mid] == target)
                {
                    First = Mid;
                    Right = Mid - 1;
                }
                else if (arr[Mid] > target)
                {
                    Right = Mid - 1;
                }
                else
                {
                    Left = Mid + 1;
                }
            }

            Left = 0;
            Right = arr.Length - 1;
            // Find The Last Occurence Binary Search 
            while (Left <= Right)
            {
                int Mid = Left + (Right - Left) / 2;
                if (arr[Mid] == target)
                {
                    Last = Mid;
                    Left = Mid + 1;
                }
                else if (arr[Mid] > target)
                {
                    Right = Mid - 1;
                }
                else
                {
                    Left = Mid + 1;
                }
            }

            return new int[] { First, Last };
        }

        #endregion 34. Find First and Last Position of Element in Sorted Array

        #region 35. Search Insert Position

        /* Search Insert Position
         * Time : O(N)
         * Space : O(1)
         */
        public int SearchInsert(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                
                // IF same element exist Just return its index
                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            // Else Retrun the Left
            return left;
        }

        #endregion 35. Search Insert Position

        #region 136. Single Number

        /* Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
         * You must implement a solution with a linear runtime complexity and use only constant extra space.
         * 
         * Time : O(N)
         * Space : O(1)
         */
        public int SingleNumber(int[] arr)
        {
            int Result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Result ^= arr[i];
            }
            return Result;
        }

        #endregion 136. Single Number

        #region 169. Majority Element

        /* The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.
         * Solved Using (Moore’s Voting Algorithm)
         * 
         * Time : O(N)
         * Space :O(1)
         */
        public int MajorityElement(int[] arr)
        {
            int Target = 0;
            int Count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (Count == 0)
                {
                    Target = arr[i];
                    Count++;
                }
                else if (Target == arr[i])
                {
                    Count++;
                }
                else
                {
                    Count--;
                }
            }

            return Target;
        }

        #endregion 169. Majority Element

        #region 189. Rotate Array

        public void Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n;  // handle cases where k > n

            // Step 1: reverse whole array
            RotateArray(nums, 0, n - 1);

            // Step 2: reverse first k elements
            RotateArray(nums, 0, k - 1);

            // Step 3: reverse remaining n-k elements
            RotateArray(nums, k, n - 1);
        }

        public void RotateArray(int[] arr, int left, int right)
        {
            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }

        #endregion 189. Rotate Array

        #region 442.

        #endregion 442.

        #region 704. Binary Search

        #endregion 704. Binary Search

        #region 1752. Check if Array Is Sorted and Rotated

        #endregion 1752. Check if Array Is Sorted and Rotated

        #endregion LeetCode_Problems_Solved

        #region Quick Recap

        /* Basic Traversal & Operations
         * 1. Find maximum and minimum in an array
         * -> Naive : Traverse once for max, once for min → 2n comparisons.
         * -> Better : Traverse once, check both max & min in one loop → 2 comparisons per element.
         * -> Best (Pair Comparison method) → Compare elements in pairs → ~1.5n comparisons.
         * -> Best Time is O(N) with Comparsion 1.5n comparisons Compare To 2n comparisons
         * -> Best Space is O(1)
         * -> Trick → Works for arrays with negatives as well.
         * 
         * 2. Find second largest & second smallest element
         * -> Keep track of : firstMax, secondMax , firstMin, secondMin
         * -> Time Best O(N) Best Space is O(1)
         * -> Duplicates ([1, 1, 1] → no 2nd largest).
         * -> Array size < 2 (invalid case).
         * 
         * 3. Reverse An Array
         * -> Use C# Tuple To Swap or Using Temp Variable
         * -> Iteration Using Left and Right Till Left < Right
         * -> Time And Space : O(N) And O(1)
         * 
         * 4. Rotate an array by k steps
         * -> Best Approach Is Rotate 0 to K-1 -> K to Length -1 -> 0 to Length -1 
         * -> O(N) - Time, O(1) - Space.
         * -> Edge Case → If k > N, take k = k % N
         * 
         * 5. Shift all elements left/right by 1
         * -> Left Shift by 1 → Save arr[0], move all left, place saved at arr[n-1]
         * -> Right Shift by 1 → Save arr[n-1], move all right, place saved at arr[0].
         * -> Time : O(N)
         * -> Space : O(1)
         */

        #endregion Quick Recap

    }
}
