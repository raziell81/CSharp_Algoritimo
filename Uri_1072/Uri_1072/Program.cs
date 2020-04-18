using System;

namespace Uri_1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X, inside = 0, outside = 0;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                X = int.Parse(Console.ReadLine());
                if (X >= 10 && X <= 20)
                {
                    inside++;
                }
                else
                {
                    outside++;
                }
            }
            Console.WriteLine(inside + " in");
            Console.WriteLine(outside + " out");

        }
    }
}