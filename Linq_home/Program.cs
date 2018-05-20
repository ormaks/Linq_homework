using System;
using System.IO;
using System.Linq;

namespace Linq_home
{
    internal static class Program
    {
        private static string _output = "";

        public static void Main(string[] args)
        {
            LinqBegin16();
            LinqBegin17();
            LinqBegin18();
            LinqBegin19();
            LinqBegin20();
            LinqBegin44();
            LinqBegin45();

            File.WriteAllText("./TextData/OutputData/Output.txt", _output);
            Console.ReadKey();
        }

        private static void LinqBegin16()
        {
            var fileContent = File.ReadAllText("TextData/InputData/LinqBeginNum.txt");
            var integerStrings = fileContent.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var arr = new int[integerStrings.Length];
            for (var n = 0; n < integerStrings.Length; n++)
                arr[n] = int.Parse(integerStrings[n]);

//            int[] arr = {1, -2, 3, -6, 767, 534};

            var items = from i in arr
                where i > 0
                select i;
            Console.Write("Task 1:");
            _output += "Task 1:";
            foreach (var i in items)
            {
                Console.Write(" " + i);
                _output += " " + i;
            }
        }

        private static void LinqBegin17()
        {
            var fileContent = File.ReadAllText("TextData/InputData/LinqBeginNum.txt");
            var integerStrings = fileContent.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var arr = new int[integerStrings.Length];
            for (var n = 0; n < integerStrings.Length; n++)
                arr[n] = int.Parse(integerStrings[n]);

//            int[] arr = {1, -2, 3, 3, -63, 767, 534};

            var items = arr.Where(i => i % 2 == 1).Distinct();
            Console.Write("\nTask 2:");
            _output += "\nTask 2:";
            foreach (var i in items)
            {
                Console.Write(" " + i);
                _output += " " + i;
            }
        }

        private static void LinqBegin18()
        {
            var fileContent = File.ReadAllText("TextData/InputData/LinqBeginNum.txt");
            var integerStrings = fileContent.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var arr = new int[integerStrings.Length];
            for (var n = 0; n < integerStrings.Length; n++)
                arr[n] = int.Parse(integerStrings[n]);

            var items = arr.Where(item => item > 9 && item < 100).OrderBy(item => item);
            Console.Write("\nTask 3:");
            _output += "\nTask 3:";
            foreach (var item in items)
            {
                Console.Write(" " + item);
                _output += " " + item;
            }
        }

        private static void LinqBegin19()
        {
            var fileContent = File.ReadAllText("TextData/InputData/LinqBeginStrings.txt");
            var stringArr = fileContent.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var arr = new string[stringArr.Length];
            for (var n = 0; n < stringArr.Length; n++)
                arr[n] = stringArr[n];

            var items = arr.OrderBy(item => item.Length).ThenByDescending(item => item);
            Console.Write("\nTask 4:");
            _output += "\nTask 4:";
            foreach (var item in items)
            {
                Console.Write(" " + item);
                _output += " " + item;
            }
        }

        private static void LinqBegin20()
        {
            const int d = 3;

            var fileContent = File.ReadAllText("TextData/InputData/LinqBeginNum.txt");
            var integerStrings = fileContent.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var arr = new int[integerStrings.Length];
            for (var n = 0; n < integerStrings.Length; n++)
                arr[n] = int.Parse(integerStrings[n]);

//            int[] arr = {1, -2, 5, 57, 5, -63, 767, 22, 534};

            var items = arr.SkipWhile(num => num < d).Where(num => num % 2 == 1 && num > 0).Reverse();
            Console.Write("\nTask 5:");
            _output += "\nTask 5:";
            foreach (var item in items)
            {
                Console.Write(" " + item);
                _output += " " + item;
            }
        }

        private static void LinqBegin44()
        {
            const int k1 = 100;
            const int k2 = 10;

            var fileContent = File.ReadAllText("TextData/InputData/LinqBegin44A.txt");
            var integerStrings = fileContent.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var arrA = new int[integerStrings.Length];
            for (var n = 0; n < integerStrings.Length; n++)
                arrA[n] = int.Parse(integerStrings[n]);

            fileContent = File.ReadAllText("TextData/InputData/LinqBegin44B.txt");
            integerStrings = fileContent.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var arrB = new int[integerStrings.Length];
            for (var n = 0; n < integerStrings.Length; n++)
                arrB[n] = int.Parse(integerStrings[n]);

//            int[] arrA = {1, -2, 5, 57, 5, -63, 767, 22, 534};
//            int[] arrB = {3, 15, 33, 5, 0, 111, 423, 9};

            var items = arrA.Where(num => num > k1).Concat(arrB.Where(num => num < k2)).OrderBy(num => num)
                .DefaultIfEmpty();
            Console.Write("\nTask 6:");
            _output += "\nTask 6:";
            foreach (var item in items)
            {
                Console.Write(" " + item);
                _output += " " + item;
            }
        }

        private static void LinqBegin45()
        {
            const int l1 = 2;
            const int l2 = 5;
            var fileContent = File.ReadAllText("TextData/InputData/LinqBegin45A.txt");
            var stringArr = fileContent.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var arrA = new string[stringArr.Length];
            for (var n = 0; n < stringArr.Length; n++)
                arrA[n] = stringArr[n];

            fileContent = File.ReadAllText("TextData/InputData/LinqBegin45B.txt");
            stringArr = fileContent.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var arrB = new string[stringArr.Length];
            for (var n = 0; n < stringArr.Length; n++)
                arrB[n] = stringArr[n];

//            string[] arrA = {"aaaa", "ab", "aa", "zxc", "asdasd", "cc", "ee2", "s"};
//            string[] arrB = {"aaaa", "ab", "aa", "zxc", "bsdsd", "s", "aadsd"};

            var items = arrA.Where(word => word.Length == l1).Concat(arrB.Where(word => word.Length == l2))
                .OrderByDescending(word => word)
                .DefaultIfEmpty();
            Console.Write("\nTask 7:");
            _output += "\nTask 7:";
            foreach (var item in items)
            {
                Console.Write(" " + item);
                _output += " " + item;
            }
        }
    }
}