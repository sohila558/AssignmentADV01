using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADV01
{
    internal static class Helper
    {
        //public static void SWAP(ref int X, ref int Z)
        //{
        //    int Temp = X;
        //    X = Z; 
        //    Z = Temp;
        //}
        //public static void SWAP(ref double X, ref double Z)
        //{
        //    double Temp = X;
        //    X = Z;
        //    Z = Temp;
        //}

        //public static void SWAP<T>(ref T X, ref T Z)
        //{
        //    T Temp = X;
        //    X = Z; 
        //    Z = Temp;
        //}

        //public static void Print(T data)
        //{
        //    Console.WriteLine(data);
        //}

        //public static int LinearSearch(int[] Arr, int Value)
        //{
        //    if(Arr?.Length > 0)
        //    {
        //        for(int i = 0; i < Arr.Length; i++)
        //        {
        //            if (Arr[i] == Value) return i;
        //        }
        //    }
        //    return -1;
        //}

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

    }
}
