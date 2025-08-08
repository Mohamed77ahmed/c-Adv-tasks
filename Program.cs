namespace assignment1
{
    





    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1

            //int []array ={ 6, 7, 8, 9, 1, 2, 3, 4, 5 };

            //Helper<int>.Bubble_sort( array);
            //;
            //foreach (var i in array)
            //    Console.WriteLine(i);



            #endregion


            #region question2
            // Range<double> range = new Range<double>(2000.22,400.22);
            //bool res1= range.IsInRange(2000.21);
            // bool res2 = range.IsInRange(2000.23);

            // double res = range.Length();
            // Console.WriteLine(res1);
            // Console.WriteLine(res2);
            // Console.WriteLine(res);


            Range<DateTime> range = new Range<DateTime>(new DateTime(2025, 8, 8),
            new DateTime(2025, 8, 1));
         

            
            bool res1 = range.IsInRange(
                 new DateTime(2025,8,2));
            bool res2 = range.IsInRange(
                new DateTime(2025, 8, 10));

            double res = range.Length();
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res);
            #endregion
        }
    }
}
