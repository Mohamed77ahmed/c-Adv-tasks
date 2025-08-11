using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace assignment2
{
    internal class Program
    {



        static void queries()
        {
            Console.WriteLine("enter size of list");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number of queries");
            int queries = int.Parse(Console.ReadLine());
            int[] arr = new int[queries];
            List<int> list = new List<int>(size);

            for (int i = 0; i < size; i++)
            {
                int number = 0;

                Console.WriteLine($"enter element number {i + 1}");
                number = int.Parse(Console.ReadLine());
                list.Add(number);
            }

            for (int i = 0; i < queries; i++)
            {
                Console.WriteLine($"enter querie number {i + 1}");
                arr[i] = int.Parse(Console.ReadLine());
            }
            List<int> count = new List<int>(queries);
            for (int i = 0; i < queries; i++)
            {
                var s = list.FindAll((n) => n > arr[i]);
                count.Add(s.Count);


            }


            foreach (int i in count)
                Console.WriteLine(i);
        }


       static void ReverseArray( ArrayList  arr)
        {
            for (int i = arr.Count-1; i>=0; i-- )
                Console.WriteLine(arr[i]);
            
        }


        static void palindrome(List<int> list)
        {
            bool check=true;
           
            for (int i = 0; i < list.Count / 2; i++)
            {
                if (list[i] != list[list.Count - i - 1])
                {
                    check = false;
                    break;
                }
            }

            

            if (check) Console.WriteLine("yes");
            else Console.WriteLine("no");
            


        }


        static int[] RemoveDuplicateelement(int[] arr)
        {
            return arr.Distinct().ToArray(); 
        }


        static List<int> RemoveOod(List<int> list)
        {
            list.RemoveAll((x )=> x%2==1);
            return list;
        }
        static void Main(string[] args)
        {
            #region question1
            ////You are given an ArrayList containing a sequence of elements. try to reverse the
            ////order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse.
            ////Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.


            //ArrayList arrayList = new ArrayList();
            //arrayList.AddRange(new int [] { 1,2,3,4,5,6,7});

            //ReverseArray( arrayList );



            #endregion
            #region question2

            // //You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.
            // List<int> list = new List<int>();
            // list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7,8,9,10 });
            //var s=list.FindAll(( x) => x%2== 0 );
            // foreach ( var x in s ) 
            //     Console.WriteLine( x );



            #endregion
            #region question3
            ////implement a custom list called FixedSizeList<T> with a predetermined capacity.
            ////This list should not allow more elements than its
            ////capacity and should provide clear messages if one tries to exceed it or access invalid indices.

            //FixedSizeList<int> list = new FixedSizeList<int>(6);
            //list.Add(1);
            //list.Add(5);
            //list.Add(6);
            //int num =list.Get(6);
            //Console.WriteLine(num);
            //list.print();




            #endregion
            #region question4
            //Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.



            //queries();



            #endregion

            #region question5


            //List<int> list = new List<int>(5);
            //list.AddRange(new int[] {1,2,3,2,2});
            //palindrome(list);

            //List<int> llist = new List<int>(5);
            //list.AddRange(new int[] { 1, 2, 3, 2, 1 });
            //palindrome(llist);
            //List<int> lllist = new List<int>(1);
            //list.AddRange(new int[] { 1});
            //palindrome(llist);


            #endregion

            #region question6
           // //Given an array, implement a function to remove duplicate elements from an array.

           // int[] arr = { 1, 2, 1, 2, 3, 5, 78 };
           //var s= RemoveDuplicateelement(arr);
           // foreach (int i in s) Console.WriteLine(i);




            #endregion

            #region question7
           // // Given an array list , implement a function to remove all odd numbers from it.

           // List<int> list = new List<int>(new int[] {1,2,3,4,5,6,7,8,9,10 });
           //var reood=RemoveOod(list);
           // foreach (var item in reood)
           //     Console.WriteLine(item);
        
            #endregion



        }

    }
}
