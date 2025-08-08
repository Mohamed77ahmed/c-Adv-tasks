using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Range<T> where T :IComparable
    {
        public T Maximum { get; set; }
        public T Minimum { get; set; }
        public Range(T maximum, T minimum)
        {
            Maximum = maximum;
            Minimum = minimum;
        }

        public  bool IsInRange(T value) 
        {
            if(Maximum.CompareTo(value)>=0&& Minimum.CompareTo(value)<=0) return true;
            else return false;  

            
        }

        public  double Length()
        {

            if (typeof(T) == typeof(int) || typeof(T) == typeof(long) ||
            typeof(T) == typeof(short) || typeof(T) == typeof(byte))
            
                return Convert.ToDouble(Maximum) - Convert.ToDouble(Minimum);
            
            else if (typeof(T) == typeof(float) || typeof(T) == typeof(double) || typeof(T) == typeof(decimal))
            
                return Convert.ToDouble(Maximum) - Convert.ToDouble(Minimum);
            
            else //if (typeof(T) == typeof(DateTime))
            {
                DateTime minDate = (DateTime)(object)Minimum;
                DateTime maxDate = (DateTime)(object)Maximum;
                return (maxDate - minDate).TotalDays; 
            }
           

        }



    }
}
