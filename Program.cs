using AssignmentADV01.Assignment;
using System.Drawing;

namespace AssignmentADV01
{
    internal class Program
    {
        #region Q02
        //void ReverseArrayList(ArrayList list)
        //{
        //    int left = 0;
        //    int right = list.Count - 1;

        //    while (left < right)
        //    {
        //        object temp = list[left];
        //        list[left] = list[right];
        //        list[right] = temp;

        //        left++;
        //        right--;
        //    }
        //} 
        #endregion

        #region Q03
        //static List<int> GetEvenNumbers(List<int> numbers)
        //{
        //    List<int> evenList = new List<int>();

        //    foreach (int num in numbers)
        //    {
        //        if (num % 2 == 0)
        //        {
        //            evenList.Add(num);
        //        }
        //    }

        //    return evenList;
        //} 
        #endregion

        static void Main(string[] args)
        {
            #region GenericEX01 : SWAP

            // Generics :
            // C# feature 2005 C# 2.0
            // Before 2005 Class Object

            // Function SWAP

            //int A = 4, B = 5;

            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");

            //Console.WriteLine("********** After SWAP ***********");

            //Helper.SWAP( ref A, ref B ); // Passing By ref

            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");


            //double L = 1.5, K = 2.6;

            //Console.WriteLine($"A: {L}");
            //Console.WriteLine($"B: {K}");

            //Console.WriteLine("********** After SWAP ***********");

            //Helper.SWAP(ref L, ref K); // Passing By ref

            //Console.WriteLine($"A: {L}");
            //Console.WriteLine($"B: {K}");

            // ==================================================================

            //int A = 4, B = 5;

            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");

            //Console.WriteLine("********** After SWAP ***********");

            //Helper.SWAP(ref A, ref B); // Passing By ref

            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");


            //double L = 1.5, K = 2.6;

            //Console.WriteLine($"A: {L}");
            //Console.WriteLine($"B: {K}");

            //Console.WriteLine("********** After SWAP ***********");

            //Helper.SWAP(ref L, ref K); // Passing By ref

            //Console.WriteLine($"A: {L}");
            //Console.WriteLine($"B: {K}"); 
            #endregion

            #region GenericEX02 : Linear Search
            //// Linear Search

            //// 4 - 7 - 5 - 8 - 9 - 10 - 1 - 2 - 3 - 12 - 13 - 14


            ////int[] Numbers = { 8, 7, 6, 1, 2, 3, 4, 5, 6, 12, -1, 13, 9 };

            ////int Index = Helper.LinearSearch(Numbers, 4);

            ////Console.WriteLine($"Index : {Index}");

            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 12000, Age = 30 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ali", Salary = 13000, Age = 28 };
            //Employee E03 = new Employee() { Id = 3, Name = "Omar", Salary = 15000, Age = 32 };

            //Employee[] employees = { E01, E02, E03 };

            //int Index = Helper.LinearSearch(employees, E03);
            //Console.WriteLine($"Index: {Index}"); 
            #endregion

            #region Equality in class and struct
            //// Equality in class and struct
            //// Equals
            //// Class  Has Equals Function which inherited from object Class --> Compare based on Refernce  
            //// Struct Has Equals Function which inherited from object Class --> Compare based on Data
            //// NOTE: Struct Don't Have ImplementationFor The == Operator 



            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 12000, Age = 30 };
            //Employee E02 = new Employee() { Id = 1, Name = "Ahmed", Salary = 12000, Age = 30 };
            ////Employee E02 = new Employee() { Id = 2, Name = "Ali", Salary = 13000, Age = 28 };

            //Console.WriteLine($"E01: {E01.GetHashCode()}");
            //Console.WriteLine($"E02: {E02.GetHashCode()}");


            //if (E01.Equals(E02))
            //    Console.WriteLine("E01 == E02");
            //else
            //    Console.WriteLine("E01 != E02");

            //if (E01 == E02)
            //    Console.WriteLine("E01 == E02");
            //else
            //    Console.WriteLine("E01 != E02"); 
            #endregion

            #region GenericEX03 : Bubble Sort
            // 2,3,9,8,7,6,5,4,1,12,-1,0

            // Sorting : Bubble Sort 

            //int[] numbers = { 2, 3, 9, 8, 7, 6, 5, 4, 1, 12, -1, 0 };

            //Helper.PrintArray(numbers);
            //Console.WriteLine();

            //Helper.BubbleSort(numbers); // Sorting Asscending

            //Helper.PrintArray(numbers);

            //Point[] points =
            //{
            //    new Point(6, 6),
            //    new Point(2, 2),
            //    new Point(4, 4),
            //    new Point(3, 3),
            //    new Point(1, 1),
            //    new Point(5, 5)
            //};

            //Helper.BubbleSort(points);

            //Helper.PrintArray(points);

            // IComparable : CompareTo
            // int
            // + : Caller > Parameter
            // - : Caller < Parameter
            // 0 : Caller = Parameter 
            #endregion

            #region is and as operator
            //Point P01 = new Point(3, 3);
            //Point P02 = new Point(2, 2);

            //if (P01.CompareTo("Ahmed") > 0)
            //    Console.WriteLine("P01 is Greater Than P02");
            //else
            //    Console.WriteLine("P01 is not Greater Than P02");

            #endregion

            #region Q01
            /* 1. create a generic Range<T> class that represents a range of values from a
                      minimum value to a maximum value. The range should support basic
                      operations such as checking if a value is within the range and determining
                      the length of the range.
                      Requirements:
                      1. Create a generic class named Range<T> where T represents the type of
                      values.
                      2. Implement a constructor that takes the minimum and maximum values
                      to define the range.
                      3. Implement a method IsInRange(T value) that returns true if the given
                      value is within the range, otherwise false.
                      4. Implement a method Length() that returns the length of the range (the
                      difference between the maximum and minimum values).
                      5. Note: You can assume that the type T used in the Range<T> class
                      implements the IComparable<T> interface to allow for comparisons. */

            //Range<int> range = new Range<int>(5, 15);
            //Console.WriteLine(range); 
            //Console.WriteLine("Is 10 in range? " + range.IsInRange(10)); 
            //Console.WriteLine("Is 20 in range? " + range.IsInRange(20)); 
            //Console.WriteLine("Length: " + range.Length()); 
            #endregion

            #region Q02
            /*2. You are given an ArrayList containing a sequence of elements. try to
                     reverse the order of elements in the ArrayList in-place(in the same
                     arrayList) without using the built-in Reverse. Implement a function that
                     takes the ArrayList as input and modifies it to have the reversed order of
                     elements.*/


            //ArrayList L01 = new ArrayList() { 1, 2, 3, 4, 5 };
            //Console.WriteLine("************** Before Reverse **************");
            //foreach (var item in L01)
            //{
            //    Console.Write($"{item} ");
            //}

            //Console.WriteLine();
            //ReverseArrayList(L01);
            //Console.WriteLine();

            //Console.WriteLine("************** After Reverse **************");
            //foreach (var item in L01)
            //{
            //    Console.Write($"{item} ");
            //} 
            #endregion

            #region Q03
            /*3. You are given a list of integers. Your task is to find and return a new list
                     containing only the even numbers from the given list.*/

            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            //List<int> evens = GetEvenNumbers(Numbers);

            //Console.WriteLine("Even Numbers:");
            //foreach (int num in evens)
            //{
            //    Console.Write(num + " ");
            //} 
            #endregion

            #region Q04
            /*4. implement a custom list called FixedSizeList<T> with a predetermined
                     capacity. This list should not allow more elements than its capacity and
                     should provide clear messages if one tries to exceed it or access invalid
                     indices.
                     Requirements:
                     1. Create a generic class named FixedSizeList<T>.
                     2. Implement a constructor that takes the fixed capacity of the list as a
                     parameter.

                     3. Implement an Add method that adds an element to the list, but throws
                     an exception if the list is already full.
                     4. Implement a Get method that retrieves an element at a specific index in
                     the list but throws an exception for invalid indices.*/

            //try
            //{
            //    FixedSizeList<int> myList = new FixedSizeList<int>(3);

            //    myList.Add(1);
            //    myList.Add(2);
            //    myList.Add(3);

            //    myList.PrintAll();

            //    Console.WriteLine($"Item at index [1] is [{myList.Get(1)}]");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //} 
            #endregion

        }
    }
}
