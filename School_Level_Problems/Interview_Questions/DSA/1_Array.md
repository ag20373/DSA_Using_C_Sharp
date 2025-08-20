# Most Asked Interview Questions on Arrays
## Q1 : What is Array ?
-> Interview Answer
Array Ek **linear data structure** hai jisme **same type ke elements ek contiguous memory locaton** me store hote hain. Iska **indexing 0** se start hoti hai. Iska indexing 0 se start hoti hai. Array ka **size fixed hai** aur run time pe chnage nahi kar sakta.

-> Real Life Example :
"Jasie ek parking lot hoti hai jisme 10 parking slots fix bane hue hain. Har slot ek car ko hi hold karega aur ek baar fix ho gaya toh slots badh nahi sakte ."

## Q2 : What are the advantages of arrays?
-> Interview Answer
1. Data ko ek jagah store karna easy ho jata hai.
2. Index ke through direct access possible hota hai --> O(1) time complexity.
3. Searching aur traversing easy hai.

-> Real Life Example :
"Jaise ek cinema hall me har seat number hota hai. Seat no. 5 directly find karna easy hai, bina poora hall search kiye."

## Q3 : What are the disadvantages of arrays?
-> Interview Answer
1. Size fixed hota hai (dynamic nahi).
2. Insert aur delete costly hote hain.
3. Memory waste ho sakti hai agar unused slots rah gaye..

-> Real Life Example :
"Jaise maine 10 seat ka hall reserve kiya but sirf 6 friends aaye, toh 4 seats waste ho gayi."

## Q4 : hat are different types of arrays in C#?
-> Interview Answer
1. One-Dimensional Array (1D): Single row data. Example → Students ke marks.
2. Two-Dimensional Array (2D): Rows and columns. Example → Chess board (8x8).
3. Jagged Array: Array of arrays, jisme har row ka size alag ho sakta hai. Example → Different class ke students (class A me 30, class B me 25). 

## Q5 : Difference between Array and ArrayList (C# Specific)?
-> Interview Answer
1. Array : Fixed Size , Type safe, fast.
2. ArrayList : Dynamic size, but boxing - unboxing overhead(slower)

-> Real Life Example :
"Array ek fixed tiffin box jaisa hai jisme 6 hi compartments hai. ArrayList ek adjustable lunchbox jaisa hai jo expand ho sakta hai, lekin thoda heavy rehta hai."

## Q6 : How do you find the length of an array?
-> Interview Answer 
array.Length property use hoti hai.

## Q7 : Can we increase the size of an array in C#?
-> Interview Answer
Directly size increase nahi kar sakte. Lekin Array.Resize() function use karke ek naya array banate hain aur purane elements copy karte hain.

-> Real Life Example :
"Jaise ghar me fixed 2 almirah hain. Agar jagah kam pad gayi toh ek nayi almirah lana padta hai aur purane kapde usme shift karne padte hain."

## Q8 : Difference between Single Dimensional and Multi-Dimensional Arrays?
-> Interview Answer
1. ID Array : Linear data -> weekly Expenses
2. 2D Array : Tabular data. -> Excel sheet.

## Q9 : What is a Jagged Array?
-> Interview Answer
Array of arrays, jisme har array ki length alag ho sakti hai.

-> Real Life Example :
"Suppose ek school me 3 classes hain. Class A me 40 students, Class B me 30 students aur Class C me 25 students. Har row ki strength alag hai → ye jagged array hai."

## Q10 : How does Array stores data in memory ?
-> Interview Answer
 Array elements contiguous memory locations e store hote hain. Islia random access fast hota hai using index formula.
 -> BaseAddress + (Index * SizeOfDatatype)

 Example : "Jaise ek train ke bogies ek line me connected hote hain, ek ke baad ek."

## Q11 : What is the difference between value type array and reference type array?
-> Interview Answer
  1. int[], double[] → Value type elements but array khud ek reference type hai.
  2. Array object heap memory me banta hai.

## Q12 : Time Complexity of Array Operations?
-> Interview Answer
1. Access By Index -> O(1)
2. Search(Unsorted) -> O(n)
3. Insert/Delete -> O(n)

## Q13 :  Difference between Array and LinkedList?
-> Interview Answer
1. Array : Fixed size, fast access, costly insert/delete.
2. LinkedList : Dynamic size, slow access . fast insert/delete.

## Q14 : Can Array store diffrent data types ?
-> Interview Answer
By Default No (Strictly type - safe)
but agar objecr[] use kare toh different data types rakh sakta ho.

-> Real Life Example :
"Jaise ek egg tray sirf eggs hi store karega (same type). Agar ek general basket ho toh usme fruits, eggs, bread sab aa sakte hain (object[])."

## Q15 : What happens if we access an invalid index in Array?
-> Interview Answer
C# mein runtime pe IndexOutOfRangleException throw hota hai.