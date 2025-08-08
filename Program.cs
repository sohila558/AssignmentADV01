using System.Drawing;

namespace AssignmentADV01
{
    internal class Program
    {
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



        }
    }
}
