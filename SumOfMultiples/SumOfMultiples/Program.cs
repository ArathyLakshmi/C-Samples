using System;
using System.Linq;

namespace SumOfMultiples
{
    class Program
    {
        /// <summary>
        /// Your task is to write function findSum.
        /// Upto and including n, this function will return the sum of all multiples of 3 and 5.
        ///For example:
        ///findSum(5) should return 8 (3 + 5)
        ///findSum(10) should return 33 (3 + 5 + 6 + 9 + 10)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the range");
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);
            int res = GetSum(num);
            Console.WriteLine("result=" + res.ToString());
            Console.ReadLine();
        }

        private static int GetSum(int n)

        {

            return Enumerable.Range(1, n)
                                 .Where(m => m % 3 == 0 || m % 5 == 0).Sum();





        }
    }
}
