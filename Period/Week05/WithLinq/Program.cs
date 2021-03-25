using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WithLinq
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("问题：");
            Console.WriteLine("随机生成100个0~1000间的整数，使用Linq语句对这些整数从大到小排序，并求和与平均数。");

            IList<int> numbers = new List<int>();
            var random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int num = random.Next(0, 1000 + 1);
                numbers.Add(num);
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("原顺序：");
            DisplayNumber(numbers);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("排序后：");
            var sortedNumbers = from n in numbers orderby n select n ;
            DisplayNumber(sortedNumbers);

            int sum = numbers.Sum();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("总和：{0}", sum);
            Console.WriteLine("均值：{0}", (double)sum / numbers.Count);

        }

        private static void DisplayNumber(IEnumerable<int> numbers)
        {
            int c = 0;
            foreach (var number in numbers)
            {
                c++;
                Console.Write("{0}\t", number);
                if (c % 5 == 0) Console.WriteLine();
            }
        }
    }
}