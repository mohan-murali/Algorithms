using System;
using System.Collections.Generic;

namespace Algorithms.Sort
{
    public class TestSort
    {
        public static void Test(Func<List<int>, List<int>> sort, string type)
        {
            var input1 = new List<int> { 5, 4, 1, 2, 3 };
            var sort1 = sort(input1);
            Console.WriteLine($"{type}: the result of first sort is ");
            foreach (var num in sort1)
            {
                Console.Write($"{Convert.ToString(num)},");
            }
            
            Console.WriteLine();
            
            var input2 = new List<int> { 5, 2, 4, 1, 7, 9, -1, -5 };
            var sort2 = sort(input2);
            Console.WriteLine($"{type}: the result of second sort is");
            foreach (var num in sort2)
            {
                Console.Write($"{Convert.ToString(num)},");
            }
            
            Console.WriteLine();
            
            var input3 = new List<int> { 64, 25, 12, 22, 11 };
            var sort3 = sort(input3);
            Console.WriteLine($"{type}: the result of third sort is");
            foreach (var num in sort3)
            {
                Console.Write($"{Convert.ToString(num)},");
            }

            Console.WriteLine();
            
            var input4 = new List<int> { 12, 11, 13, 5, 6, 7 };
            var sort4 = sort(input4);
            Console.WriteLine($"{type}: the result of fourth sort is");
            foreach (var num in sort4)
            {
                Console.Write($"{Convert.ToString(num)},");
            }

            Console.WriteLine();
            Console.WriteLine($"This is the end of {type}");
        }
    }
}