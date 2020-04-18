using System;

namespace Uri_1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, min, max, total;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X < Y)
            {
                min = X;
                max = Y;
            }
            else
            {
                min = Y;
                max = X;
            }

            total = 0;

            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    total += i;
                }
            }
            Console.WriteLine(total);
        }
    }
}