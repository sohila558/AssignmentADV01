using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADV01
{
    internal static class Helper
    {
        public static void SWAP(ref int X, ref int Z)
        {
            int Temp = X;
            X = Z;
            Z = Temp;
        }
        public static void SWAP(ref double X, ref double Z)
        {
            double Temp = X;
            X = Z;
            Z = Temp;
        }

        public static void SWAP<T>(ref T X, ref T Z)
        {
            T Temp = X;
            X = Z;
            Z = Temp;
        }

        public static void Print<T>(T data)
        {
            Console.WriteLine(data);
        }

        public static int LinearSearch(int[] Arr, int Value)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Arr[i] == Value) return i;
                }
            }
            return -1;
        }

        public static int LinearSearch<T>(T[] Arr, T Value)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Arr[i].Equals(Value)) return i;
                }
            }
            return -1;
        }

        public static void PrintArray<T>(T[] arr)
        {
            foreach(T i in arr)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();
        }

        #region Non-Generic Bubble Sort
        //public static void BubbleSort(int[] Arr)
        //{
        //    if (Arr.Length > 0)
        //    {
        //        for(int i = 0; i < Arr.Length; i++)
        //        {
        //            for(int j = 0; j < Arr.Length - i -1 ; j++)
        //            {
        //                if (Arr[j] > Arr[j + 1])
        //                {
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //                }
        //            }
        //        }
        //    }
        //} 
        #endregion

        public static void BubbleSort<T>(T[] Arr) where T : IComparable
        {
            if (Arr.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if ((Arr[j].CompareTo(Arr[j + 1])) > 0)
                        {
                            SWAP(ref Arr[j], ref Arr[j + 1]);
                        }
                    }
                }
            }
        }

    }
}
