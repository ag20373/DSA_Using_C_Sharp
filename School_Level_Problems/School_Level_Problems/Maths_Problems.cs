using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace School_Level_Problems.Maths
{
    static class MathsProblem
    {
        #region Problem 1 : Check if a number is prime

        // Prime Number are which divides with itself. 

        public static void Check_IF_Number_IS_Prime_OR_NOT()
        {
            Console.Write("Enter The Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            bool isPrime ;
            while (flag)
            {
                isPrime = true;
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0) // Logic For Prime
                    {
                        isPrime = false;
                        Console.WriteLine("Given Number Is Not Prime ");
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("Given Number Is Prime ");
                }
                Console.Write("Enter The Another Number :  ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                {
                    flag = false;
                }
            }

        }
        #endregion Problem 1 : Check if a number is prime

        #region Problem 2 : Find all prime numbers up to N

        public static void Find_All_Prime_Numbers()
        {
            Console.Write("Enter The Number ,Till Where You Need To find The Prime Number : ");
            int Number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;

            string Primes = "Prime Numbers Are - 1,2,3";
            for(int CurNum = 4 ; CurNum <= Number; CurNum++)
            {
                isPrime = true;
                for(int ChkWith = 2; ChkWith < CurNum; ChkWith++) 
                {
                    if (CurNum % ChkWith == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Primes += "," + CurNum;
                }
            }
            Console.WriteLine(Primes);
        }

        #endregion Problem 2 : Find all prime numbers up to N
       
        #region Problem 3 : Find GCD / HCF Of Two Numbers

        // GCD or HCF : Highest Common Divisor in Two Number .
        // Num 10 and 32 : 10 -> 1 ,2 ,5 ,10 .... 32 -> 1 ,2 ,4 ,8 ,16 ,32
        // Common Divisor :- 1 ,2 
        // GCD :- 2
        // Brutre Force Approach
        public static void GCD_OF_TWO_NUMBER()
        {
            Console.Write("Enter First Number : ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter Second Number : ");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            int MinNumber = Math.Min(Num1, Num2);
            int GCD = 1;

            for(int CurDivisor = 2; CurDivisor <= MinNumber; CurDivisor++)
            {
                if(Num1 % CurDivisor == 0 && Num2 % CurDivisor == 0)
                {
                    GCD = CurDivisor;
                }
            }

            Console.WriteLine("GCD or HCF Of Number is : " + GCD);
        }

        // Same Can Be Solved Using EUCLID_Theorem
        public static void GCD_USING_EUCLID_THEOREM()
        {
            Console.Write("Enter First Number : ");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number : ");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            int GCD = EUCLID_FORMULA_ONE(Num1, Num2);
            Console.WriteLine("GCD of Two Number Using EUCLID_FORMULA_ONE : " + GCD);

            int GCD2 = EUCLID_FORMULA_TWO(Num1, Num2);
            Console.WriteLine("GCD of Two Number Using EUCLID_FORMULA_TWO : " + GCD2);


        }

        // GCD(a, b) =  GCD(a-b, b) ,Where b < a.
        private static int EUCLID_FORMULA_ONE(int num1, int num2)
        {
            int MaxNum = Math.Max(num1, num2);
            int MinNum = Math.Min(num2, num1);
            if (MaxNum != MinNum)
            {
                return EUCLID_FORMULA_ONE(MaxNum - MinNum, MinNum);
            }
            else
            {
                return (MaxNum);
            }
        }
        
        // GCD(a,b) = GCD(b,a%b).
        private static int EUCLID_FORMULA_TWO(int num1, int num2)
        {
            if (num2 == 0)
            {
                return num1;
            }
            else
            {
                return EUCLID_FORMULA_TWO(num2, num1 % num2);
            }
        }

        #endregion Problem 3 : Find GCD Of Two Numbers

        #region Problem 4 : Find LCM of Two Number

        // LCM is Find the Least Number Which Can be Divided By Both Two Number
        // Example : a = 14 , b = 12 -> So Smallest Number Which can be Divided by both A and b is 84.
        // We can Sole this by : 
        // Find the Multiplication of A and B , then Divide it by GCD of (A and B)
        // LCM =  A * B / GCD(A , B);

        public static void LCM_OF_TWO_NUMBER()
        {
            Console.Write("Enter First Number : ");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number : ");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            int Divident = Num1 * Num2;
            int GCD = GCD_EUCLID_Method(Num1, Num2);

            int LCM = Divident / GCD;

            Console.WriteLine("LCM Of Two Number is : "+LCM);
        }

        private static int GCD_EUCLID_Method(int num1, int num2)
        {
            return (num2 == 0 ? num1 : GCD_EUCLID_Method(num2, num1 % num2));
        }

        #endregion Problem 4 : Find LCM of Two Number

        #region Problem 5 : Check if a number is palindrome

        // Palindrome :  A Number is Palindrome , if its reverse is aslo same
        // 121 -->  121

        public static void Check_For_Palindrome()
        {
            Console.Write("Enter Number : ");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            int Check = Num1;
            int rev = 0;
            while(Check != 0) 
            {
                int LastNum = Check % 10;
                rev =rev * 10 + LastNum;
                Check = Check / 10;
            }
            if(rev == Num1)
            {
                Console.WriteLine("Current Number Is Palindrome : " + rev);
            }
            else
            {
                Console.WriteLine("Current Number Is Not Palindrome : " + rev);
            }

        }

        #endregion Problem 5 : Check if a number is palindrome

        #region  Problem 6 : Reverse digits of a number

        public static void Reverse_Digits()
        {
            Console.Write("Enter Number : ");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            int Rev = 0;
            while (Num1 != 0)
            {
                Rev = Rev * 10 + (Num1 % 10);
                Num1 = Num1 / 10;
            }

            Console.WriteLine("Reverse OF Digit is : " + Rev);
        }

        #endregion  Problem 6 : Reverse digits of a number

        #region Problem 7 : Sum of digits of a number

        public static void Sum_Of_Digits()
        {
            Console.Write("Enter Number : ");
            int Num = Convert.ToInt32(Console.ReadLine());

            int Sum = 0;

            while (Num != 0)
            {
                Sum += (Num%10);
                Num /= 10;
            }

            Console.WriteLine("Sum Of Digits Are : "+Sum);
        }

        #endregion Problem 7 : Sum of digits of a number

        #region Problem 8 : Check Armstrong number

        // ArmStrong Example : 
        // 153 => 1^3 + 5^3 + 3^3 
        // 153, 370, 371, 9474, 407, // Armstrong
        // 121, 1331, 456, 999, 100  // Not Armstrong

        public static void IS_ArmStrong(int Num)
        {
            int originalNum = Num;

            // Find the length (number of digits)
            int length = 0;
            int temp = Num;
            while (temp != 0)
            {
                length++;
                temp /= 10;
            }

            // Sum of each digit raised to the power of length
            temp = Num;
            int sum = 0;
            while (temp != 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, length); // Math.Pow returns double, so cast to int
                temp /= 10;
            }

            if (sum == originalNum)
            {
                Console.WriteLine("Number is Armstrong: " + originalNum);
            }
            else
            {
                Console.WriteLine("Number is NOT Armstrong: " + originalNum);
            }
        }

        #endregion Problem 8 : Check Armstrong number

        #region Problme 9 : Factorial of a number

        //Factorial : 5 => 5 * 4 * 3 * 2 * 1. 

        public static void Find_Factorial(int Num)
        {
            BigInteger fact = 1;
            for(int i = 1; i <= Num; i++)
            {
                fact *= i; 
            }

            Console.WriteLine($"Factorial Of Number : {Num} is {fact} ");
        }

        public static BigInteger fact_Recursion(int Num)
        {
            if (Num == 1)
            {
                return Num;
            }
            else
            {
                return Num * fact_Recursion(Num-1);
            }
        }

        #endregion Problem 9 : Factorial of a number
        
        #region Problem 10 : Find factors of a number

        // Factors : Number Divied by all the Lower Numbers
        // 10 => 1 ,2 ,5 ,10 => 1*10 , 2*5 , 5*2 , 10*1
        public static void Find_All_Factors(int Num)
        {
            for(int i = 1;i<= Math.Sqrt(Num); i++)
            {
                if (Num % i == 0) 
                {
                    Console.WriteLine($"Factor of {Num} : {i} ");
                    if(Num/i != i)
                    {
                        Console.WriteLine($"Factor of {Num} : {Num/i} ");
                    }
                }
            }
        }

        #endregion Problem 10 : Find factors of a number

        #region Problem 11 : Count Digits In Number

        public static void Length_Of_Number(int Num)
        {
            int Count = 0;
            int n = Num;
            while (n != 0)
            {
                Count++;
                n /= 10;
            }

            Console.WriteLine($"Length of {Num} is {Count}");
        }

        #endregion Problem 11 : Count Digits In Number

        #region Problem 12 : Nth Fibonacci Number
        // 0 + 1 + 1 + 2 + 3 + 5 + 8 + 13 ..... So On
        // Sum Of Previour Two Number
        public static void Fibnacci_Number(int NthFinNum)
        {
            int Num1 = 0;
            int Num2 = 1;

            var Result = Recusive_FibFormula(Num1, Num2, NthFinNum ,1);
            Console.WriteLine("Fibnacci Number is : " + Result);
        }

        private static BigInteger Recusive_FibFormula(BigInteger Num1 ,BigInteger Num2 ,int NthPosition , int CurrentPosition)
        {
            if (CurrentPosition == NthPosition)
            {
                return Num1; // Return the Fibonacci number at this position
            }
            return Recusive_FibFormula(Num2 , (Num1 + Num2) ,NthPosition ,CurrentPosition+1);
        }

        #endregion Problem 12 : Nth Fibonacci number

        #region Problem 13 : Find The Perfect Number 
        // An Number is perfect if, the sum of all the factor is Equal to number itself
        // 6 => 1 + 2 + 3
        public static void Find_Perfect_Number(int GivenNumber)
        {
            int Sum = 0;
            int OriginalNumber = GivenNumber;
            for(int i = 1; i < Math.Sqrt(GivenNumber); i++)
            {
                if(GivenNumber % i == 0)
                {
                    Sum += i; 
                    if((i != 1) && (i != GivenNumber / i)) 
                    {
                        Sum += GivenNumber / i;
                    }
                }
            }
            if(OriginalNumber != Sum)
            {
                Console.WriteLine($"Given Number {OriginalNumber} is not Perfect ");
            }
            else
            {
                Console.WriteLine($"Given Number {OriginalNumber} is Perfect ");
            }

        }

        #endregion Problem 13 : Find The Perfect Number 

        #region Problem 14 : Sum of first N natural numbers

        // Formula : n(n+1) / 2
        public static void Sum_of_NatualNumbers(int GivenNumber)
        {
            Console.WriteLine($"Sum OF N Natural Number {GivenNumber} are : {(GivenNumber * (GivenNumber + 1)) / 2}");
        }

        #endregion Problem 14 : Sum of first N natural numbers

        #region Problem 15 : Sum of Square of first N Natural Number

        //n(n+1)(2n+1) / 6
        public static void Sum_of_Square_OF_NatualNumbers(int GivenNumber)
        {
            Console.WriteLine($"Sum OF Square of N Natural Number {GivenNumber} are : {(GivenNumber * (GivenNumber + 1) * (2 * GivenNumber + 1)) / 6}");
        }

        #endregion Problem 15 : Sum of Square of first N Natural Number

        #region Problem 16 : Check if the Number is Odd Or Even

        public static void Check_Odd_Even(int GivenNumber)
        {
            if(GivenNumber % 2 == 0)
            {
                Console.WriteLine($"Given Number {GivenNumber} is Even");
            }
            else
            {
                Console.WriteLine($"Given Number {GivenNumber} is Odd");

            }
        }

        #endregion Problem 16 : Check if the Number is Odd Or Even

        #region Problem 17 : Swap two numbers without third variable

        public static void Swap_Two_Number(int num1 ,int num2)
        {
            Console.WriteLine($"Initial Num 1 {num1} && Num 2 {num2}");

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine($"SWAP Num 1 {num1} && Num 2 {num2}");
        }

        #endregion Problem 17 : Swap two numbers without third variable

        #region Problem 18 : Greatest Of Three Number

        public static void Greatest_Three_Num()
        {
            int a = 10;
            int b = 1;
            int c = 20;

            int Greatest = (a > b ? (a > c ? a : c) : (b > c ? b : c));

            Console.WriteLine($"Greatest Of Three Number {a} , {b} , {c} : {Greatest}");
        }

        #endregion Problem 18 : Greatest Of Three Number

    }
}
