# Non - Generics Interview Questions in C#
## Q1 : What are Non-Generics in C# ?
Ans : 
    -> Non Generics are collections that can store any type of object.
    -> They Store Values as object type -> boxing/unboxing happens for value types.
    -> Fount in System.Collections namespace.
    -> Example : 
    ```c#
    ArrayList list = new ArrayList();
    list.Add(10);       // int (boxed)
    list.Add("Hello");  // string
    list.Add(3.14);     // double
    ```

## Q2 : Why was Generics introduced if Non- Generics already exists?
Ans : 
    -> Non-Generics :- no type-safe , Boxing and Unboxing overhead, runtime erros
    -> Generics :- Type-Safe , better performance , compile time error checking.

    Example:

    ```C#
    ArrayList list = new ArrayList();
    list.Add(10);
    list.Add("Hello"); // Allowed

    int num = (int)list[1]; // ❌ Runtime Error
    ```

## Q3 : What is the difference between ArrayList and List<T>?
Ans : 
    Features           ArrayList               List<T>
    Type Safety        Not                     Yes
    Performance        Boxing/Unboxing         None
    NameSpace          System.Colection        System.Collections.Generic
    Flexibility        Can store mixed types   Stores single type

## Q4 : What is an ArrayList?
Ans :
   -> A dynamic array that grows/shrinks automatically.
   -> Stores objects (non-generic).

   ```c#
    ArrayList arr = new ArrayList();
    arr.Add(1);
    arr.Add("Amit");
    arr.Insert(1, 50);

    foreach (var item in arr)
    Console.WriteLine(item);
   ```

## Q5 : hat is the difference between Array and ArrayList?
Ans : 
| Feature     | Array          | ArrayList                |
| ----------- | -------------- | ------------------------ |
| Size        | Fixed          | Dynamic                  |
| Type        | Strongly typed | Stores objects           |
| Performance | Faster         | Slower (boxing/unboxing) |
| Namespace   | System         | System.Collections       |

## Q6 : What is Boxing and Unboxing in Non-Generics?
Ans : 
 -> Boxing : Converting value type -> Object
 -> Unboxing : Extracting object ->  value type.

```c#
    int x = 10;
    object obj = x;   // Boxing
    int y = (int)obj; // Unboxing
```

## Q7 : What is Stack in Non-Generics ?
Ans : 
    -> Follows LIFO (Last In First Out).
    -> Non-generic version: System.Collections.Stack.

    ```c#
    Stack stack = new Stack();
    stack.Push(10);
    stack.Push(20);
    stack.Push(30);

    Console.WriteLine(stack.Pop());  // 30
    Console.WriteLine(stack.Peek()); // 20
    ```

## Q8 : What is a Queue in Non-Generic ?
Ans : 
    -> Follows FIFO (First In First Out).
    -> Non-generic version: System.Collections.Queue.

```c#
    Queue queue = new Queue();
    queue.Enqueue("A");
    queue.Enqueue("B");

    Console.WriteLine(queue.Dequeue()); // A
    Console.WriteLine(queue.Peek());    // B
```

## Q9 : What is a Hashtable ?
Ans : Stores Key Value Pair , Key Must be Unique , Uses hashing for fast lookup.

```c++
Hashtable ht = new Hashtable();
ht.Add(1, "One");
ht.Add(2, "Two");
ht["Name"] = "Amit";

foreach (DictionaryEntry entry in ht)
    Console.WriteLine($"{entry.Key} : {entry.Value}");
```

## Q10 : What is the difference between Hashtable and Dictionary<TKey,TValue>?
Ans : 
| Feature     | Hashtable   | Dictionary\<TKey,TValue> |
| ----------- | ----------- | ------------------------ |
| Type        | Non-generic | Generic                  |
| Type-safety | No          | Yes                      |
| Performance | Slower      | Faster                   |
| Key Type    | Object      | Strongly typed           |

## Q11 : What is a SortedList in Non-Generics?
Ans : Stores key-value pairs sorted by key , Non-generic: System.Collections.SortedList.

```c#
SortedList sl = new SortedList();
sl.Add(3, "Three");
sl.Add(1, "One");
sl.Add(2, "Two");

foreach (DictionaryEntry entry in sl)
Console.WriteLine($"{entry.Key} : {entry.Value}");
```

## Q12 : When Should you use Non-Generics ?
Ans : 
1. Rarely used today (old codebase).
2. Used when:
    Working with .NET 1.0 legacy code.
    You don’t know the object type beforehand.

## Q13 : What happens if you insert duplicate keys in Hashtable?
Ans : Hashtable doesnot allow duplicates keys.
      Adding a Duplicate key -> ArgumentException.

       ```c++
        Hashtable ht = new Hashtable();
        ht.Add(1, "One");
        ht.Add(1, "Duplicate"); // ❌ Exception
       ```

## Q14 : What is the difference between Hashtable and SortedList?
Ans : 
| Feature     | Hashtable      | SortedList       |
| ----------- | -------------- | ---------------- |
| Order       | Unordered      | Sorted by key    |
| Performance | Fast (hashing) | Slower (sorting) |
| Key Type    | Object         | Object           |

## Q15 : How do you iterate through Non-Generic collections?
Ans : Using foreach or IEnumerator.

```c#
ArrayList arr = new ArrayList() { 1, "A", 3.5 };

IEnumerator en = arr.GetEnumerator();
while (en.MoveNext())
    Console.WriteLine(en.Current);
```

## Q16 : What are the performance implications of Using Non-Generic?
Ans : 
    -> Boxing / Unboxing Overhead - Every time a value type is stored , it gets boxed.
    -> Casting Overhead - Retrieval requires casting , which is costly.
    -> Runtime Error - No copile-time type checking.

    ```c#
    ArrayList arr = new ArrayList();
    arr.Add(10);         // Boxing
    int val = (int)arr[0]; // Unboxing
    ```

## Q17 : What is internal implementation of Hashtable ?
Ans : 
    1. Hashtable uses buckets (array of slots).
    2. Each bucket contains :
        - Hash code of key
        - Key 
        - Value
        - Next Link(for collision handling)
    3. Collosion handling -> Chaining (linked list)

## Q18 : What is the difference between Hashtable and SortedList in terms of complexity?
Ans : 
| Operation | Hashtable                | SortedList                                |
| --------- | ------------------------ | ----------------------------------------- |
| Lookup    | O(1) average, O(n) worst | O(log n)                                  |
| Insert    | O(1) average             | O(n) (because shifting elements in array) |
| Remove    | O(1) average             | O(n)                                      |
| Ordering  | Not maintained           | Maintained (sorted by key)                |

## Q19 : What is the default capacity of ArrayList and how does it grow?
Ans : 
    -> Default Capacity = 0 (internally creates an empty array)
    -> First Add() → capacity becomes 4.
    -> When full, it doubles (4 → 8 → 16 → 32 …).
    -> If you know the size → use ArrayList.Capacity to avoid resizing.

## Q20 : What is the difference between Stack (Non-Generic) and ConcurrentStack<T>?
Ans : 
| Feature     | Stack (System.Collections) | ConcurrentStack<T> (System.Collections.Concurrent) |
| ----------- | -------------------------- | -------------------------------------------------- |
| Generic     | No                         | Yes                                                |
| Thread-Safe | No                         | Yes                                                |
| Performance | Faster (single-threaded)   | Better for multi-threaded                          |

## Q21 : What happens if you try to Pop() or Dequeue() from an empty Stack/Queue?
Ans :  Throws InvalidOperationException.

## Q22 : What is the difference between Hashtable and HashTable.Synchronized()?
Ans : 
    -> Hashtable by default is not thread safe
    -> Hashtable.Synchronized() -> returns a thread-safe wrapper.

Hashtable ht = Hashtable.Synchronized(new Hashtable());

## Q23 : How does Hashtable handle duplicate keys and duplicate values?
Ans : Duplicate Keys → Not allowed (ArgumentException) , Duplicate Values → Allowed.

## Q24 : What is the difference between Hashtable and DictionaryEntry?
Ans : 
-> Hashtable stores key-value pairs.
-> Iterating returns DictionaryEntry objects (key & value).

## Q25 : What is the difference between IEnumerable and IEnumerator in Non-Generics?
Ans : 
    -> IEnumerable → Provides an enumerator (GetEnumerator()).
    -> IEnumerator → Provides iteration logic (MoveNext(), Current).

```c++
    ArrayList arr = new ArrayList() { 1, 2, 3 };
    IEnumerator en = arr.GetEnumerator();

    while (en.MoveNext())
    Console.WriteLine(en.Current);
```

## Q26 : Why is using Non-Generic ArrayList risky in large applications?
Ans : Mixing types → runtime casting issues.

## Q27 :  Is Non-Generic ArrayList faster than Generic List<T>?
Ans : For reference types: performance is almost equal , For value types: ArrayList is slower due to boxing/unboxing.

## Q28 : What is the difference between Clone() and CopyTo() in ArrayList?
Ans : 
| Feature     | Clone()                                      | CopyTo()                            |
| ----------- | -------------------------------------------- | ----------------------------------- |
| Return Type | Shallow copy of ArrayList                    | Copies elements into existing array |
| Example     | `ArrayList newArr = (ArrayList)arr.Clone();` | `arr.CopyTo(array, 0);`             |

## Q29 : What is the difference between Capacity and Count in ArrayList?
Ans : Count → Actual number of elements  ,  Capacity → Number of elements ArrayList can hold before resizing.

## Q30 : Can Hashtable have null keys and values?
Ans : 
    -> Key = null → ❌ Not allowed (throws ArgumentNullException).
    -> Value = null → ✅ Allowed.

# Generics Interview Questions in C#
## Q1 : What are Generics in C#?
Ans : 
-> Generics allow you to create type-safe clasees , methods, delegates, and collections without commiting to a specific data type at design time.

-> Introduced in .NET 2.0

Example :

```c++
List<int> numbers = new List<int>(); 
numbers.Add(10);
numbers.Add(20);
// numbers.Add("Amit"); ❌ Compile-time error (type-safe)
```

## Q2 : Why use Generics over Non-Generics?
Ans : 
    1. Type-Safely (compile time errors instead of runtime).
    2. No boxing/unboxing → better performance.
    3. Reusability (one generic method/class works for multiple types).

## Q3 : What are generic methods ?
Ans : A method with type parameter.

```c#
public class Utilities
{
    public T Print<T>(T value)
    {
        Console.WriteLine(value);
        return value;
    }
}

var obj = new Utilities();
obj.Print<int>(100);
obj.Print<string>("Hello");
```
## Q4 : What is a Generic Class?
Ans : A class that works with any type.

```c#
public class MyGenericClass<T>
{
    private T data;
    public MyGenericClass(T value) { data = value; }
    public T GetData() => data;
}

var obj1 = new MyGenericClass<int>(10);
var obj2 = new MyGenericClass<string>("Amit");
```

## Q5 : What are Generic Constraints in C#?
Ans : Constraints define restrictions on type parameters using where.
| Constraint                | Meaning                                        |
| ------------------------- | ---------------------------------------------- |
| `where T : struct`        | T must be a value type                         |
| `where T : class`         | T must be a reference type                     |
| `where T : new()`         | T must have a public parameterless constructor |
| `where T : BaseClass`     | T must inherit from BaseClass                  |
| `where T : InterfaceName` | T must implement InterfaceName                 |

## Q6 : What is Difference between Generic List<T> and Non- Generic ArrayList?
Ans : 
| Feature     | List<T>                    | ArrayList          |
| ----------- | -------------------------- | ------------------ |
| Type Safety | Type-safe                  | Not type-safe      |
| Performance | No boxing/unboxing         | Boxing/unboxing    |
| Namespace   | System.Collections.Generic | System.Collections |
| Usage       | Modern C#                  | Legacy code        |


## Q7 : What are Generic Collections in C# ?
Ans : Found in System.Collection.Gneric Namespace : 

List<T> → Dynamic array
Dictionary<TKey, TValue> → Key-value pairs
Queue<T> → FIFO
Stack<T> → LIFO
SortedList<TKey, TValue> → Sorted by key
HashSet<T> → Unique items

## Q8 : What is the difference between Dictionary<TKey, TValue> and Hashtable?
Ans : 
| Feature        | Dictionary\<TKey, TValue> | Hashtable |
| -------------- | ------------------------- | --------- |
| Generic        | Yes                       | No        |
| Type Safety    | Compile-time              | Runtime   |
| Performance    | Faster                    | Slower    |
| Key/Value Type | Strongly typed            | Object    |

## Q9 : What is covariace and contravariance in Generics ?
Ans : 
1. Covariance(out) -> Enables you to use a derived type than specified
2. Contravariance(in) -> Enables you to use a less derived type.

```ruby
IEnumerable<object> objEnum;
IEnumerable<string> strEnum = new List<string>();
objEnum = strEnum; // ✅ Covariance
```

## Q10 : What is the difference between IEnumerable<T> and IEnumerator<T> in Generics?
Ans : 
 | Interface        | Purpose                                                    |
| ---------------- | ---------------------------------------------------------- |
| `IEnumerable<T>` | Provides `GetEnumerator()`                                 |
| `IEnumerator<T>` | Provides iteration with `MoveNext()`, `Current`, `Reset()` |


## Q11 : What is the difference between Generic Queue<T> and Stack<T>?
Ans : 
| Feature   | Queue<T>               | Stack<T>        |
| --------- | ---------------------- | --------------- |
| Principle | FIFO                   | LIFO            |
| Methods   | Enqueue, Dequeue, Peek | Push, Pop, Peek |

## Q12 : Can Generic improve Performance?
Ans : Yes
1. Avoids boxing / Unboxing
2. Avoids type casting at runtime.
3. Provides complie time type checking

## Q13 :  What is the difference between List<T> and LinkedList<T>?
Ans : 
| Feature       | List<T>                  | LinkedList<T>             |
| ------------- | ------------------------ | ------------------------- |
| Storage       | Array                    | Doubly Linked List        |
| Access        | O(1) index-based         | O(n)                      |
| Insert/Delete | O(n) (shifting required) | O(1) (if reference known) |

## Q14 : What is default(T) in Generics?
Ans : Returns default value of type T.

## Q15 : What is the difference between Generic Delegates: Func, Action, Predicate?
Ans : 
| Delegate          | Return Type     | Example                                             |
| ----------------- | --------------- | --------------------------------------------------- |
| `Func<T,TResult>` | Returns a value | `Func<int,int> square = x => x*x;`                  |
| `Action<T>`       | No return       | `Action<string> print = x => Console.WriteLine(x);` |
| `Predicate<T>`    | Returns bool    | `Predicate<int> isEven = x => x % 2 == 0;`          |
