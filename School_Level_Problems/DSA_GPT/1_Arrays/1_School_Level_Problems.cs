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

        #region Problem 6 : Count positive and negative numbers

        // [-2,5,-1,3,7]	Positive=3, Negative=2


        /* Iteration
         * Time : O(N)
         * Space : O(1)
         */
        public static void Count_Prositive_Negative(int[] arr)
        {
            Print_Array(arr);
            int Positive = 0;
            int Negative = 0;

            foreach(var item in arr)
            {
                if (item < 0) Negative++;
                else Positive ++;
            }

            Console.WriteLine($"Positive : {Positive} , Negative : {Negative}");
        }

        /* Recusrive
         * Time : O(N)
         * Space : O(N)
         */
        public static void Count_Prositive_Negative_Recusive(int[] arr)
        {
            Print_Array(arr);
            (int Positive, int Negative) = Count_Prositive_Negative_Recusive_Logic(arr ,0 , 0,0);
            Console.WriteLine($"Positive : {Positive} , Negative : {Negative}");
        }
        private static (int Positive, int Negative) Count_Prositive_Negative_Recusive_Logic(int[] arr, int Index, int Pos, int Nev)
        {
            if(arr.Length == Index)
            {
                return (Pos, Nev);
            }

            if (arr[Index] > 0) Pos++;
            else Nev++;

            return Count_Prositive_Negative_Recusive_Logic(arr, Index+1, Pos, Nev);
        }

        #endregion Problem 6 : Count positive and negative numbers

        #region Problem 7 , 8 ,9 , 10 : Find Largest , Second Largest , Smallest , Second Smallest

        // [10,25,3,45,7]	Largest 45 SecondLargest 25 Smallest 3 SecnodnSmallest 7 

        /* Iteration 
         * Time : O(N)
         * Space : O(1)
         */
        public static void Find_Element_Max_Min(int[] arr)
        {
            Print_Array(arr);

            int Largest = arr.Min();
            int SecondLargest = arr.Min();

            int Smallest = arr.Max();
            int SecondSmallest = arr.Max();

            for(int i= 0; i < arr.Length; i++)
            {
                // Largest and Second Largest
                if(arr[i] > Largest)
                {
                    SecondLargest = Largest;
                    Largest = arr[i];
                }
                else if(arr[i] > SecondLargest && arr[i] < Largest)
                {
                    SecondLargest = arr[i];
                }

                // Smallest and Second Smallest
                if(arr[i] < Smallest)
                {
                    SecondSmallest = Smallest;
                    Smallest = arr[i];
                }
                else if(arr[i] < SecondSmallest && arr[i] > Smallest)
                {
                    SecondSmallest = arr[i];
                }
            }

            Console.WriteLine($"Largest : {Largest} , SecondLargest : {SecondLargest} , Smallest : {Smallest} , secondSmallest : {SecondSmallest}");
        }

        /* Recusion
         * Time : O(N)
         * Space : O(N)
         */
        public static void Find_Element_Max_Min_Recusion(int[] arr)
        {
            Print_Array(arr);

            (int Largest, int SecondLargest, int Smallest, int SecondSmallest) = Find_Element_Max_Min_Recusion_Logic(arr, 0, 0, 0, int.MaxValue, int.MaxValue);

            Console.WriteLine($"Largest : {Largest} , SecondLargest : {SecondLargest} , Smallest : {Smallest} , secondSmallest : {SecondSmallest}");
        }
        private static (int Largest, int SecondLargest, int Smallest, int SecondSmallest) Find_Element_Max_Min_Recusion_Logic(int[] arr, int i, int Largest, int SecondLargest, int Smallest, int SecondSmallest)
        {
            if(arr.Length == i)
            {
                return (Largest, SecondLargest, Smallest, SecondSmallest);
            }

            // Largest and Second Largest
            if (arr[i] > Largest)
            {
                SecondLargest = Largest;
                Largest = arr[i];
            }
            else if (arr[i] > SecondLargest && arr[i] < Largest)
            {
                SecondLargest = arr[i];
            }

            // Smallest and Second Smallest
            if (arr[i] < Smallest)
            {
                SecondSmallest = Smallest;
                Smallest = arr[i];
            }
            else if (arr[i] < SecondSmallest && arr[i] > Smallest)
            {
                SecondSmallest = arr[i];
            }

            return Find_Element_Max_Min_Recusion_Logic(arr, i + 1, Largest, SecondLargest, Smallest, SecondSmallest);
        }

        #endregion Problem 7 , 8 ,9 , 10 : Find Largest , Second Largest , Smallest , Second Smallest

        #region Problem 11 : Linear Serach

        //[10,20,30,40], key=30	Found at index 2

        /* iteration
         * Time : O(N)
         * Space : O(1)
         */
        public static void Linear_Search(int[] arr)
        {
            Print_Array(arr);
            int Find = 30;

            for(int item =0;item < arr.Length; item++)
            {
                if(arr[item] == Find)
                {
                    Console.WriteLine($"Elements {Find} Present at Index : {item}");
                    break;
                }
            }
        }

        /* Recusion
         * Time : O(N)
         * Space : O(N)
         */
        public static void Linear_Search_Recussion(int[] arr)
        {
            Print_Array(arr);
            int Find = 30;
            int index = Linear_Search_Recussion_Logic(arr, 0, Find);
            Console.WriteLine($"Elements {Find} Present at Index : {index}");
        }
        private static int Linear_Search_Recussion_Logic(int[] arr, int index, int find)
        {
            if(arr.Length == index)
            {
                return -1;
            }

            if(arr[index] == find)
            {
                return index;
            }

            return Linear_Search_Recussion_Logic(arr, index + 1, find);
        }

        #endregion Problem 11 : Linear Serach

        #region Problem 12 : Find index of first occurrence of element
        // [5,2,3,5,7,5], key=5   =>  Index=0

        /* Iteration
         * Time : O(N)
         * Space : O(1)
         */
        public static void Find_First_Occurrence(int[] arr)
        {
            Print_Array(arr);
            int Key = 5;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == Key)
                {
                    Console.WriteLine($"First Occurrence Of {Key} is At index {i} ");
                    break;
                }
            }
        }

        /* Recursion
         * Time : O(N)
         * Space : O(N)
         */
        public static void Find_First_Occurrence_Recursion(int[] arr)
        {
            Print_Array(arr);
            int key = 5;
            int index = Find_First_Occurrence_Recursion_Logic(arr, key, 0);
            Console.WriteLine($"First Occurrence of {key} : {index}");
        }
        private static int Find_First_Occurrence_Recursion_Logic(int[] arr, int key, int index)
        {
            if(arr.Length == index)
            {
                return -1;
            }
            if(arr[index] == key)
            {
                return index;
            }
            return Find_First_Occurrence_Recursion_Logic(arr ,key ,index+1);
        }
        #endregion Problem 12 : Find index of first occurrence of element

        #region Problem 13 : Find index of last occurrence of element
        // [5,2,3,5,7,5], key=5   =>  Index=5

        /* Iteration 
         * Time : O(n)
         * Space : O(1)
         */
        public static void Find_Last_Occurrence(int[] arr)
        {
            Print_Array(arr);
            int Key = 5;
            for(int i = arr.Length-1; i >= 0; i--)
            {
                if(Key == arr[i])
                {
                    Console.WriteLine($"Last Occurrence of {Key} is Present at index : {i}");
                    break;
                }
            }

            
        }

        /* Recursion 
         * Time : O(N)
         * Space : O(N)
         */
        public static void Find_Last_Occurrence_Recursion(int[] arr)
        {
            Print_Array(arr);
            int index = Find_Last_Occurrence_Recursion_Logic(arr, 5, arr.Length - 1);
            Console.WriteLine($"Last Occurrence of {5} : {index}");
        }
        private static int Find_Last_Occurrence_Recursion_Logic(int[] arr, int key, int index)
        {
            if(index < 0)
            {
                return -1;
            }
            if(arr[index] == key)
            {
                return index;
            }

            return Find_Last_Occurrence_Recursion_Logic(arr,key ,index-1);
        }
        #endregion Problem 13 : Find index of last occurrence of element

        #region Problem 14 : Count frequency of a given element
        // [1,2,1,3,1,4], key=1   => Count=3

        /* Iteration
         * Time : O(N)
         * Space : O(1)
         */
        public static void Count_Frequency(int[] arr)
        {
            Print_Array(arr);

            int Key = 1;
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == Key)
                {
                    count++;
                }
            }
            Console.WriteLine($"{Key} Frequency {count}");
        }

        /* Recursion
         * Time : O(N)
         * Space : O(N)
         */
        public static void Count_Frequency_Recursion(int[] arr, int key)
        {
            Print_Array(arr);
            int count = Count_Frequency_Recursion_Logic(arr, key, 0, 0);
            Console.WriteLine($"Count of {key} : {count}");
        }
        private static int Count_Frequency_Recursion_Logic(int[] arr, int key, int index, int count)
        {
            if(arr.Length == index)
            {
                return count;
            }

            if(arr[index] == key)
            {
                count++;
            }
            return Count_Frequency_Recursion_Logic(arr,key,index+1 ,count);
        }
        #endregion Problem 14 : Count frequency of a given element

        #region Problem 15 : Reverse an array (in-place)
        // [1,2,3,4,5]  => [5,4,3,2,1]

        /* Iteration
         * Time : O(N) -- Run till n/2
         * Space : O(1)
         */
        public static void Reverse_Array_InPlace(int[] arr)
        {
            Print_Array(arr);
            for(int i =0, j = arr.Length - 1; i < j; i++, j--)
            {
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
            Print_Array(arr);
        }

        /* Recursion 
         * Time : O(N)
         * Space : O(N)
         */
        public static void Reverse_Array_InPlace_Recursion(int[] arr)
        {
            Print_Array(arr);
            Reverse_Array_InPlace_Recursion_Logic(arr, 0, arr.Length - 1);
            Print_Array(arr);
        }
        private static void Reverse_Array_InPlace_Recursion_Logic(int[] arr, int left, int right)
        {
            if(left > right)
            {
                return; 
            }

            (arr[left], arr[right]) = (arr[right], arr[left]);
            Reverse_Array_InPlace_Recursion_Logic(arr, left+1, right-1);
        }
        #endregion Problem 15 : Reverse an array (in-place)

        #region Problem 16 : Copy one array to another
        // [10,20,30] => New=[10,20,30]

        /* Iteration 
         * Time : O(N)
         * Space : O(N)
         */
        public static void Copy_Array(int[] arr)
        {
            Print_Array(arr);
            int[] arrNew = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arrNew[i] = arr[i];
            }

            Print_Array(arrNew);
        }

        /* Recursion
            * Time : O(N)
            * Space : O(N)  // recursion stack + new array
        */
        public static int[] Copy_Array_Recursion(int[] arr)
        {
            Print_Array(arr);
            int[] newArr = new int[arr.Length];
            Copy_Array_Recursion_Logic(arr, newArr, 0);
            return newArr;
        }

        private static void Copy_Array_Recursion_Logic(int[] arr, int[] newArr, int index)
        {
            if (index == arr.Length) return;

            newArr[index] = arr[index];
            Copy_Array_Recursion_Logic(arr, newArr, index + 1);
        }
        #endregion Problem 16 : Copy one array to another

        #region Problem 17 : Copy array in reverse order
        // [10,20,30] => New=[30,20,10]

        /* Iteration
        * Time : O(N)
        * Space : O(N)
        */
        public static void Copy_Array_Reverse(int[] arr)
        {
            Print_Array(arr);
            int[] newArr = new int[arr.Length];

            for (int i = 0, j = arr.Length - 1; i < arr.Length; i++, j--)
            {
                newArr[i] = arr[j];
            }

            Print_Array(newArr);
        }

        /* Recursion
        *   Time : O(N)
        * Space : O(N)
        */
        public static int[] Copy_Array_Reverse_Recursion(int[] arr)
        {
            Print_Array(arr);
            int[] newArr = new int[arr.Length];
            Copy_Array_Reverse_Recursion_Logic(arr, newArr, arr.Length - 1, 0);
            return newArr;
        }
        private static void Copy_Array_Reverse_Recursion_Logic(int[] arr, int[] newArr, int oldIndex, int newIndex)
        {
            if (oldIndex < 0) return;

            newArr[newIndex] = arr[oldIndex];
            Copy_Array_Reverse_Recursion_Logic(arr, newArr, oldIndex - 1, newIndex + 1);
        }
        #endregion Problem 17 : Copy array in reverse order

        #region Problem 18 : Count total number of zeros
        // [0,5,0,2,9,0] => 3

        /* Iteration 
         * Time and Space : O(N) and O(1)
         */
        public static void Count_Zeros(int[] arr)
        {
            Print_Array(arr);
            int count = 0;

            foreach(var item in arr)
            {
                if(item == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Total Zeros : {count}");
        }

        /* Recursion 
         * Time : O(N)
         * Space : O(N)
         */
        public static void Count_Zeros_Recursion(int[] arr)
        {
            Print_Array(arr);
            int count = Count_Zeros_Recursion_Logic(arr, 0, 0);
            Console.WriteLine($"Total Zeros : {count}");
        }
        private static int Count_Zeros_Recursion_Logic(int[] arr, int index, int count)
        {
            if(arr.Length == index)
            {
                return count;
            }
            if (arr[index] == 0)
            {
                count++;
            }

            return Count_Zeros_Recursion_Logic(arr, index+1, count);
        }
        #endregion Problem 18 : Count total number of zeros

        #region Problem 19 : Count elements greater than K
        // [10,25,30,15], k=20 => 2

        /* Iteration 
         * Time : O(N)
         * Space : O(1)
         */
        public static void Count_Greater_Than_K(int[] arr, int k=20)
        {
            Print_Array(arr);
            int count = 0;
            for(int i = 0;i < arr.Length; i++)
            {
                if (arr[i] > k) count++;
            }

            Console.WriteLine($"Elements Greater then {k} is {count}");
        }

        /* Recursion 
         * Time : O(N)
         * Space : O(N)
         */
        public static void Count_Greater_Than_K_Recursion(int[] arr, int k = 20)
        {
            Print_Array(arr);
            int count = Count_Greater_Than_K_Recursion_Logic(arr, k, 0, 0);
            Console.WriteLine($"Count greater than {k} : {count}");
        }
        private static int Count_Greater_Than_K_Recursion_Logic(int[] arr, int k, int index, int count)
        {
            if (arr.Length == index)
                return count;

            if (arr[index] > k) count++;
            return Count_Greater_Than_K_Recursion_Logic(arr,k,index+1, count);
        }

        #endregion Problem 19 : Count elements greater than K

        #region Problem 20 : Count multiples of 5
        // [5,12,20,33,40] => 3

        /* Iteration 
         * Time : O(N)
         * Space : O(1)
         */
        public static void Count_Multiples_Of_5(int[] arr)
        {
            Print_Array(arr);
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Count multiples of 5 : {count}");
        }

        /* Recursion 
         * Time : O(N)
         * Space : O(N)
         */
        public static void Count_Multiples_Of_5_Recursion(int[] arr)
        {
            Print_Array(arr);
            int count = Count_Multiples_Of_5_Recursion_Logic(arr, 0, 0);
            Console.WriteLine($"Multiples of 5 : {count}");
        }
        private static int Count_Multiples_Of_5_Recursion_Logic(int[] arr, int index, int count)
        {
            if(arr.Length== index)
            {
                return count;
            }

            if(arr[index]%5 ==0)
            {
                count++;
            }
            return Count_Multiples_Of_5_Recursion_Logic(arr, index + 1, count);
        }

        #endregion Problem 20 : Count multiples of 5

        #region Problem 21 : Swap first and last element
        // [10,20,30,40] => [40,20,30,10]

        /* Iteration
         * Time : O(1)
         * Space : O(1)
         */
        public static void Swap_First_Last(int[] arr)
        {
            Print_Array(arr);
            (arr[0] ,arr[arr.Length-1]) = (arr[arr.Length-1],arr[0]);
            Print_Array(arr);
        }
        
        #endregion Problem 21 : Swap first and last element

        #region Problem 22 : Swap alternate elements
        // [1,2,3,4,5,6] => [2,1,4,3,6,5]

        /* Iteration
         * Time : O(N)
         * Space : O(1)
         */
        public static void Swap_Alternate(int[] arr)
        {
            Print_Array(arr);
            if(arr.Length % 2 == 0)
            {
                for(int i = 0, j = 1; j < arr.Length;  j += 2,i += 2)
                {
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            else
            {
                for (int i = 0, j = 1; j < arr.Length-1; j += 2, i += 2)
                {
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }

            // CGPT Version
            //for (int i = 0; i < arr.Length - 1; i += 2)
            //{
            //    (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
            //}
            Print_Array(arr);
        }

        /* Recursion
         * Time : O(N)
         * Space : O(N)
         */
        public static void Swap_Alternate_Recursion(int[] arr)
        {
            Print_Array(arr);
            Swap_Alternate_Recursion_Logic(arr, 0);
            Print_Array(arr);
        }
        private static void Swap_Alternate_Recursion_Logic(int[] arr, int index)
        {
            if(arr.Length-1 <= index)
            {
                return;
            }

            (arr[index], arr[index + 1]) = (arr[index+1], arr[index]);
            Swap_Alternate_Recursion_Logic(arr, index + 2);
        }
        #endregion Problem 22 : Swap alternate elements

        #region Problem 23 : Shift all elements left by 1
        // [10,20,30,40] => [20,30,40,10]

        /* Iteration
         * Time : O(N)
         * Space : O(1)
         */
        public static void Shift_Left(int[] arr)
        {
            Print_Array(arr);
            int left = arr[0];

            for(int i = 0; i < arr.Length-1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = left;

            Print_Array(arr);
        }

        /* Recursion
         * Time : O(N)
         * Space : O(N)
         */
        public static void Shift_Left_Recursion(int[] arr)
        {
            Print_Array(arr);
            Shift_Left_Recursion_Logic(arr, 0, arr[0]);
            Print_Array(arr);
        }
        private static void Shift_Left_Recursion_Logic(int[] arr, int index, int first)
        {
            if (arr.Length - 1 == index)
            {
                arr[arr.Length - 1] = first;
                return;
            }

            arr[index] = arr[index + 1];
            Shift_Left_Recursion_Logic(arr, index + 1, first); 
        }
        #endregion Problem 23 : Shift all elements left by 1

        #region Problem 24 : Shift all elements right by 1
        // [10,20,30,40] => [40,10,20,30]

        /* Iteration */
        public static void Shift_Right(int[] arr)
        {
            Print_Array(arr);
            int Last = arr[arr.Length - 1];

            for(int i = arr.Length - 1; i >= 1; i--)
            {
                arr[i] = arr[i-1];
            }
            arr[0] = Last;
            Print_Array(arr);
        }

        /* Recursion */
        public static void Shift_Right_Recursion(int[] arr)
        {
            Print_Array(arr);
            Shift_Right_Recursion_Logic(arr, arr.Length - 1, arr[arr.Length - 1]);
            Print_Array(arr);
        }
        private static void Shift_Right_Recursion_Logic(int[] arr, int index, int last)
        {
            if(index < 1)
            {
                arr[0] = last;
                return;
            }

            arr[index] = arr[index - 1];
            Shift_Right_Recursion_Logic(arr,index-1,last);
        }
        #endregion Problem 24 : Shift all elements right by 1

        #region Problem 25 : Find sum of elements at even indices
        // [10,20,30,40,50] => 90

        /* Iteration */
        public static void Sum_Even_Indices(int[] arr)
        {
            Print_Array(arr);
            int sum = 0;
            for(int i = 0; i < arr.Length ; i += 2)
            {
                sum += arr[i];
            }
            Console.WriteLine($"sum of elements at even indices : {sum}");
        }

        /* Recursion */
        public static void Sum_Even_Indices_Recursion(int[] arr)
        {
            Print_Array(arr);
            int sum = Sum_Even_Indices_Recursion_Logic(arr, 0, 0);
            Console.WriteLine($"Sum at Even Indices: {sum}");
        }
        private static int Sum_Even_Indices_Recursion_Logic(int[] arr, int index, int sum)
        {
            // TODO: Implement recursive logic
            return sum;
        }
        #endregion

        #region Problem 26 : Find sum of elements at odd indices
        // [10,20,30,40,50] => 60

        /* Iteration */
        public static void Sum_Odd_Indices(int[] arr)
        {
            Print_Array(arr);
            // TODO: Implement logic
        }

        /* Recursion */
        public static void Sum_Odd_Indices_Recursion(int[] arr)
        {
            Print_Array(arr);
            int sum = Sum_Odd_Indices_Recursion_Logic(arr, 1, 0);
            Console.WriteLine($"Sum at Odd Indices: {sum}");
        }
        private static int Sum_Odd_Indices_Recursion_Logic(int[] arr, int index, int sum)
        {
            // TODO: Implement recursive logic
            return sum;
        }
        #endregion

        #region Problem 27 : Find difference between max and min
        // [10,25,3,45,7] => 42

        /* Iteration */
        public static void Diff_Max_Min(int[] arr)
        {
            Print_Array(arr);
            // TODO: Implement logic
        }

        /* Recursion */
        public static void Diff_Max_Min_Recursion(int[] arr)
        {
            Print_Array(arr);
            (int max, int min) = Diff_Max_Min_Recursion_Logic(arr, 0, int.MinValue, int.MaxValue);
            Console.WriteLine($"Difference: {max - min}");
        }
        private static (int max, int min) Diff_Max_Min_Recursion_Logic(int[] arr, int index, int max, int min)
        {
            // TODO: Implement recursive logic
            return (max, min);
        }
        #endregion

        #region Problem 28 : Print unique elements
        // [1,2,2,3,4,4,5] => 1 3 5

        /* Iteration */
        public static void Print_Unique(int[] arr)
        {
            Print_Array(arr);
            // TODO: Implement logic
        }

        /* Recursion */
        public static void Print_Unique_Recursion(int[] arr)
        {
            Print_Array(arr);
            Print_Unique_Recursion_Logic(arr, 0);
        }
        private static void Print_Unique_Recursion_Logic(int[] arr, int index)
        {
            // TODO: Implement recursive logic
        }
        #endregion

        #region Problem 29 : Merge two arrays into a third
        // A=[1,2], B=[3,4] => [1,2,3,4]

        /* Iteration */
        public static void Merge_Arrays(int[] arr1, int[] arr2)
        {
            Print_Array(arr1);
            Print_Array(arr2);
            // TODO: Implement logic
        }

        /* Recursion */
        public static int[] Merge_Arrays_Recursion(int[] arr1, int[] arr2)
        {
            Print_Array(arr1);
            Print_Array(arr2);
            int[] merged = new int[arr1.Length + arr2.Length];
            Merge_Arrays_Recursion_Logic(arr1, arr2, merged, 0, 0, 0);
            return merged;
        }
        private static void Merge_Arrays_Recursion_Logic(int[] arr1, int[] arr2, int[] merged, int i, int j, int k)
        {
            // TODO: Implement recursive merge logic
        }
        #endregion

        #region Problem 30 : Check if array is palindrome
        // [1,2,3,2,1] => Yes (Palindrome)

        /* Iteration */
        public static void Check_Palindrome(int[] arr)
        {
            Print_Array(arr);
            // TODO: Implement logic
        }

        /* Recursion */
        public static void Check_Palindrome_Recursion(int[] arr)
        {
            Print_Array(arr);
            bool isPal = Check_Palindrome_Recursion_Logic(arr, 0, arr.Length - 1);
            Console.WriteLine(isPal ? "Yes (Palindrome)" : "No (Not Palindrome)");
        }
        private static bool Check_Palindrome_Recursion_Logic(int[] arr, int left, int right)
        {
            // TODO: Implement recursive logic
            return true;
        }
        #endregion


        #endregion Array School Level Problem

        #endregion Basic Theory
    }
}
