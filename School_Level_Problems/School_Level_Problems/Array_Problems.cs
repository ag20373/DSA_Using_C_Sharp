using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Level_Problems.School_Level_Problems
{
    class Array_Problems
    {
        #region Problem 1 : Find largest element in array

        public static void Find_Largest_Element()
        {
            int[] arr = new int[]
            {
                44,23,21,42,521,541,21
            };

            PrintArray(arr);

            int Largest = 0;
            foreach(int item in arr)
            {
                Largest = Largest > item ? Largest : item;
            }
            Console.WriteLine($"Largest Element Is : {Largest}");
        }

        public static void Find_Largest_Element_Using_Recusion()
        {
            int[] arr = new int[]
            {
                44,23,21,42,521,541,21
            };

            PrintArray(arr);

            int Largest = Largest_Recusion(arr ,0 ,0);
            Console.WriteLine($"Largest Element Is : {Largest}");
        }

        private static int Largest_Recusion(int[] arr ,int index ,int Largest)
        {
            if(index == arr.Length - 1)
            {
                return Largest;
            }

            Largest = Largest > arr[index] ? Largest : arr[index];

            return Largest_Recusion(arr,index+1,Largest);
        }

        #endregion Problem 1 : Find largest element in array

        #region Problem 2 : Find smallest element in array

        public static void Find_Smallest_Element()
        {
            int[] arr = new int[]
            {
                44,23,21,42,521,541,21
            };

            PrintArray(arr);

            int Smallest = arr[0];
            foreach (int item in arr)
            {
                Smallest = Smallest < item ? Smallest : item;
            }
            Console.WriteLine($"Smallest Element Is : {Smallest}");
        }

        public static void Find_Smallest_Element_Using_Recusion()
        {
            int[] arr = new int[]
            {
                44,23,21,42,521,541,21
            };

            PrintArray(arr);

            int Smallest = Smallest_Recusion(arr, 0, 0);
            Console.WriteLine($"Smallest Element Is : {Smallest}");
        }

        private static int Smallest_Recusion(int[] arr, int index, int Smallest)
        {
            if(index == arr.Length - 1)
            {
                return Smallest;
            }

            Smallest = Smallest < arr[index] ? Smallest : arr[index];

            return Smallest_Recusion(arr, index + 1, Smallest);
        }

        #endregion Problem 2 : Find smallest element in array

        #region Problem 3 : Sum of elements in array

        public static void Sum_Of_Elements_Array()
        {
            int[] arr = new int[]
            {
                44,23,21,42,521,541,21
            };

            PrintArray(arr);

            int Sum = Sum_Recusion(arr, 0, 0);

            Console.WriteLine($"Sum Of Array : {Sum}");
        }

        private static int Sum_Recusion(int[] arr, int index, int Sum)
        {
            if (index == arr.Length - 1) return Sum;
            Sum += arr[index];

            return Sum_Recusion(arr, index + 1, Sum);
        }

        #endregion Problem 3 : Sum of elements in array

        #region Problem 4 : Avrage Of Elements in Array

        public static void Average_Of_Elements_Array()
        {
            int[] arr = new int[]
            {
                //44,23,21,42,521,541,21
                1,2,3,4,5,6,7,8,9,10
            };

            PrintArray(arr);

            double Sum = Average_Recusion(arr, 0, 0);

            Console.WriteLine($"Average Of Array : {Sum}");
        }

        private static double Average_Recusion(int[] arr, int index, double Sum )
        {
            if(index == arr.Length)
            {
                return (double)(Sum / index);
            }

            Sum += arr[index];
            return Average_Recusion(arr, index + 1, Sum);
        }

        #endregion Problem 4 : Avrage Of Elements in Array

        #region Problem 5 : Reverse An Array

        public static void Reverse_An_Array()
        {
            int[] arr = new int[]
            {
                //44,23,21,42,521,541,21
                1,2,3,4,5,6,7,8,9
            };
            PrintArray(arr);
            for (int i =0 ,j =arr.Length -1;i<j;i++, j--)
            {
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }

            PrintArray(arr);
        }

        public static void Reverse_An_Array_Recusion()
        {
            int[] arr = new int[]
            {
                //44,23,21,42,521,541,21
                1,2,3,4,5,6,7,8,9
            };
            PrintArray(arr);

            Reverse_Logic_Recusion(arr , 0 , arr.Length -1);

            PrintArray(arr);
        }

        private static void Reverse_Logic_Recusion(int[] arr, int LeftIndex, int RightIndex)
        {
            if(LeftIndex > RightIndex)
            {
                return;
            }

            (arr[LeftIndex], arr[RightIndex]) = (arr[RightIndex], arr[LeftIndex]);

            Reverse_Logic_Recusion(arr, LeftIndex+1,RightIndex -1);
        }

        #endregion Problem 5 : Reverse An Array

        #region Problem 6 : Linear Search

        public static void Linear_Serach()
        {
            int[] arr = new int[]
            {
                //44,23,21,42,521,541,21
                1,2,3,4,5,6,7,8,9
            };
            PrintArray(arr);

            int Element = 10;
            bool flag = false;

            foreach(var item in arr)
            {
                if (Element == item) 
                {
                    flag = true;
                    break; 
                }
            }

            if (flag) Console.WriteLine($"Element Present");
            else Console.WriteLine($"Element Not Present");
        }

        #endregion Problem 6 : Linear Search

        #region Problem 7 : Count even and odd numbers

        public static void Count_Even_Odd_Number()
        {
            int[] arr = new int[]
            {
                //44,23,21,42,521,541,21
                1,2,3,4,5,6,7,8,9
            };
            PrintArray(arr);

            (int Even, int odd) = Count_Using_Recusion(arr ,0 , 0 ,0);

            Console.WriteLine($"Even Count : {Even} And Odd Count : {odd}");
        }

        private static (int Even, int odd) Count_Using_Recusion(int[] arr, int index, int Even, int Odd)
        {
            if(index == arr.Length)
            {
                return (Even, Odd);
            }

            (Even,Odd ) = arr[index] % 2 == 0 ? (Even+1,Odd) : (Even,Odd+1);

            return Count_Using_Recusion(arr, index + 1, Even, Odd);
        }

        #endregion Problem 7 : Count even and odd numbers

        #region Problem 8 : Count positive and negative numbers

        public static void Count_nev_Pos_Number()
        {
            int[] arr = new int[]
            {
                //44,23,21,42,521,541,21
                1,2,3,4,5,6,7,8,9
            };
            PrintArray(arr);

            (int nev, int Pov) = Count_Nev_Pov_Recusion(arr, 0, 0, 0);

            Console.WriteLine($"Negative Count : {nev} And Odd Count : {Pov}");
        }

        private static (int Even, int odd) Count_Nev_Pov_Recusion(int[] arr, int index, int Nev, int Pov)
        {
            if (index == arr.Length)
            {
                return (Nev, Pov);
            }

            (Nev, Pov) = arr[index] < 0 ? (Nev + 1, Pov) : (Nev, Pov + 1);

            return Count_Nev_Pov_Recusion(arr, index + 1, Nev, Pov);
        }

        #endregion Problem 8 : Count positive and negative numbers

        #region Problem 9 : Find second largest element

        public static void Second_Largest()
        {
            int[] arr = new int[]
            {
                //44,23,21,42,521,541,21
                1,2,3,4,5,6,7,8,9
            };
            PrintArray(arr);

            (int firstLargest, int SecondLargest) = secd_Smallest_Recussion(arr, 0 ,int.MinValue ,int.MinValue);
            
            //int firstLargest = arr[0] > arr[1] ? arr[0] : arr[1];
            //int SecondLargest = arr[0] < arr[1] ? arr[0] : arr[1];

            /*for(int i = 2; i < arr.Length; i++)
            {
                if(arr[i] > firstLargest)
                {
                    SecondLargest = firstLargest;
                    firstLargest = arr[i];
                }
                else if (arr[i] > SecondLargest && arr[i] < firstLargest)
                {
                    SecondLargest = arr[i];
                }
            }*/

            Console.WriteLine($"Largest : {firstLargest} , 2nd Largest : {SecondLargest}");
        }

        private static (int firstLargest, int SecondLargest) secd_Smallest_Recussion(int[] arr, int index, int first, int second)
        {
            if(index == arr.Length)
            {
                return (first, second);
            }
            if (arr[index] > first)
            {
                second = first;
                first = arr[index];
            }
            else if (arr[index] > second && arr[index] < first)
            {
                second = arr[index];
            }
            return secd_Smallest_Recussion(arr, index + 1, first, second);
        }

        #endregion Problem 9 : Find second largest element

        #region Problem 10 : Find Second Smallest Element

        public static void Second_Smallest()
        {
            int[] arr = new int[]
            {
                //44,23,21,42,521,541,21
                1,2,3,4,5,6,7,8,9
            };
            PrintArray(arr);

            (int firstSmallest, int SecondSmallest) = secd_Smallest(arr, 0, int.MaxValue, int.MaxValue);

            Console.WriteLine($"Smallest : {firstSmallest} , 2nd Smallest : {SecondSmallest}");
        }

        private static (int firstSmallest, int SecondSmallest) secd_Smallest(int[] arr, int index, int smallest, int secondSmallest)
        {
            if (arr.Length == index)
            {
                return (smallest, secondSmallest);
            }

            if(arr[index] < smallest)
            {
                secondSmallest = smallest;
                smallest = arr[index];
            }
            else if (arr[index] < secondSmallest && arr[index] > smallest)
            {
                secondSmallest = arr[index];
            }

            return secd_Smallest(arr, index + 1, smallest, secondSmallest);
        }

        #endregion Problem 10 : Find Second Smallest Element

        private static void PrintArray(int[] arr)
        {
            Console.Write("Array Elements Are : ");
            foreach (int item in arr)
            {
                Console.Write($"{item} , ");
            }
            Console.WriteLine();
        }
    }
}
