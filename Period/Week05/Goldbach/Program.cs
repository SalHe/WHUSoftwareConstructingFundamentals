using System;

namespace Goldbach
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("问题：");
            Console.WriteLine("“哥德巴赫猜想”指出，每个大于6的偶数，都可以表示为两个素数的和。试用程序将6~100内的所有偶数都表示为两个素数的和。");

            for (int i = 6; i <= 100; i = i + 2)
            {
                int[] com = FindCombination(i);
                if (com == null) // 如果哥德巴赫猜想正确，那么这是不可能发生的
                {
                    Console.WriteLine("找不到组合");
                    continue;
                }

                Console.WriteLine("{0} = {1} + {2}", i, com[0], com[1]);
            }
        }

        private static int[] FindCombination(int number)
        {
            for (int i = 2; i <= number; i++)
            {
                int another = number - i;
                if (IsPrime(i) && IsPrime(another)) return new[] { i, another };
            }

            return null;
        }

        private static bool IsPrime(int number)
        {
            if (number <= 0) throw new ArgumentException("待检测是否为素数的数不可为负数");
            if (number <= 3) return true;
            for (int i = 2; i <= Math.Sqrt(number) + 1; i++)
                if (number % i == 0) return false;

            return true;
        }
    }
}
