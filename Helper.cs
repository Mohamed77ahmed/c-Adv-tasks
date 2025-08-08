using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Helper<T> where T : IComparable
    {

        public static void Bubble_sort( T []arr) 
        {
           if (arr is not null) 
           {
                for (int i = 0; i < arr.Length; i++)
                {
                    bool swapped=false;
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j].CompareTo(arr[j + 1]) ==1)
                        {

                            T temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                            swapped = true;
                        }


                       
                  
                    }
                    if (!swapped) break;
                }
           }

        }

    }
}
