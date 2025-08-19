using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace School_Level_Problems.School_Level_Problems
{
    static class String_Problems
    {
        #region String Theory
        public static void string_Theory()
        {
            #region 1. Core Fundamentals
            /*
             * 1.1 String Basics
             * -> Type : string in C# is an alias for system.string.
             * -> Immutable : Once Created, You cannot change the contents of a string. Any peartion that appears to modify it actually crates a new string in memory
             * -> Reference Type : strings are reference types, but behaves like value types for equality and assignment (due to immutability)
             * Unicode: Strings are UTF-16 encoded sequences of char.
             */

            string s1 = "Hello";
            string s2 = s1; // Points to same Object
            s1 += "World"; // Creates a new string 

            #endregion 1. Core Fundamentals

            #region 2. Common Operations

            /*
             * 2.1 Concatenation
             * -> + operator or string.Concat()
             * -> string.join() for combining multiple strings with a separator.
             * -> StringBuilder for heavy concatenation in loops.
             */
            string result = "Hello" + " " + "World";

            /*
             * 2.2 Interpolation
             */
            string name = "Amit";
            string message = $"Hello, {name}! Today is {DateTime.Now:dddd}";

            /*
             * 2.3 Formatting
             */

            string.Format("Value: {0}, Date: {1:yyyy-MM-dd}", 42, DateTime.Now);

            #endregion 2. Common Operations

            #region 3. String Comparison & Equality

            /*
             * 3.1 Methods
             * -> Equals()
             * -> == operator
             * -> string.Compare() / string.CompareOrdinal()
             * 
             * 3.2 Case Sensitivity
             * string.Equals("hello", "HELLO", StringComparison.OrdinalIgnoreCase);
             * -> Ordinal: Fast, compares Unicode code points.
             * -> InvariantCulture: Useful for case-insensitive comparisons in a culture-agnostic way.
             * -> CurrentCulture: Uses system locale rules (avoid in data matching).
             */

            #endregion 3. String Comparison & Equality

            #region 4. Indexing and Substrings

            string text = "abcdef";
            char c = text[2]; // 'c'
            string part = text.Substring(2, 3); //"cde"

            // Range and Index (C# 8+)
            //string last3 = text[^3..]; // "def"

            #endregion 4. Indexing and Substrings

            #region 5. Searching

            string s = "Hello World";
            bool contains = s.Contains("World");
            int idx = s.IndexOf("World");
            bool starts = s.StartsWith("He");
            bool ends = s.EndsWith("ld");

            #endregion 5. Searching

            #region 6. Modification - Like Opeartions(Return New String)

            //Replace(oldValue, newValue)
            //ToUpper(), ToLower()
            //Trim(), TrimStart(), TrimEnd()
            //PadLeft(), PadRight()
            //Remove(startIndex, count)

            #endregion 6. Modification - Like Opeartions(Return New String)

            #region 7. Splitting & Joining

            string data = "one,two,three";
            string[] parts = data.Split(',');
            string joined = string.Join(" | ", parts);

            #endregion 7. Splitting & Joining

            #region 8. Null vs Empty vs WhiteSpace

            //string.Empty // ""
            //null // no instance
            //string.IsNullOrEmpty(str)
            //string.IsNullOrWhiteSpace(str)

            #endregion 8. Null vs Empty vs WhiteSpace

            #region 9. Permormance Considerations
            {
                // 9.1 Immutability
                // Bad.
                string ss = "";
                for (int i = 0; i < 1000; i++) s += i; // creates 1000+ objects

                // Good.
                var sb = new StringBuilder();
                for (int i = 0; i < 1000; i++) sb.Append(i);
                string result1 = sb.ToString();

                // Interning
                // -> Identical string literals are stored once in memory.

                string a = "hello";
                string b = "hello";
                object.ReferenceEquals(a, b); // true
            }

            #endregion 9. Performance Considerations


        }

        public static void Interview_String_Questions()
        {
            #region Basics
            // Q1: What is a string in C# and how is it represented internally?
            // Ans : A string is a sequence of char values, represnted internally as UTF-16 encoded characters. Each char is 2 bytes, meaning it can represent Unicode Charaters Directly
            string text = "Hello"; // 'H' 'e' 'l' 'l' 'o'

            // Q2 : Is string a reference type or value type? Why does it sometimes behave like a value type?
            // Ans : It's a reference Type , but immutability makes it behaves like a value type in equality.
            string a = "Hi";
            string b = a;
            a += " There"; // b remains "Hi"

            // Q3 : Are String mutable or Immutable ?
            // Ans : Immutable - Any Chnage creayes a new string.
            string s = "Hello";
            s += " World"; // New string created

            // Q4 : Difference in string and System.String?
            // Ans : No Difference, string is an alias for System.String.

            string a1 = "hi";
            System.String b1 = "hi";
            Console.WriteLine(a1 == b1); // True

            // Q5 : What encoding is used by Strings in C# ?
            // Ans : UTF - 16 encoding.

            char c = 'A'; // 0x0041 in UTF-16



            #endregion Basics

            #region Memory And Performace

            // Q6 : What is string interning ?
            // Ans : Storing identical strings once in memory.
            string a2 = "hello";
            string b2 = "hello";
            Console.WriteLine(object.ReferenceEquals(a2, b2)); // True

            // Q7 : How are string literals stored in memory ?
            // Ans : In the intern pool on the managed heap.

            // Q8 : Differnce between string.Empty and null
            // Ans : string.Empty; means ("") , null is null

            // Q9 : How Does + Concatenation works?
            // Ans : Creates a new string each time.
            string s3= "A";
            s3 += "B"; // New object created

            // Q10 : Why use StringBuilder ?
            // Ans : Efficient for repeated Concenation , Dont create a new Object but modify the same one again
            var sb = new StringBuilder();
            for (int i = 0; i < 1000; i++) sb.Append(i);
            string result = sb.ToString();



            #endregion Memory And Performace

            #region Comparison And Equality

            // Q11 : How Does == compare strings?
            // Ans : Compares Values , not references.
            string a3 = "test";
            string b3= new string(new[] { 't', 'e', 's', 't' });
            Console.WriteLine(a3 == b3); // True

            // Q12 : Difference between == and Equals()?
            // Ans : 
            string a4 = "HELLO";
            string b4 = "hello";
            Console.WriteLine(a4 == b4); // False
            Console.WriteLine(a4.Equals(b4, StringComparison.OrdinalIgnoreCase)); // True

            // Q13 :  Ordinal vs CurrentCulture?
            // Ans : 
            string a5 = "file";
            string b5 = "FILE";
            Console.WriteLine(a5.Equals(b5, StringComparison.OrdinalIgnoreCase)); // True
            Console.WriteLine(a5.Equals(b5, StringComparison.CurrentCultureIgnoreCase)); // True, but culture-based

            // Q14 : Case - insensitive comparison ?
            // Ans : 
            string.Equals("hi", "HI", StringComparison.OrdinalIgnoreCase); // True

            // Q15 : Why avoid culture - sensitive comparisons ?
            // Ans : Turkish i problem.
            //CultureInfo tr = new CultureInfo("tr-TR");
            //Console.WriteLine("I".ToLower(tr)); // "ı" (dotless i)

            #endregion Comparison And Equality

            #region String Operations

            // Q16 : What happens in Substring()?
            // Ans : 
            string s1 = "abcdef";
            string sub = s1.Substring(2, 3); // "cde"

            // Q17 : Replace() Vs Remove() ?
            // Ans : 
            string s2 = "abcdef";
            Console.WriteLine(s2.Replace("cd", "XY")); // abXYef
            Console.WriteLine(s2.Remove(2, 3)); // abf

            // Q18 : How does Split() work?
            // Ans : 
            // string s4 = "a,b,,c";
            // var parts = s4.Split(',', System.StringSplitOptions.RemoveEmptyEntries);
            // ["a", "b", "c"]

            // Q19 : StartsWith() & EndsWith()?
            // Ans : 
            "hello".StartsWith("he"); // True
            "hello".EndsWith("lo"); // True

            // Q20 : How does Trim() work?
            // Ans :
            "  hello  ".Trim(); // "hello"
            "xyhelloxy".Trim('x', 'y'); // "hello"


            #endregion String Operations

            #region Advanced Features

            // Q21 : Verbatim string literal?
            // Ans : 
            string path = @"C:\Users\Amit";

            // Q22 : Raw string literal(C# 11)?
            // Ans : 
            //string json = """
            //{
            //    "name": "Amit"
            //}
            //""";

            // Q23 : Escape sequences ?
            // Ans : 
            string s4 = "Line1\nLine2\tTabbed";

            // Q24 : ReadOnlySpan<char> usage?
            // Ans : ReadOnlySpan<char> span = "Hello".AsSpan(1, 3); // "ell"

            // Q25 : String normalization ?
            // Ans : 
            string s5 = "é";
            string s6 = "e\u0301"; // 'e' + accent
            Console.WriteLine(s5.Equals(s6)); // False
            Console.WriteLine(s5.Normalize() == s6.Normalize()); // True


            #endregion Advance Features

            #region Special Cases and Pitfalls

            // Q26 : Immutability in multithreading?
            // Ans : Strings are Thread - Safe To read because they are never change.

            // Q27 : Same Hash code possible? 
            // Ans : 
            string a6 = "Aa";
            string b6 = "BB";
            Console.WriteLine(a6.GetHashCode() == b6.GetHashCode()); // Possible collision

            // Q28 : IsNullOrEmpty() Vs IsNullOrWhiteSpace() ?
            // Ans : 
            string.IsNullOrEmpty(" "); // False
            string.IsNullOrWhiteSpace(" "); // True

            // Q29 : Performance issue with concatenation?
            // Ans : 
            string s7 = "";
            for (int i = 0; i < 1000; i++) s7 += i; // Bad: many allocations

            // Q30 : Why SecureString deprecated?
            // Ans : Microsoft suggests encryption instead of SecureSting.

            #endregion Special Cases and Pitfalls

            #region Real - World Scenarios 

            // Q31 : Store large text efficiently ?
            // Ans : StringBuilder sb = new StringBuilder(100000);

            // Q32 : Globalization/localization impact?
            // Ans : "color".Equals("colour", StringComparison.InvariantCulture); // False

            // Q33 : ToLower()/ToUpper() issues?
            // Ans : 
            // CultureInfo tr = new CultureInfo("tr-TR");
            // Console.WriteLine("I".ToLower(tr)); // "ı" (dotless i)

            // Q34 : Compare strings with culture ?
            // Ans : 
            // CultureInfo culture = new CultureInfo("en-US");
            // string.Compare("apple", "Apple", true, culture); // 0

            // Q35 : Prevent SQL Injection ?
            // Ans : Use parameterized queries instead of concatenation.

            #endregion Real - World Scenarios 

            
        }

        #endregion String Theory

        #region String_School_Level_Problems

        #region Problem 1 : Reverse a string

        // Convert To Char Array -> Array.Reverse -> Convert Array To String. 
        // Simple, efficient, and widely accepted.
        public static void Reverse_Classic_Approach()
        {
            string OgString = "Amit";
            string OgReverse = string.Empty;

            char[] OgCharArray = OgString.ToCharArray();
            Array.Reverse(OgCharArray);
            OgReverse = new string(OgCharArray);

            Console.WriteLine($"Reverse_Classic_Approach  {OgString} : {OgReverse} ");
        }

        // For Loop Start from 0 and Last Element -> Swap Both.
        // Shows understanding of array manipulation.
        public static void Reverse_Using_ForLoop_Manual_Swap()
        {
            string input = "Amit";
            Char[] arry = input.ToCharArray();

            for(int i =0 , j = arry.Length-1; i<j;i++, j--)
            {
                (arry[i], arry[j]) = (arry[j], arry[i]);
            }

            Console.WriteLine($"Reverse_Using_ForLoop_Manual_Swap {input} : {new string(arry)}");
        }

        // Iterate a char array from Last and Append each to stringbuilder
        // Good for interviews if asked about StringBuilder vs String.
        public static void Reverse_Using_StringBuilder()
        {
            string input = "Amit";
            var sb = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            Console.WriteLine($"Reverse_Using_StringBuilder {input} : {sb.ToString()}");
        }

        // Concise, but less performant for huge strings.
        public static void Reverse_Using_LINQ()
        {
            string input = "Amit";
            string reversed = new string(input.Reverse().ToArray());

            Console.WriteLine($"Reverse_Using_LINQ {input} : {reversed}");
        }

        // Using Recursion
        public static void Reverse_Using_Recursion()
        {
            string result = ReverseString("Amit");
            Console.WriteLine($"Reverse_Using_Recursion {"Amit"} : {result}");
        }

        // Send Substring from Length = 1 , Add To 0th Posiiton.
        private static string ReverseString(string s) 
        {
            // Only One Element Remain
            if (s.Length <= 1)
                return s;

            // Send a Substring And Separete first Element
            return ReverseString(s.Substring(1) + s[0]);

            // Working 
            // 1. MIT - Send + A 
            // 2. IT - Send + M
            // 3. T - Send + I
            // 4. Return T
            // 5. Return (T + I)
            // 6. Return (TI + M)
            // 7. Return (TIM + A)
            // 8. Result = TIMA .
        }

        #endregion Problem 1 : Reverse a string

        #region Problem 2 : Check if string is palindrome

        public static void CheckForPalindrome_Using_LINQ()
        {
            string Original = "M O M ";
            string input = Original;

            string reverse = new String(input.Reverse().ToArray());

            if(Original == reverse) 
            {
                Console.WriteLine($"String {Original} is Plaindrome {reverse}");
            }
            else
            {
                Console.WriteLine($"String {Original} is Not Plaindrome {reverse}");
            }

        }

        public static void CheckForPalindrome_Using_ForLoop()
        {
            string Original = "MOM";
            string input = Original;

            char[] arr = input.ToCharArray();

            for(int i =0 ,j =arr.Length-1; i<j;i++, j--)
            {
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }

            string reverse = new string(arr);

            if (Original == reverse)
            {
                Console.WriteLine($"String {Original} is Plaindrome {reverse}");
            }
            else
            {
                Console.WriteLine($"String {Original} is Not Plaindrome {reverse}");
            }


        }

        public static void CheckForPalindrome_Using_Recursion() 
        {
            string Original = "AMIT";
            string input = Original;

            string reverse = Recursion_Logic(input);

            if (Original == reverse)
            {
                Console.WriteLine($"String {Original} is Plaindrome {reverse}");
            }
            else
            {
                Console.WriteLine($"String {Original} is Not Plaindrome {reverse}");
            }
        }

        private static string Recursion_Logic(string input)
        {
            if(input.Length <= 1)
            {
                return input;
            }
            return Recursion_Logic(input.Substring(1)) + input[0];
        }

        #endregion Problem 2 : Check if string is palindrome

        #region Problem 3 : Count vowels and consonants

        /* 
         * Use char.IsLetter() to filter out non - aphabetic characters.
         * Normalize case using .ToLower() or .ToUpper().
         * Define vowels (a, e, i, o, u); everything else is a consonant. 
        */
        public static void Count_Vowels_consonants()
        {
            string input = "Hello World";

            int Vowels = 0;
            int consonants = 0;

            foreach(char ch in input.ToLower())
            {
                if (char.IsLetter(ch))
                {
                    if ("aeiou".Contains(ch))
                    {
                        Vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }

            Console.WriteLine($"Vowels: {Vowels}, Consonants: {consonants}");
        }

        public static void Optimized_Count_Vowels_consonants()
        {
            string input = "Hello World 123!";
            int vowels = 0, consonants = 0;

            foreach (char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    switch (char.ToLower(ch))
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            vowels++;
                            break;
                        default:
                            consonants++;
                            break;
                    }
                }
            }

            Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
        }

        /* Info
         * Time Complexity : O(n) -> Have To scan the Whole String Once
         * Space Complexity : O(1) ->  Only Counter Used.
         * Why Switch Better : Avoids extra allocations ("aeiou".Contains()) 
        */

        /* Edge Cases
         * 1. Spaces -> Should be Ignored
         * 2. Digits & Special Charaters -> not vowels or consonants, so skip them.
         * 3. Upper vs Lower Case → normalize (ToLower() / ToUpper()).
         * 4. Unicode Letters (like ä, é, ñ) → char.IsLetter() detects them, but "aeiou" check won’t. If interviewer asks, you can mention culture-specific handling with System.Globalization.
        */

        /* Using LINQ
         * Time Complexity : Still O(n) but less efficeint than the switch version (because of multiple passes and .Contains() lookups).
         * Space Complexity : Higher than the loop solution (LINQ creates iterators and lambdas)
         * Best Usage: For readability in small strings; not for high-performance scenarios.
         */
        public static void Using_LINQ_Count_Vowels_consonants()
        {
            string input = "Hello World 123!";
            int vowels = input.Count(c => "aeiouAEIOU".Contains(c) && char.IsLetter(c));
            int consonants = input.Count(c => char.IsLetter(c) && !"aeiouAEIOU".Contains(c));
            Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
        }

        /* Handling Unicode Vowels (Culture-Specific)
         * By default "aeiou" won’t catch accented vowels like ä, é, í, ö, ü.
         * We can handle them using System.Globalization → normalize the string, strip diacritics, and then check vowels.
         */
        public static void Culture_Aware_Vowel_Counting()
        {
            string input = "Héllo Wörld! naïve façade";
            int vowels = 0, consonants = 0;

            foreach(char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    string normalized = ch.ToString().Normalize(NormalizationForm.FormD);
                    char baseChar = normalized[0];

                    if ("aeiouAEIOU".Contains(baseChar))
                        vowels++;
                    else
                        consonants++;
                }
            }

            Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
        }
        
        /* Algorithm
         * 1. Call the Method again and again till we reach the length of String , then Return 0 for Both variable.
         * 2. Pull Out the Latest index from the stack , Check if it is Letter or not
         * 3. If , Yes check for Vowels and consonants and add one to either one of these --- else return Vowels and consonants
         * 
         * Stack Formation
         * Top = Last Index , Last = 0 Index
         * So, Logic will Work for Last Index First...
         * Example : Hello
         * 1 -> O , 2 -> l , 3 -> l , 4 -> e , 5 -> H  
         */
        public static void Count_Vowels_Consonants_Using_Recusion()
        {
            string input = "Hello World";
            (int vowels, int consonants) = CountRecursive(input, 0);

            Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
        }
        private static (int vowels, int consonants) CountRecursive(string input, int index)
        {
            // Return 0 ... when index is equal to string Length
            if(input.Length == index)
            {
                return (0, 0);
            }

            // Call Recursion Till We Reach Length of String
            (int Vowel, int consonants) = CountRecursive(input, index + 1);

            // Starts with Last index 
            // Check if Letter , Then Add one to Respective Variable
            char ch = char.ToLower(input[index]);
            if (char.IsLetter(ch))
            {
                if ("aeiou".Contains(ch))
                {
                    return (Vowel + 1, consonants);
                }
                else
                {
                    return (Vowel, consonants+1);
                }
            }

            // Return When non Letter...
            return (Vowel, consonants);
        }

        #endregion Problem 3 : Count vowels and consonants

        #region Problem 4 : Count uppercase and lowercase letters

        public static void Count_UpperCase_LowerCase()
        {
            string input = "Amit$ %123";
            int upper = 0;
            int lower = 0;

            foreach(char ch in input) 
            {
                if (char.IsLetter(ch))
                {
                    if (char.IsLower(ch))
                    {
                        lower++;
                    }
                    else
                    {
                        upper++;
                    }
                }
            }

            Console.WriteLine($"Upper : {upper} and Lower : {lower}");
        }

        public static void Count_UpperCase_LowerCase_Using_LINQ()
        {
            string input = "Amit$ %123";
            int upper = input.Count(c=>char.IsUpper(c) && char.IsLetter(c));
            int lower = input.Count(c => char.IsLower(c) && char.IsLetter(c));

            Console.WriteLine($"Upper : {upper} and Lower : {lower}");
        }

        public static void Count_UpperCase_LowerCase_Using_Recursion()
        {
            string input = "Amit$ %123";
            (int upper, int lower) = Recursion_Logic_U_and_L(input ,0);

            Console.WriteLine($"Upper : {upper} and Lower : {lower}");
        }

        private static (int upper, int lower) Recursion_Logic_U_and_L(string input, int index)
        {
            if(input.Length == index)
            {
                return (0, 0);
            }
            
            (int upper, int lower) = Recursion_Logic_U_and_L(input, index + 1);

            char ch = (input[index]);

            if (char.IsLetter(ch))
            {
                if (char.IsUpper(ch))
                {
                    return (upper + 1, lower);
                }
                else
                {
                    return (upper , lower+1);
                }
            }

            return (upper, lower);
        }

        #endregion Problem 4 : Count uppercase and lowercase letters

        #region Problem 5 : Count digits in a string

        public static void Count_Digit()
        {
            string input = "Amit$ %123";
            int Digit = 0;

            foreach (char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    Digit++;
                }
            }

            Console.WriteLine($"Digits in {input} : {Digit}");
        }

        public static void Count_Digit_LINQ()
        {
            string input = "Amit$ %123";
            int Digit = input.Count(c => char.IsDigit(c));

            Console.WriteLine($"Digits in {input} : {Digit}");
        }
        public static void Count_Digit_Recusrion()
        {
            string input = "Am423it$ %123243";
            int Digit = recusion_Digit(input, 0);

            Console.WriteLine($"Digits in {input} : {Digit}");
        }

        private static int recusion_Digit(string input, int index)
        {
            if(input.Length == index)
            {
                return 0;
            }

            int digit = recusion_Digit(input, index + 1);

            char ch = input[index];
            
            if (char.IsDigit(ch)) return digit + 1;

            return digit;
        }

        #endregion Problem 5 : Count digits in a string

        #region Problem 6 : Remove all spaces from string

        /* Brute Force Approach (String Concatenation)
         * 1. Time : O(n^2) Bcoz every += creates a new strings.
         * 2. Space : O(n^2) Multiple intermediate strings.
         * 3. Never use += in loops for strings; too costly.
         */
        public static void SpaceRemove_BruteForce()
        {
            string input = "Am itG up ta ";
            string result = "";

            foreach(char ch in input)
            {
                if(ch!=' ') 
                {
                    result += ch; // Costly due to immutablitty
                }
            }
            Console.WriteLine($"Result : {result}");
        }

        /* Optimized Approach (StringBuilder)
         * 1. Time : O(n) single pass , efficient
         * 2. Space : O(n) Only final string + small Buffer.
         * 3. Use StringBuilder when modifying strings inside loops.
         */
        public static void SpaceRemove_Optimal()
        {
            string input = "Am itG up ta ";
            StringBuilder result = new StringBuilder();

            foreach (char ch in input)
            {
                if (ch != ' ')
                {
                    result.Append(ch); 
                }
            }
            Console.WriteLine($"Result : {result}");
        }

        /* LINQ Approach 
         * Time  : O(n) but with iterator + lambda overhead.
         * Space : O(n) array + new string
         * More elegant/readable, but slightly slower than StringBuilder.
         */
        public static void SpaceRemove_LINQ()
        {
            string input = "Am itG up ta ";
            string result = new string (input.Where(x => x != ' ').ToArray());

            Console.WriteLine($"Result : {result}");
        }

        /* Using Regex Approach
         * Time: O(n) (regex engine still scans the string once).
         * Space: O(n) → for the result string.
         * Use \s to remove all whitespace (not just spaces).
         * Regex has overhead → not best for performance-critical code, but excellent for readability.
         */
        public static void SpaceRemove_Regex()
        {
            string input = "Am itG up ta ";

            // removes all whitespace (spaces, tabs, newlines)
            string result = Regex.Replace(input, @"\s+", "");

            Console.WriteLine($"Result : {result}");
        }

        /* Recursion Approach
         * Time: O(n²) → string concatenation at each recursion step.
         * Space: O(n) recursion stack + O(n²) due to concatenations.
         * Shows recursion knowledge, but impractical.
         */
        public static void SpaceRemove_Recursion()
        {
            string input = "Am itG up ta ";

            string result = RemoveSpacesRecursive(input, 0);

            Console.WriteLine($"Result : {result}");
        }

        /* Logic 
         * 1. Itertate Till Lenght and Return "" as Rest;
         * 2. Combine current With Rest Return it , But if Combined Contain ' ' return rest ,
         * Example : inp ut
         * 1. Current = i 
         * 2. Current = n
         * 3. Current = p 
         * 4. Current = ' '
         * 5. Current = u
         * 6. Current = t
         * 7. return ""  
         * 8. Combine Current + Rest => t + "" => Return t
         * 9. Combine u + t => Return ut
         * 10. Combined ut (Current is ' ') => Return ut
         * 11. Combined p + ut  => Return put
         * 12. Combined n + put  => Return nput
         * 13. Combined i + nput => input.
         * 
         */
        private static string RemoveSpacesRecursive(string input, int index)
        {
            if(input.Length == index)
            {
                return "";
            }

            // Current Character in Stack.
            char current = input[index];

            // Substring Ahead From Current
            // If Input is AMIT ,Current is "M" , then Rest is "IT"
            string Rest = RemoveSpacesRecursive(input, index + 1);  

            return current == ' ' ? Rest : current + Rest ;

        }


        #endregion Problem 6 : Remove all spaces from string

        #region Problem 7 : Find frequency of each character

        /* Brute Force Approach
         * Time : O(n^2) 
         * Space : O(1)
         * Shows naive thinking; not efficient for large strings
         */
        public static void Find_Frequency_Brute_Force()
        {
            string input = "Amit Gupta";
            for(int i = 0; i < input.Length; i++)
            {
                if (input.Substring(0, i).Contains(input[i]))
                {
                    continue;
                }

                int count = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                        count++;
                }

                Console.WriteLine($"{input[i]} : {count}");
            }
        }

        /* Optimal Solution Using Dictionary
         * Time Complexity : O(n)
         * Space Complexity : O(K) - Unique Characters
         * Best real-world solution.
         */
        public static void Find_Frequency_Optimal_Solution()
        {
            string input = "Amit Gupta133 ^%3@";
            string InputwithoutSpace = Regex.Replace(input, @"\s+", "");
            Dictionary<char, int> Frequency = new Dictionary<char, int>();

            foreach(char ch in InputwithoutSpace.ToLower())
            {
                
                if (char.IsLetter(ch))
                {
                    if (Frequency.ContainsKey(ch))
                        Frequency[ch]++;
                    else
                        Frequency[ch] = 1;
                }
            }

            foreach (var kv in Frequency)
                Console.WriteLine($"{kv.Key} : {kv.Value}");
        }

        /* LINQ Solution 
         * Time : O(n)
         * Space : O(K)
         * Slightly Overhead compared to dictionary approach bcoz of GroupBy
         */
        public static void Find_Frequency_Linq_Solution()
        {
            string input = "Amit Gupta133 ^%3@";

            var Frequecy = input.ToLower().Where(x => char.IsLetter(x)).GroupBy(x => x).Select(x => new { Char = x.Key, Count = x.Count() });

            foreach (var item in Frequecy)
                Console.WriteLine($"{item.Char} : {item.Count}");
        }

        /* Recusrsion Logic 
         * Time : O(n)
         * Space : O(n + K) K for Dectionary , N For Stack
         * Shows recursion understanding.
         */
        public static void Find_Frequency_Recursion_Solution()
        {
            string input = "amitgupta";
            Dictionary<char, int> Frequency = Dictionary_Frequency_Logic(input ,0 ,null);

        }
        private static Dictionary<char, int> Dictionary_Frequency_Logic(string input, int index ,Dictionary<char,int> freq)
        {
            // Check If Freq is Null
            if(freq == null)
            {
                freq = new Dictionary<char, int>();
            }

            // If Index is Equal To input Length
            if(index == input.Length)
            {
                // Last Result ,till This Freq is being Filled with Frequcy of Character
                return freq;
            }

            char c = input[index];
            if (freq.ContainsKey(c))
                freq[c]++;
            else
                freq[c] = 1;

            return Dictionary_Frequency_Logic(input, index + 1, freq);
        }

        #endregion Problem 7 : Find frequency of each character

        #region Problem 8 : Check anagram strings
        // Anagram String are those which has same frequency and Character But Different Order.
        //"listen" & "silent" → ✅ Anagrams
        //"hello" & "world" → ❌ Not anagrams

        /* Brute Force And Linq 
         * Time : O(nLogn) (due to sorting)
         * Space : O(n) new object creation
         */
        public static void IsAnagram_Brute_Linq_Force()
        {
            string s1 = "amitgupta";
            string s2 = "mitauptga";

            s1 = new string(s1.ToLower().Where(char.IsLetter).OrderBy(c => c).ToArray());
            s2 = new string(s2.ToLower().Where(char.IsLetter).OrderBy(c => c).ToArray());

            if (s1 == s2)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Anagram");
            }
        }

        /* Optimal Soution Using Dictonary
         * Algo : Fill the Dictory with String 1 , Then Remove the Char from dictonary using String 2 , If Count is 0 ,then it is anagram
         * Time : O(N)
         * Space : O(K) (Unique Chars).
         */
        public static void IsAnagram_Optimal_Solution()
        {
            string s1 = "amitgupta";
            string s2 = "mitauptga";

            if (s1.Length != s2.Length)
            {
                Console.WriteLine("Not a Anagram");
            }

            Dictionary<char, int> freq = new Dictionary<char, int>();

            #region Logic 

            // Iterate String One Add to Dictonary 
            foreach (char c in s1)
            {
                if (freq.ContainsKey(c)) freq[c]++;
                else freq[c] = 1;
            }

            // Then Itreate String Two Remove from Dictonary
            foreach (char c in s2)
            {
                if (!freq.ContainsKey(c)) break;
                freq[c]--;
                if (freq[c] == 0) freq.Remove(c);
            }

            // Check For Count ,if Zero ,then anagram else not

            if (freq.Count == 0)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not a Anagram");
            }
            #endregion Logic
        }

        
        /* Using Recursion
         * Time : O(n^2)
         * Space : O(n)
         */
        public static void IsAnagram_Using_Recusrion()
        {
            string s1 = "amitgupta";
            string s2 = "mitauptga";

            bool IsAnagram = AreAnagrams_Recursive(s1 ,s2);
        }

        private static bool AreAnagrams_Recursive(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;
            if (s1.Length == 0) return true;

            // Get The First Character from s1
            char First = s1[0];

            // Get the index of First char from s2
            int index = s2.IndexOf(First);

            // if Char not exsit in S2 return false
            if (index == -1) return false;

            // if char exisit ,Remove the char from both string.
            return AreAnagrams_Recursive(s1.Substring(1), s1.Remove(index, 1));
        }

        #endregion Problem 8 : Check anagram strings

        #region Problem 9 : Convert string to uppercase

        // Using Build In 
        // input.ToUpper();
        // "Hello World äéñ" --> "HELLO WORLD ÄÉÑ"

        // Using Build In Culture Aware Uppercase
        // input.ToUpper(new CultureInfo("tr-TR"));
        // "i̇stanbul" --> "İSTANBUL"

        // Time And Space : O(N)
        // ToUpper() -> Uses current culture.
        // ToUpperInvariant() → Uses invariant culture (consistent, better for system-level ops).

        // Manual Logic
        //if (c >= 'a' && c <= 'z')
        //    result[i] = (char) (c - 32); // ASCII shift
        //else
        //    result[i] = c;

        #endregion Problem 9 : Convert string to uppercase

        #region Problem 10 : Convert String To LowerCase

        // Using Build In 
        // input.ToLower();
        // "hello world äéñ" <-- "HELLO WORLD ÄÉÑ"

        // Using Build In Culture Aware Uppercase
        // input.ToLower(new CultureInfo("tr-TR"));
        // "i̇stanbul" <-- "İSTANBUL"

        // Time And Space : O(N)
        // ToLower() -> Uses current culture.
        // ToLowerInvariant() → Uses invariant culture (consistent, better for system-level ops).

        //char c = input[i];
        //if (c >= 'A' && c <= 'Z')
        //    result[i] = (char) (c + 32); // ASCII shift
        //else
        //    result[i] = c;

        #endregion Problem 10 : Convert String To LowerCase

        #region Problem 11 : Length of String Without Inbuild

        // 1. Using Foreach Loop
        // 2. Using Linq -> input.Count();

        #endregion Problem 11 : Length of String Without Inbuild

        #region Problem 12 : Replace all vowels with a given character
        // Time And Space : O(N)
        public static void Repalce_Char_With_Vowel()
        {
            string input = "Amit Gupta";
            char letter = 'b';
            StringBuilder output = new StringBuilder();
            foreach (char ch in input.ToLower())
            {
                switch (ch)
                {
                    case 'a':
                    case 'e':
                    case 'o':
                    case 'i':
                    case 'u':
                        output.Append(letter);
                        break;
                    default:
                        output.Append(ch);
                        break;
                }
            }

            Console.WriteLine($"{input} = {output}");
        }

        // Time and Space : O(n).
        // Slightly less efficient than StringBuilder because of ToArray().
        public static void Replace_Char_With_Vowel_Using_LINQ()
        {
            string input = "Amit Gupta";
            char letter = 'b';

            string output = new string(input.Select(ch => "aeiouAEIOU".Contains(ch) ? letter : ch).ToArray());

            Console.WriteLine($"{input} => {output}");
        }

        public static void Replace_Char_With_Vowel_Using_Regex()
        {
            string input = "Amit Gupta";
            char letter = 'b';

            string output = Regex.Replace(input, "[aeiouAEIOU]", letter.ToString());
            Console.WriteLine($"{input} => {output}");
        }

        public static void Replace_Char_With_Vowel_Using_Recursion()
        {
            string input = "Amit Gupta";
            char letter = 'b';

            StringBuilder output = Recusrion_Logic_For_RepaceVovel(input ,0,null);

            Console.WriteLine($"{input} => {output.ToString()}");
        }

        private static StringBuilder Recusrion_Logic_For_RepaceVovel(string input, int index ,StringBuilder sb,char Letter = 'T')
        {
            if (sb == null) sb = new StringBuilder();
            if(input.Length == index)
            {
                return sb;
            }

            char Current = input[index];
            if ("aeiouAEIOU".Contains(Current))
            {
                sb.Append(Letter);
            }
            else
            {
                sb.Append(Current);
            }

            return Recusrion_Logic_For_RepaceVovel(input, index + 1, sb);
        }

        #endregion Problem 13 : Replace all vowels with a given character

        #region Problem 13 : Remove duplicates from a string

        public static void Remove_Duplicates()
        {
            string input = "aabbbcccc  %";

            StringBuilder sb = new StringBuilder();
            foreach(char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    if (!sb.ToString().Contains(ch)) 
                    {
                        sb.Append(ch);
                    }
                }
            }

            Console.WriteLine($"{input} : {sb}");
        }

        public static void Remove_Duplicates_Using_LINQ()
        {
            string input = "aabbbcccc  %";

            string output = new string(
        input.Where(char.IsLetter) // keep only letters
             .Distinct()           // remove duplicates
             .ToArray()
    );

            Console.WriteLine($"{input} : {output}");
        }

        public static void Remove_Duplicate_Recusrion()
        {
            string input = "aabbbcccc  %";
            string sb = RemoveDuplicateLogic(input ,0,new StringBuilder());
            Console.WriteLine($"{input} : {sb}");
        }

        private static string RemoveDuplicateLogic(string input, int index ,StringBuilder SB)
        {
            if(input.Length == index)
            {
                return SB.ToString();
            }

            char Current = input[index];
            if (!SB.ToString().Contains(Current)) SB.Append(Current);

            return RemoveDuplicateLogic(input, index + 1, SB);
        }

        #endregion Problem 13 : Remove duplicates from a string

        #region Problem 14 : Find first non-repeating character

        public static void Non_Repating_numbers()
        {
            string input = "aabbccaabbdde";

            int count = 0;
            char current = input[0];
            foreach(var ch in input)
            {
                if (ch != current)
                {
                   if(count > 1)
                   {
                        count = 0;
                        current = ch;
                   }
                   else
                   {
                        break;
                   }
                }
                count++;
            }

            Console.WriteLine($"First Non Repeating Character is : {current}");
        }

        public static void Non_Repeating_Number_Recursion()
        {
            string input = "aabbcc44223333333aabbdde";
            char current = NotRepeatingLogic(input ,0 ,0 , input[0]);

            Console.WriteLine($"First Non Repeating Character is : {current}");
        }

        private static char NotRepeatingLogic(string input, int index, int count ,char ch)
        {
            if(input.Length == index)
            {
                return ch;
            }

            if(!(ch == input[index]))
            {
                if(count > 1)
                {
                    count = 0;
                    ch = input[index];
                    
                }
                else
                {
                    return ch;
                }
            }
            count++;

            return NotRepeatingLogic(input, index + 1, count, ch);
        }

        // Linq Approach
        //var result = input
        //         .GroupBy(c => c)
        //         .Where(g => g.Count() == 1)
        //         .Select(g => g.Key)
        //         .FirstOrDefault();

        #endregion Problem 14 : Find first non-repeating character

        #endregion String_School_Level_Problems
    }
}
