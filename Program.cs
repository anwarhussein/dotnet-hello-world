using System;
using System.Linq;

namespace dotnet_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(lovefunc(2, 2));
            Console.WriteLine(lovefunc(5, 2));
            Object[] arr = { 1, 4, 5, 6, 8, 6 };
            int [] array = { 1, 4, 0, -5, 8, -2 };
            Console.WriteLine(Check(arr, 3));
            Console.WriteLine(Check(arr, 4));
            Console.WriteLine(PositiveSum(array));
        }

        public static bool lovefunc(int flower1, int flower2)
        {
            return flower1 % 2 != flower2 % 2;
        }
        public static bool Check(object[] a, object x)
        {
            return Array.IndexOf(a, x) != -1;
        }
        public static int PositiveSum(int[] arr)
        {
            return arr.Sum(x => x > 0 ? x : 0);
        }
    }

}
