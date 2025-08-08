using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }

        public Range(T Min, T Max)
        {
            this.Min = Min;
            this.Max = Max;

            if (Min.CompareTo(Max) > 0)
                Console.WriteLine("-1");
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        // Using dynamic to allow substraction for numeric types
        public dynamic Length()
        {
            try
            {
                return (dynamic)Max - (dynamic)Min;
            }
            catch(Exception e)
            {
                return e.Message; 
            }
        }


    }
}
