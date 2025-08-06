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
    }
}
