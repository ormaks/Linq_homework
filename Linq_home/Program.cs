using System;
using System.Linq;

namespace ConsoleApplication1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            LinqBegin16();
            LinqBegin17();
            LinqBegin18();
            LinqBegin19();
            LinqBegin20();
            LinqBegin44();
            LinqBegin45();
            Console.ReadLine();
        }

        private static void LinqBegin16()
        {
            int[] arr = {1, -2, 3, -6, 767, 534};

            var items = from i in arr
                where i > 0
                select i;
            Console.Write("Task 1:");
            foreach (var i in items) Console.Write(" " + i);
        }

        private static void LinqBegin17()
        {
            int[] arr = {1, -2, 3, 3, -63, 767, 534};

            var items = arr.Where(i => i % 2 == 1).Distinct();
            Console.Write("\nTask 2:");
            foreach (var i in items) Console.Write(" " + i);
        }

        private static void LinqBegin18()
        {
            int[] arr = {1, -2, 32, 3, 26, 76, 534};

            var items = arr.Where(item => item > 9 && item < 100).OrderBy(item => item);
            Console.Write("\nTask 3:");
            foreach (var item in items) Console.Write(" " + item);
        }

        private static void LinqBegin19()
        {
            string[] arr = {"aaaa", "ab", "aa", "zxc", "asdasd", "s"};

            var items = arr.OrderBy(item => item.Length).ThenBy(item => item);
            Console.Write("\nTask 4:");
            foreach (var item in items) Console.Write(" " + item);
        }

        private static void LinqBegin20()
        {
            const int d = 3;
            int[] arr = {1, -2, 32, 5, 25, 76, 75, 534};

            var items = arr.SkipWhile(num => num < d).Where(num => num % 2 == 1 && num > 0).Reverse();
            Console.Write("\nTask 5:");
            foreach (var item in items) Console.Write(" " + item);
        }

        private static void LinqBegin44()
        {
            const int k1 = 100;
            const int k2 = 10;

            int[] arrA = {1, -2, 32, 5, 25, 76, 75, 534};
            int[] arrB = {3, 15, 33, 5, 0, 111, 423, 9};

            var items = arrA.Where(num => num > k1).Concat(arrB.Where(num => num < k2)).OrderBy(num => num)
                .DefaultIfEmpty();
            Console.Write("\nTask 6:");
            foreach (var item in items) Console.Write(" " + item);
        }

        private static void LinqBegin45()
        {
            const int l1 = 2;
            const int l2 = 5;

            string[] arrA = {"aaaa", "ab", "aa", "zxc", "asdasd", "cc", "ee2", "s"};
            string[] arrB = {"aaaa", "ab", "aa", "zxc", "bsdsd", "s", "aadsd"};

            var items = arrA.Where(word => word.Length == l1).Concat(arrB.Where(word => word.Length == l2))
                .OrderBy(num => num)
                .DefaultIfEmpty();
            Console.Write("\nTask 7:");
            foreach (var item in items) Console.Write(" " + item);
        }
    }
}