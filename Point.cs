using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADV01
{
    internal class Point : IComparable
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public override string ToString()
        {
            return $"{X}, {Y}";
        }

        //public int CompareTo(object? obj)
        //{
        //    Point P = (Point)obj;

        //    if(X == P.X) return Y.CompareTo(P.Y);

        //    return X.CompareTo(P.X);
        //}

        //public int CompareTo(object? obj)
        //{
        //    // 1. is Conditional Operator


        //    if (obj is not null)
        //    {
        //        if(obj is Point P)
        //        {
        //            if (X == P.X) return Y.CompareTo(P.Y);

        //            return X.CompareTo(P.X);
        //        }
        //    }

        //    return 1;
        //}

        public int CompareTo(object? obj)
        {
            Point P = obj as Point;
            
            if(P is not null)
            {
                if (X == P.X) return Y.CompareTo(P.Y);

                return X.CompareTo(P.X); 
            }

            return 1;
        } 

    }
}
