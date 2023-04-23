using System;

namespace _230423_Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            long a = long.Parse(str[0]);
            long b = long.Parse(str[1]);
            long c = long.Parse(str[2]);

            Console.WriteLine(a+b+c);
        }
    }
}
